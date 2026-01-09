namespace NostalG
{
    partial class ProgramManager
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
            titleBar = new NostalG.titlebars.DefaultProgramBar();
            mainLayout = new System.Windows.Forms.FlowLayoutPanel();
            SuspendLayout();
            // 
            // titleBar
            // 
            titleBar.BackColor = System.Drawing.Color.FromArgb(0, 0, 168);
            titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            titleBar.Location = new System.Drawing.Point(0, 0);
            titleBar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            titleBar.Name = "titleBar";
            titleBar.ProgName = null;
            titleBar.Size = new System.Drawing.Size(889, 54);
            titleBar.TabIndex = 0;
            // 
            // mainLayout
            // 
            mainLayout.AutoScroll = true;
            mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            mainLayout.Location = new System.Drawing.Point(0, 54);
            mainLayout.Name = "mainLayout";
            mainLayout.Size = new System.Drawing.Size(889, 508);
            mainLayout.TabIndex = 1;
            // 
            // ProgramManager
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(889, 562);
            Controls.Add(mainLayout);
            Controls.Add(titleBar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ProgramManager";
            Text = "Program Manager";
            Load += ProgramManager_Load;
            ResumeLayout(false);

        }

        #endregion

        private titlebars.DefaultProgramBar titleBar;
        private System.Windows.Forms.FlowLayoutPanel mainLayout;
    }
}