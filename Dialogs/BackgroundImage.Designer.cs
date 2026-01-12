namespace NostalG.Dialogs
{
    partial class BackgroundImage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            modeList = new System.Windows.Forms.ListBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            modeLbl = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(379, 25);
            label1.TabIndex = 0;
            label1.Text = "This is not a native 3.1 feature, so be careful :D";
            // 
            // modeList
            // 
            modeList.FormattingEnabled = true;
            modeList.Items.AddRange(new object[] { "Center", "None (top left corner)", "Stretch", "Tile", "Zoom" });
            modeList.Location = new System.Drawing.Point(435, 184);
            modeList.Name = "modeList";
            modeList.Size = new System.Drawing.Size(180, 129);
            modeList.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(435, 156);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(118, 25);
            label2.TabIndex = 4;
            label2.Text = "Image mode:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(454, 316);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(126, 25);
            label3.TabIndex = 5;
            label3.Text = "Current mode:";
            // 
            // modeLbl
            // 
            modeLbl.AutoSize = true;
            modeLbl.Location = new System.Drawing.Point(482, 341);
            modeLbl.Name = "modeLbl";
            modeLbl.Size = new System.Drawing.Size(44, 25);
            modeLbl.TabIndex = 6;
            modeLbl.Text = "N/A";
            // 
            // BackgroundImage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(641, 426);
            Controls.Add(modeLbl);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(modeList);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Name = "BackgroundImage";
            Text = "Change Background Image";
            Load += BackgroundImage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox modeList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label modeLbl;
    }
}