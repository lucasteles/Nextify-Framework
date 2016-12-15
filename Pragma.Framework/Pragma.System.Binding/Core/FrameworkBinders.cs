using Pragma.Business;
using Pragma.Business.Abstraction;
using Pragma.DAO;
using Pragma.DAO.Abstraction;
using Pragma.Forms.ControlBinding;
using Pragma.Forms.Controllers;
using Pragma.IOC;
using Pragma.IOC.Abstraction;
using Pragma.Logging;
using Pragma.Logging.Abstraction;
using Pragma.Mapping;
using Pragma.Mapping.Core;
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
            container.Register(typeof(IControlBinder<>), typeof(ControlBinder<>));
            container.Register(typeof(IEditController<>), typeof(EditController<>));
            container.Register<IContainer, DryIocContainer>(Lifecircle.Singleton);
            container.Register<ILogger, Log4NetAdapter>();
            container.Register<IMapper, Mapper>();
            container.Register<IScheduleManager, ScheduleManager>();


        }
    }
}
