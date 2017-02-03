using MetroFramework;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pragma.Forms.Controls
{
    public partial class PragmaButton : MetroButton
    {
        MetroThemeStyle ThemeActive;
        public PragmaButton()
        {
            InitializeComponent();
            ThemeActive = Theme;
        }

        private void PragmaButton_CustomPaint(object sender, MetroFramework.Drawing.MetroPaintEventArgs e)
        {
            if (DesignMode)
                return;

            // TODO: Terminar a inversão de cores
            var but = (MetroButton)sender;
            if (but.BackgroundImage == null)
                return;

            if (but.Theme != ThemeActive)
            {
                var pic = new Bitmap(but.BackgroundImage);
                for (int y = 0; (y <= (pic.Height - 1)); y++)
                {
                    for (int x = 0; (x <= (pic.Width - 1)); x++)
                    {
                        var inv = pic.GetPixel(x, y);
                        if (inv.A > 0)
                            inv = Color.FromArgb(255, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                        pic.SetPixel(x, y, inv);
                    }
                }
                but.BackgroundImage = pic;
                ThemeActive = but.Theme;

                Console.WriteLine(but.Name + "Executou." + but.Theme.ToString());
            }
        }
    }
}
