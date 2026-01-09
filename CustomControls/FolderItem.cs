using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace NostalG.CustomControls
{
    public partial class FolderItem : UserControl
    {
        private readonly PrivateFontCollection fonts = new();
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

        void LabelInit(System.Windows.Forms.Label label)
        {
            int line = TextRenderer.MeasureText("A", label.Font).Height;
            int height = line * 2 + 2;

            label.AutoSize = false;
            label.Height = height;
            label.MinimumSize = new Size(label.Width, height);
            label.MaximumSize = new Size(label.Width, height);

            label.TextAlign = ContentAlignment.TopCenter;
            label.AutoEllipsis = true;
        }

        private void FolderItem_Load(object sender, EventArgs e)
        {
            mainLayout.RowStyles.Clear();
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 46));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            //mainLayout.RowStyles[1] = new RowStyle(SizeType.Absolute, labelHeight);

            folderImg.SizeMode = PictureBoxSizeMode.CenterImage;
            folderImg.Margin = Padding.Empty;

            folderLbl.UseCompatibleTextRendering = true;
            folderLbl.Margin = Padding.Empty;

            fonts.AddFontFile(Path.Combine(AppContext.BaseDirectory, "Assets", "MS Sans Serif.ttf"));

            folderLbl.Font = new Font(fonts.Families[0], 8f, FontStyle.Bold);
            folderLbl.AutoSize = false;

            folderLbl.TextAlign = ContentAlignment.BottomCenter;
            folderLbl.Dock = DockStyle.Bottom;

            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.AutoScaleMode = AutoScaleMode.None;

            LabelInit(folderLbl);
        }
    }
}
