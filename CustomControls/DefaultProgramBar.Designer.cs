namespace NostalG.titlebars
{
    partial class DefaultProgramBar
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
            progLbl = new System.Windows.Forms.Label();
            closeBtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // progLbl
            // 
            progLbl.AutoSize = true;
            progLbl.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            progLbl.ForeColor = System.Drawing.Color.White;
            progLbl.Location = new System.Drawing.Point(394, 7);
            progLbl.Name = "progLbl";
            progLbl.Size = new System.Drawing.Size(127, 36);
            progLbl.TabIndex = 0;
            progLbl.Text = "Program";
            // 
            // closeBtn
            // 
            closeBtn.BackColor = System.Drawing.Color.FromArgb(168, 172, 176);
            closeBtn.Dock = System.Windows.Forms.DockStyle.Left;
            closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            closeBtn.ForeColor = System.Drawing.Color.White;
            closeBtn.Location = new System.Drawing.Point(0, 0);
            closeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new System.Drawing.Size(41, 50);
            closeBtn.TabIndex = 1;
            closeBtn.Text = "—";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // DefaultProgramBar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(0, 0, 168);
            Controls.Add(closeBtn);
            Controls.Add(progLbl);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "DefaultProgramBar";
            Size = new System.Drawing.Size(1004, 50);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label progLbl;
        private System.Windows.Forms.Button closeBtn;
    }
}
