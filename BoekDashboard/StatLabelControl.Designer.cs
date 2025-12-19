namespace BoekDashboard
{
    partial class StatLabelControl
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.valueLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(1, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(231, 31);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Global total books";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueLbl
            // 
            this.valueLbl.AutoSize = true;
            this.valueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.valueLbl.ForeColor = System.Drawing.Color.White;
            this.valueLbl.Location = new System.Drawing.Point(3, 31);
            this.valueLbl.Name = "valueLbl";
            this.valueLbl.Size = new System.Drawing.Size(147, 63);
            this.valueLbl.TabIndex = 1;
            this.valueLbl.Text = "#N/A";
            this.valueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatLabelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.Controls.Add(this.valueLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "StatLabelControl";
            this.Size = new System.Drawing.Size(235, 108);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label valueLbl;
    }
}
