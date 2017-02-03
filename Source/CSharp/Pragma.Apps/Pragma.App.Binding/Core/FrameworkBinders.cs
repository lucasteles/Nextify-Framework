
using Pragma.Business;
using Pragma.Business.Abstraction;
using Pragma.DAO;
using Pragma.DAO.Abstraction;
using Pragma.Files;
using Pragma.Forms.Controllers;
using Pragma.Forms.Controllers.GridItems;
using Pragma.IOC;
using Pragma.IOC.Abstraction;
using Pragma.Logging;
using Pragma.Logging.Abstraction;
using Pragma.Mapping;
using Pragma.Mapping.Core;
using ModelViewBinder;
using Pragma.Scheduling;

namespace Pragma.App.Binding
{
    public class FrameworkBinders : IBinder
    {

        public void SetBinding(IContainer container)
        {

            container.Register(typeof(IBusiness<,>), typeof(BaseBusiness<,>));
            container.Register(typeof(IBusiness<>), typeof(BaseBusiness<>));
            container.Register(typeof(IRepository<,>), typeof(BaseRepository<,>));
            container.Register(typeof(IRepository<>), typeof(BaseRepository<>));
            container.Register(typeof(IModelViewBinder<>), typeof(ModelViewBinder<>));
            container.Register(typeof(IEditController<>), typeof(EditController<>));
            container.Register(typeof(IGridListController<>), typeof(GridListController<>));

            container.Register<IContainer, DryIocContainer>(Lifecircle.Singleton);
            container.Register<ILogger, Log4NetAdapter>();
            container.Register<IMapper, Mapper>();
            container.Register<IScheduleManager, ScheduleManager>();
            container.Register<IFileHelper, FileHelper>();

        }
    }
}
