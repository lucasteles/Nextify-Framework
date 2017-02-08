using Nextify.Core;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Nextify.Forms.Controls
{
    public partial class NextifyMenuControl : NextifyUserControl
    {
        public Color IconBaseColor { get; set; } = ColorTool.MetroRed;

        public NextifyMenuControl()
        {
            InitializeComponent();
        }

        public void AddItem(NextifyMenuItemControl item)
        {
            var menuItem = item;
            menuItem.Nivel = 0;
            menuItem.IconBaseColor = IconBaseColor;
            tblSubMenus.RowCount = tblSubMenus.RowCount + 1;
            tblSubMenus.RowStyles.Add(new RowStyle(SizeType.AutoSize, 50F));
            tblSubMenus.Controls.Add(menuItem, 0, tblSubMenus.RowCount - 1);
        }

        public void SetMenus(List<Models.NextifyMenuItem> menuList)
        {
            foreach (var item in menuList)
            {
                var subMenu = new NextifyMenuItemControl(item, 0);
                
                AddItem(subMenu);
                subMenu.AddItems(item.ChildMenus);
            }
        }
    }
}
