
using Nextify.Abstraction.IOC;
using Nextify.App.Forms.Controllers;
using Nextify.App.Forms.Controllers.Combos;
using Nextify.App.Forms.Controllers.Grids;


namespace Nextify.App.Binding
{
    public class ControllersBinder : IBinder
    {
        public void SetBinding(IContainer container)
        {
            container.Register<IConnectionComboController, ConnectionComboController>();
            container.Register<ICourseGridController, CourseGridController>();
            container.Register<IAuthorGridController, AuthorGridController>();
            container.Register<ITagGridController, TagGridController>();
        }

    }
}
