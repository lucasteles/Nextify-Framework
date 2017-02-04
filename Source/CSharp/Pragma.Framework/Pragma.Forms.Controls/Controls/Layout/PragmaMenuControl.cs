using Pragma.Core;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pragma.Forms.Controls
{
    public partial class PragmaMenuControl : PragmaUserControl
    {
        public Color IconBaseColor { get; set; } = ColorTool.MetroRed;

        public PragmaMenuControl()
        {
            InitializeComponent();
        }

        public void AddItem(PragmaMenuItemControl item)
        {
            var menuItem = item;
            menuItem.Nivel = 0;
            menuItem.IconBaseColor = IconBaseColor;
            tblSubMenus.RowCount = tblSubMenus.RowCount + 1;
            tblSubMenus.RowStyles.Add(new RowStyle(SizeType.AutoSize, 50F));
            tblSubMenus.Controls.Add(menuItem, 0, tblSubMenus.RowCount - 1);
        }

        public void SetMenus(List<Models.PragmaMenuItem> menuList)
        {
            foreach (var item in menuList)
            {
                var subMenu = new PragmaMenuItemControl(item, 0);
                
                AddItem(subMenu);
                subMenu.AddItems(item.ChildMenus);
            }
        }
    }
}
