using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NostalG
{
    public partial class Background : Form
    {

        [DllImport("user32.dll")]
        private static extern bool SetWindowPos(
            IntPtr hWnd,
            IntPtr hWndInsertAfter,
            int X,
            int Y,
            int cx,
            int cy,
            uint uFlags);

        private static readonly IntPtr HWND_BOTTOM = new IntPtr(1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 SWP_NOACTIVATE = 0x0010;


        private ProgramManager _pm;

        private void ContextMenuInit()
        {
            ContextMenu cm = new ContextMenu();

            cm.MenuItems.Add("Change Wallpaper");
            cm.MenuItems.Add("Set wallpaper color");

            this.ContextMenu = cm;
        }

        public Background()
        {
            InitializeComponent();
            ContextMenuInit();
        }

        private void Background_Shown(object sender, EventArgs e)
        {
            // Ensure this window is placed at the bottom of Z-order
            SetWindowPos(this.Handle, HWND_BOTTOM, 0, 0, 0, 0,
                SWP_NOMOVE | SWP_NOSIZE | SWP_NOACTIVATE);

            if (_pm == null)
            {
                this.BeginInvoke((Action)(() =>
                {
                    _pm = new ProgramManager();
                    _pm.Show();
                }));
            }
        }
    }
}