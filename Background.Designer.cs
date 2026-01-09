namespace NostalG
{
    partial class Background
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
            colorDlg = new System.Windows.Forms.ColorDialog();
            SuspendLayout();
            // 
            // colorDlg
            // 
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = true;
            // 
            // Background
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(889, 562);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Background";
            ShowInTaskbar = false;
            Text = "NostalG background";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Shown += Background_Shown;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDlg;
    }
}

