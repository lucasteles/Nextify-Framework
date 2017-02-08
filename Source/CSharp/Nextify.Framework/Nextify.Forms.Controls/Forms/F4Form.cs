using Nextify.Abstraction.Forms.Controls;
using Nextify.Core.Icons;
using System.Threading.Tasks;

namespace Nextify.Forms.Controls.Forms
{
    public partial class F4Form : FormConsult
    {
        public F4Form() : base(null)
        {
            InitializeComponent();
            HasEdit = HasAdd = HasInative = HasDelete = false;

            FilterInative = true;

            cmtFilterInative.BackgroundImage = BaseIcons.glasses_invert;
        }

        public async Task SetController(IGridController controller)
        {
            controller.F4Mode = true;
            Configure(controller);
            GridController.FilterInative = FilterInative;
            await Task.FromResult(0);
        }

        public override Task FormLoadAsync()
        {
            Grid.FocusFilter();
            return base.FormLoadAsync();
        }
    }
}
