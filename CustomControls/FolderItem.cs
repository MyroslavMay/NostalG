using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NostalG.CustomControls
{
    public partial class FolderItem : UserControl
    {
        PrivateFontCollection fonts = new PrivateFontCollection();
        private string? _folderName;

        public FolderItem()
        {
            InitializeComponent();
        }

        public FolderItem(string folderName) : this()
        {
            _folderName = folderName;
            if (folderLbl != null)
            {
                folderLbl.Text = _folderName;
            }
        }

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Program name displayed on the bar")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ProgName
        {
            get => _folderName!;
            set
            {
                _folderName = value;
                if (folderLbl != null)
                {
                    folderLbl.Text = _folderName;
                }
            }
        }

        private void FolderItem_Load(object sender, EventArgs e)
        {
            fonts.AddFontFile(Path.Combine(AppContext.BaseDirectory, "Assets", "MS Sans Serif.ttf"));

            this.AutoScaleMode = AutoScaleMode.None;
            folderLbl.UseCompatibleTextRendering = true;
            folderLbl.Font = new Font(fonts.Families[0], 8);
        }
    }
}
