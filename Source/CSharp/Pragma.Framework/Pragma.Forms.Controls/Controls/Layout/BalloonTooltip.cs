using Pragma.Abstraction.Forms.Controls;
using Pragma.Core;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Pragma.Forms.Controls
{
    public class BalloonTip : IDisposable, IBallontip
    {
        private readonly System.Timers.Timer timer = new System.Timers.Timer();
        private readonly SemaphoreSlim semaphore = new SemaphoreSlim(1);
        private IntPtr hWnd;

        public BalloonTip()
        {

        }

        public void Show(string title, string text, Control control, BalloonIcon icon = 0, double timeOut = 0, bool focus = false, short x = 0, short y = 0)
        {
            Close();
            if (x == 0 && y == 0)
            {
                x = (short)(control.RectangleToScreen(control.ClientRectangle).Left + control.Width / 2);
                y = (short)(control.RectangleToScreen(control.ClientRectangle).Top + control.Height / 2);
            }
            var toolInfo = new TOOLINFO();
            toolInfo.cbSize = (uint)Marshal.SizeOf(toolInfo);
            toolInfo.uFlags = 0x20; // TTF_TRACK
            toolInfo.lpszText = text;
            var pToolInfo = Marshal.AllocCoTaskMem(Marshal.SizeOf(toolInfo));
            Marshal.StructureToPtr(toolInfo, pToolInfo, false);
            var buffer = title.ToCharArray().Select(e => (byte)e).ToArray();
            buffer = buffer.Concat(new byte[] { 0 }).ToArray();
            var pszTitle = Marshal.AllocCoTaskMem(buffer.Length);
            Marshal.Copy(buffer, 0, pszTitle, buffer.Length);
            hWnd = User32.CreateWindowEx(0x8, "tooltips_class32", "", 0xC3, 0, 0, 0, 0, control.Parent.Handle, (IntPtr)0, (IntPtr)0, (IntPtr)0);
            User32.SendMessage(hWnd, 1028, (IntPtr)0, pToolInfo); // TTM_ADDTOOL
            User32.SendMessage(hWnd, 1042, (IntPtr)0, (IntPtr)((ushort)x | ((ushort)y << 16))); // TTM_TRACKPOSITION
            //User32.SendMessage(hWnd, 1043, (IntPtr)0, (IntPtr)0); // TTM_SETTIPBKCOLOR
            //User32.SendMessage(hWnd, 1044, (IntPtr)0xffff, (IntPtr)0); // TTM_SETTIPTEXTCOLOR
            User32.SendMessage(hWnd, 1056, (IntPtr)icon, pszTitle); // TTM_SETTITLE 0:None, 1:Info, 2:Warning, 3:Error, >3:assumed to be an hIcon. ; 1057 for Unicode
            User32.SendMessage(hWnd, 1048, (IntPtr)0, (IntPtr)500); // TTM_SETMAXTIPWIDTH
            User32.SendMessage(hWnd, 0x40c, (IntPtr)0, pToolInfo); // TTM_UPDATETIPTEXT; 0x439 for Unicode
            User32.SendMessage(hWnd, 1041, (IntPtr)1, pToolInfo); // TTM_TRACKACTIVATE
            Marshal.FreeCoTaskMem(pszTitle);
            Marshal.DestroyStructure(pToolInfo, typeof(TOOLINFO));
            Marshal.FreeCoTaskMem(pToolInfo);
            if (focus)
                control.Focus();
            // uncomment bellow to make balloon close when user changes focus,
            // starts typing, resizes/moves parent window, minimizes parent window, etc
            // adjust which control events to subscribe to depending on the control over which the balloon tip is shown
            /*
            control.Click += control_Event;
            control.Leave += control_Event;
            control.TextChanged += control_Event;
            control.LocationChanged += control_Event;
            control.SizeChanged += control_Event;
            control.VisibleChanged += control_Event;
            var parent = control.Parent;
            while (parent != null)
            {
                parent.VisibleChanged += control_Event;
                parent = parent.Parent;
            }
            control.TopLevelControl.LocationChanged += control_Event;
            ((Form)control.TopLevelControl).Deactivate += control_Event;*/

            timer.AutoReset = false;
            timer.Elapsed += timer_Elapsed;
            if (timeOut > 0)
            {
                timer.Interval = timeOut;
                timer.Start();
            }
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Close();
        }
        /*
        void control_Event(object sender, EventArgs e)
        {
            Close();
        }
        */
        public void Close()
        {
            //   if (!semaphore.Wait(0)) // ensures one time only execution
            //       return;
            timer.Elapsed -= timer_Elapsed;
            timer.Close();
            User32.SendMessage(hWnd, 0x0010, (IntPtr)0, (IntPtr)0); // WM_CLOSE
            //User32.SendMessage(hWnd, 0x0002, (IntPtr)0, (IntPtr)0); // WM_DESTROY
            //User32.SendMessage(hWnd, 0x0082, (IntPtr)0, (IntPtr)0); // WM_NCDESTROY
        }

        [StructLayout(LayoutKind.Sequential)]
        struct TOOLINFO
        {
            public uint cbSize;
            public uint uFlags;
            public IntPtr hwnd;
            public IntPtr uId;
            public RECT rect;
            public IntPtr hinst;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpszText;
            public IntPtr lParam;
        }
        [StructLayout(LayoutKind.Sequential)]
        struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        public void Dispose()
        {
            timer.Dispose();
            semaphore.Dispose();
            GC.SuppressFinalize(this);
        }
    }

  
    static class User32
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern IntPtr CreateWindowEx(uint dwExStyle, string lpClassName, string lpWindowName, uint dwStyle, int x, int y, int nWidth, int nHeight, IntPtr hWndParent, IntPtr hMenu, IntPtr hInstance, IntPtr LPVOIDlpParam);
    }
}
