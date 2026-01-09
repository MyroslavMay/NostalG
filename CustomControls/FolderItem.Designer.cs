namespace NostalG.CustomControls
{
    partial class FolderItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderItem));
            mainLayout = new System.Windows.Forms.TableLayoutPanel();
            folderImg = new System.Windows.Forms.PictureBox();
            folderLbl = new System.Windows.Forms.Label();
            mainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)folderImg).BeginInit();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.AutoSize = true;
            mainLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            mainLayout.Controls.Add(folderImg, 0, 0);
            mainLayout.Controls.Add(folderLbl, 0, 1);
            mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            mainLayout.Location = new System.Drawing.Point(0, 0);
            mainLayout.MaximumSize = new System.Drawing.Size(64, 80);
            mainLayout.MinimumSize = new System.Drawing.Size(64, 80);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 2;
            mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.8095245F));
            mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.1904755F));
            mainLayout.Size = new System.Drawing.Size(64, 80);
            mainLayout.TabIndex = 2;
            // 
            // folderImg
            // 
            folderImg.Dock = System.Windows.Forms.DockStyle.Fill;
            folderImg.Image = (System.Drawing.Image)resources.GetObject("folderImg.Image");
            folderImg.Location = new System.Drawing.Point(3, 3);
            folderImg.Name = "folderImg";
            folderImg.Size = new System.Drawing.Size(58, 33);
            folderImg.TabIndex = 0;
            folderImg.TabStop = false;
            // 
            // folderLbl
            // 
            folderLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            folderLbl.Location = new System.Drawing.Point(3, 39);
            folderLbl.Name = "folderLbl";
            folderLbl.Size = new System.Drawing.Size(58, 41);
            folderLbl.TabIndex = 1;
            folderLbl.Text = "Folder";
            folderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FolderItem
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(mainLayout);
            Name = "FolderItem";
            Size = new System.Drawing.Size(112, 81);
            Load += FolderItem_Load;
            mainLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)folderImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.PictureBox folderImg;
        private System.Windows.Forms.Label folderLbl;
    }
}
