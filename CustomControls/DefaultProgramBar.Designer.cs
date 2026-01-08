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
            this.progLbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // progLbl
            // 
            progLbl.AutoSize = true;
            progLbl.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            progLbl.ForeColor = System.Drawing.Color.White;
            progLbl.Location = new System.Drawing.Point(355, 2);
            progLbl.Name = "progLbl";
            progLbl.Size = new System.Drawing.Size(127, 36);
            progLbl.TabIndex = 0;
            progLbl.Text = "Program";
            // 
            // closeBtn
            // 
            closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(172)))), ((int)(((byte)(176)))));
            closeBtn.Dock = System.Windows.Forms.DockStyle.Left;
            closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            closeBtn.ForeColor = System.Drawing.Color.White;
            closeBtn.Location = new System.Drawing.Point(0, 0);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new System.Drawing.Size(37, 40);
            closeBtn.TabIndex = 1;
            closeBtn.Text = "—";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Normal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(168)))));
            Controls.Add(this.closeBtn);
            Controls.Add(this.progLbl);
            this.Name = "Normal";
            this.Size = new System.Drawing.Size(904, 40);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label progLbl;
        private System.Windows.Forms.Button closeBtn;
    }
}
