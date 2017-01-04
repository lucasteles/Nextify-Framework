using AutoMapper;
using Pragma.App.Model;
using Pragma.Forms.Models;
using System.Drawing;
using System.Reflection;

namespace Pragma.App.Mapping.Profiles
{
    public class MenuItemProfile : Profile
    {
        public MenuItemProfile()
        {
            CreateMap<DbMenuSistema, PragmaMenuItem>()
                .ConvertUsing(src =>
                {
                    var dest = new PragmaMenuItem
                    {
                        Name = src.Nome,
                        Order = src.Ordem,
                    };
                    var pgmCore = Assembly.Load(typeof(Core.Icons.Alphabet).Assembly.FullName);
                    var resType = pgmCore?.GetType(src.ClasseDoIcone.Replace("PGM.Common", "Pragma.Core"));
                    var property = resType?.GetProperty(src.Icone);
                    dest.Icon = (Bitmap)property?.GetValue(null);

                    if (string.IsNullOrEmpty(src.Namespace) || string.IsNullOrEmpty(src.Classe))
                        return dest;

                    dest.ButtonAction = () =>
                    {
                        var assembly = Assembly.Load(src.Namespace);
                        var type = assembly?.GetType(src.Classe);
                        if (type == null) return;

                        var form = (System.Windows.Forms.Form)IOC.ContainerFactory.Container.Resolve(type);
                        if (form != null)
                            form.Show();
                    };
                    return dest;
                });
        }
    }
}
