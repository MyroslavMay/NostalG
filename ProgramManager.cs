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
            mainLayout.Padding = new Padding(8);
            mainLayout.Margin = Padding.Empty;

            int count1 = Helpers.GetTotalFolders(@$"C:\Users\{Environment.UserName}\AppData\Roaming\Microsoft\Windows\Start Menu\Programs");
            string[] folderNames1 = Helpers.GetFoldersNames(@$"C:\Users\{Environment.UserName}\AppData\Roaming\Microsoft\Windows\Start Menu\Programs");

            int count2 = Helpers.GetTotalFolders(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs");
            string[] folderNames2 = Helpers.GetFoldersNames(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs");

            int count = count1 + count2;
            string[] folderNames = [.. folderNames1, .. folderNames2];

            for (int i = 0; i < count; i++)
            {
                var folderItem = new FolderItem(folderNames[i]);
                folderItem.Margin = new Padding(8);
                mainLayout.Controls.Add(folderItem);
            }
        }
    }
}
