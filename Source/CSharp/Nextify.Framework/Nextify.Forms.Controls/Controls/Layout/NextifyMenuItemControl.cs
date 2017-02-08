
using Nextify.Core;
using Nextify.Core.Properties;
using Nextify.Forms.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Nextify.Forms.Controls
{
    public partial class NextifyMenuItemControl : NextifyUserControl
    {
        private static int ImageSize = 15;
        private static int ImagePadding = 5;
        private static readonly int ChildPadding = 15;
        private static readonly int ColorStep = 30;
        private static int ButtonHeight = 25;

        private bool _isMouseOver;
        public Bitmap Icone { get; set; }
        public int Nivel { get; set; }
        public Action ButtonAction { get; set; }
        public Color IconBaseColor { get; set; } =  ColorTool.MetroRed ;

        public NextifyMenuItemControl(NextifyMenuItem menuItem, int nivel)
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
            Margin = new Padding(0);
            cmdAbrir.Height = ButtonHeight;
            cmdAbrir.Text = menuItem.Name;
            Nivel = nivel;
            var color = 255 - ColorStep * Nivel;
            color = color < 0 ? 0 : color;
            cmdAbrir.BackColor = Color.FromArgb(color, color, color);
            

            //Seta de abertura do menu
            if (menuItem.ChildMenus.Count == 0)
            {
                cmdAbrir.Image = null;

                //Action
                ButtonAction = menuItem.ButtonAction;
            }
            //Icone
            Icone = menuItem.Icon;
        }
        public void AddItems(List<NextifyMenuItem> childMenus)
        {
            foreach (var item in childMenus)
            {
                var subMenu = new NextifyMenuItemControl(item, Nivel + 1);
                AddItem(subMenu);
                subMenu.AddItems(item.ChildMenus);
            }
        }
        public void AddItem(NextifyMenuItemControl menuItem)
        {
            tblSubMenus.RowCount = tblSubMenus.RowCount + 1;
            tblSubMenus.RowStyles.Add(new RowStyle(SizeType.AutoSize, 50F));
            tblSubMenus.Controls.Add(menuItem, 0, tblSubMenus.RowCount - 1);
        }

        private void cmdAbrir_Click(object sender, System.EventArgs e)
        {
            tblSubMenus.Visible = !tblSubMenus.Visible;
            if (ButtonAction == null)
            {
                if (tblSubMenus.Visible)
                    cmdAbrir.Image = Resources.fa_chevron_up;
                else
                    cmdAbrir.Image = Resources.fa_chevron_down;
            }
            else
                ButtonAction();

        }

        protected void cmdAbrir_Paint(object sender, PaintEventArgs e)
        {
            cmdAbrir.Padding = new Padding(Nivel * ChildPadding + ImageSize + 2 * ImagePadding - 5, 0, 0, 0);

            //Linha vermelha lateral
            if (_isMouseOver)
                using (var brush = new SolidBrush(IconBaseColor))
                    e.Graphics.FillRectangle(brush, new Rectangle(0, 0, 5, ButtonHeight));

            //Borda inferior
            var lineColor = Color.FromArgb(cmdAbrir.BackColor.R - 75, cmdAbrir.BackColor.R - 75, cmdAbrir.BackColor.R - 75);
            using (var pen = new Pen(lineColor))
                e.Graphics.DrawLine(pen, 0, ButtonHeight - 1, cmdAbrir.Width, ButtonHeight - 1);

            //Linha guia
            //using (var pen = new Pen(Color.Black))
            //{
            //    if (Menu.MenusFilhos.Count > 0 && tblSubMenus.Visible)
            //    {
            //        e.Graphics.DrawLine(pen, ButtonHeight / 2 + Nivel * ChildPadding, ButtonHeight - ImagePadding, ButtonHeight / 2 + Nivel * ChildPadding, ButtonHeight);
            //    }
            //    pen.Width = 1;
            //    for (int i = 0; i < Lines; i++)
            //    {
            //        //Linhas verticais exeto ultima
            //        e.Graphics.DrawLine(pen, ButtonHeight / 2 + i * ChildPadding, 0, ButtonHeight / 2 + i * ChildPadding, ButtonHeight);
            //    }
            //    if (Nivel > 0)
            //    {
            //        //linha horizontal
            //        e.Graphics.DrawLine(pen, ButtonHeight / 2 + (Nivel - 1) * ChildPadding, ButtonHeight / 2, ChildPadding - ImageSize / 2 + ButtonHeight / 2 + (Nivel - 1) * ChildPadding, ButtonHeight / 2);
            //        if (IsLastMenu)
            //        {
            //            e.Graphics.DrawLine(pen, ButtonHeight / 2 + (Nivel - 1) * ChildPadding, 0, ButtonHeight / 2 + (Nivel - 1) * ChildPadding, ButtonHeight / 2);
            //        }
            //        else
            //        {
            //            e.Graphics.DrawLine(pen, ButtonHeight / 2 + (Nivel - 1) * ChildPadding, 0, ButtonHeight / 2 + (Nivel - 1) * ChildPadding, ButtonHeight);
            //        }
            //    }
            //}

            var rect = new Rectangle(Nivel * ChildPadding + ImagePadding + 5, ImagePadding, ImageSize, ImageSize);

            if (Icone != null)
                e.Graphics.DrawImage(ImageTool.ColorShift(ImageTool.Resize(Icone, ImageSize, ImageSize), IconBaseColor), rect);
        }

        private void CmdAbrir_MouseLeave(object sender, EventArgs e)
        {
            _isMouseOver = false;
        }

        private void CmdAbrir_MouseEnter(object sender, EventArgs e)
        {
            _isMouseOver = true;
        }
    }
}
