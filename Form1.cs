using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NostalG
{
    public partial class Form1 : Form
    {

        private void ContextMenuInit()
        {
            ContextMenu cm = new ContextMenu();

            cm.MenuItems.Add("Change Wallpaper");
            cm.MenuItems.Add("Set wallpaper color");

            this.ContextMenu = cm;
        }

        public Form1()
        {
            InitializeComponent();

            ContextMenuInit();
        }
    }
}
