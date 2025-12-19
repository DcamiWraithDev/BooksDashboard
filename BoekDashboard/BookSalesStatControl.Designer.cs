namespace BoekDashboard
{
    partial class BookSalesStatControl
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
            this.priceLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.amountLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.priceLbl.ForeColor = System.Drawing.Color.White;
            this.priceLbl.Location = new System.Drawing.Point(4, 56);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(61, 26);
            this.priceLbl.TabIndex = 3;
            this.priceLbl.Text = "#N/A";
            this.priceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(3, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(231, 31);
            this.titleLbl.TabIndex = 2;
            this.titleLbl.Text = "Global total books";
            this.titleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.amountLbl.ForeColor = System.Drawing.Color.White;
            this.amountLbl.Location = new System.Drawing.Point(4, 82);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(61, 26);
            this.amountLbl.TabIndex = 4;
            this.amountLbl.Text = "#N/A";
            this.amountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nameLbl.ForeColor = System.Drawing.Color.White;
            this.nameLbl.Location = new System.Drawing.Point(4, 30);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(61, 26);
            this.nameLbl.TabIndex = 5;
            this.nameLbl.Text = "#N/A";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookSalesStatControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.titleLbl);
            this.Name = "BookSalesStatControl";
            this.Size = new System.Drawing.Size(235, 108);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.Label nameLbl;
    }
}
