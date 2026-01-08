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
    public partial class ProgramManager : Form
    {
        public ProgramManager()
        {
            InitializeComponent();

            titleBar.ProgName = "Program Manager";
            titleBar.CloseRequested += (s, e) => this.Close();
        }

        private void ProgramManager_Load(object sender, EventArgs e)
        {

        }
    }
}
