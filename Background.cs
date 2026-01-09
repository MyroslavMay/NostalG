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


        private ProgramManager? _pm;

        private void ChangeBgColor(object sender, EventArgs e)
        {
            colorDlg.ShowDialog();
            this.BackColor = colorDlg.Color;

            if (this.BackgroundImage != null)
            {
                this.BackgroundImage = null;
            }
        }

        private void ChangeBg(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            fd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
            fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            fd.ShowDialog();

            if (!string.IsNullOrEmpty(fd.FileName))
            {
                try
                {
                    Image img = Image.FromFile(fd.FileName);
                    this.BackgroundImage = img;
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
                
        }

        private void ContextMenuInit()
        {
            var cms = new ContextMenuStrip();

            cms.Items.Add(new ToolStripMenuItem("Change Wallpaper", null, ChangeBg));
            cms.Items.Add(new ToolStripMenuItem("Set wallpaper color", null, ChangeBgColor));

            this.ContextMenuStrip = cms;
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