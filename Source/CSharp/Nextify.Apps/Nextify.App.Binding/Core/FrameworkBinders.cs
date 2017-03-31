
using Nextify.Business;
using Nextify.DAO;
using Nextify.Files;
using Nextify.Forms.Controllers;
using Nextify.Forms.Controllers.GridItems;
using Nextify.IOC;
using Nextify.Logging;
using Nextify.Mapping;
using Nextify.Mapping.Core;
using Nextify.Scheduling;
using Nextify.Abstraction.IOC;
using Nextify.Abstraction.Business;
using Nextify.Abstraction.DAO;
using Nextify.Abstraction.Forms.Controllers;
using Nextify.Abstraction.Forms.Controllers.GridItems;
using Nextify.Core;
using Nextify.Abstraction.Logging;
using Nextify.Abstraction.Scheduling;
using Nextify.Abstraction.Files;
using ModelViewBinder;
using ModelViewBinder.Forms;

namespace Nextify.App.Binding
{
    public class FrameworkBinders : IBinder
    {

        public void SetBinding(IContainer container)
        {

            container.Register(typeof(IBusiness<,>), typeof(BaseBusiness<,>));
            container.Register(typeof(IBusiness<>), typeof(BaseBusiness<>));
            container.Register(typeof(IRepository<,>), typeof(BaseRepository<,>));
            container.Register(typeof(IRepository<>), typeof(BaseRepository<>));
            container.Register(typeof(IModelViewBinder<>), typeof(FormModelViewBinder<>));
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
