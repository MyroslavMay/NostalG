using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NostalG.Dialogs
{
    public partial class BackgroundImage : Form
    {
        public BackgroundImage()
        {
            InitializeComponent();
        }

        private void BackgroundImage_Load(object sender, EventArgs e)
        {
            modeLbl.Text = Properties.Settings.Default.BgImageMode.ToString();
        }
    }
}
