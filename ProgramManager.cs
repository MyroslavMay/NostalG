using Microsoft.VisualBasic.ApplicationServices;
using NostalG.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            titleBar.CloseRequested += (s, e) => Application.Exit();
        }

        private void ProgramManager_Load(object sender, EventArgs e)
        {
            int count = Helpers.GetTotalFolders(@$"C:\Users\{Environment.UserName}\AppData\Roaming\Microsoft\Windows\Start Menu\Programs");

            for (int i = 0; i < count; i++)
            {
                mainLayout.Controls.Add(new FolderItem("Test"));
            }
        }
    }
}
