using Pragma.App.DAO;
using Pragma.App.Model;
using Pragma.Business;
using Pragma.Business.Abstraction;
using Pragma.Forms.Models;
using Pragma.Mapping;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pragma.App.Business.Sys
{
    public interface IMenuPrincipalBusiness : IBusiness<DbMenuSistema>
    {
        Task<IEnumerable<PragmaMenuItem>> GetAllMenus();
    }
    public class MenuPrincipalBusiness : BaseBusiness<DbMenuSistema>, IMenuPrincipalBusiness
    {
        readonly IMenuUnitOfWork UnitOfWork;
        readonly IMapper Mapper;

        public MenuPrincipalBusiness(IMenuUnitOfWork unitOfWork,
            IMapper mapper)
            : base(unitOfWork, null, null)
        {
            UnitOfWork = unitOfWork;
            Mapper = mapper;
        }

        public async Task<IEnumerable<PragmaMenuItem>> GetAllMenus()
        {
            var menuList = await UnitOfWork
                .Menu
                .GetAsync(i => i.FkMenu == 0, i => i.MenusFilhos
                    .Select(j => j.MenusFilhos
                    .Select(k => k.MenusFilhos)));


            return ParseMenu(menuList);
        }

        private List<PragmaMenuItem> ParseMenu(IEnumerable<DbMenuSistema> sourceList)
        {
            var list = new List<PragmaMenuItem>();

            foreach (var src in sourceList)
            {
                var viewModel = Mapper.Map<DbMenuSistema, PragmaMenuItem>(src);
                list.Add(viewModel);
                viewModel.ChildMenus = ParseMenu(src.MenusFilhos);
            }
            return list;
        }
    }
}
