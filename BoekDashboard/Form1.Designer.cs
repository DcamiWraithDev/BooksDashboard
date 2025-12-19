namespace BoekDashboard
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AuthorCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pagesMaxAverageCtrl = new BoekDashboard.StatLabelControl();
            this.pagesMinAverageCtrl = new BoekDashboard.StatLabelControl();
            this.priceAverageCtrl = new BoekDashboard.StatLabelControl();
            this.totalBooksCtrl = new BoekDashboard.StatLabelControl();
            this.mostSoldBookCtrl = new BoekDashboard.BookSalesStatControl();
            this.leastSoldBookCtrl = new BoekDashboard.BookSalesStatControl();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.PointDepth = 50;
            chartArea1.Area3DStyle.PointGapDepth = 50;
            chartArea1.Area3DStyle.Rotation = 15;
            chartArea1.Area3DStyle.WallWidth = 4;
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.BlanchedAlmond;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Navy;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            legend1.Title = "Books per year";
            legend1.TitleForeColor = System.Drawing.Color.White;
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(256, 126);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.MarkerBorderWidth = 2;
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.MarkerSize = 10;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Books";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1196, 312);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chartTest";
            // 
            // AuthorCB
            // 
            this.AuthorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AuthorCB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AuthorCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.AuthorCB.FormattingEnabled = true;
            this.AuthorCB.Location = new System.Drawing.Point(15, 151);
            this.AuthorCB.Name = "AuthorCB";
            this.AuthorCB.Size = new System.Drawing.Size(235, 33);
            this.AuthorCB.TabIndex = 5;
            this.AuthorCB.SelectedIndexChanged += new System.EventHandler(this.AuthorCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Filter by authors:";
            // 
            // pagesMaxAverageCtrl
            // 
            this.pagesMaxAverageCtrl.BackColor = System.Drawing.Color.Navy;
            this.pagesMaxAverageCtrl.Location = new System.Drawing.Point(738, 12);
            this.pagesMaxAverageCtrl.Name = "pagesMaxAverageCtrl";
            this.pagesMaxAverageCtrl.Size = new System.Drawing.Size(235, 108);
            this.pagesMaxAverageCtrl.TabIndex = 9;
            // 
            // pagesMinAverageCtrl
            // 
            this.pagesMinAverageCtrl.BackColor = System.Drawing.Color.Navy;
            this.pagesMinAverageCtrl.Location = new System.Drawing.Point(497, 12);
            this.pagesMinAverageCtrl.Name = "pagesMinAverageCtrl";
            this.pagesMinAverageCtrl.Size = new System.Drawing.Size(235, 108);
            this.pagesMinAverageCtrl.TabIndex = 8;
            // 
            // priceAverageCtrl
            // 
            this.priceAverageCtrl.BackColor = System.Drawing.Color.Navy;
            this.priceAverageCtrl.Location = new System.Drawing.Point(256, 12);
            this.priceAverageCtrl.Name = "priceAverageCtrl";
            this.priceAverageCtrl.Size = new System.Drawing.Size(235, 108);
            this.priceAverageCtrl.TabIndex = 7;
            // 
            // totalBooksCtrl
            // 
            this.totalBooksCtrl.BackColor = System.Drawing.Color.Navy;
            this.totalBooksCtrl.Location = new System.Drawing.Point(15, 12);
            this.totalBooksCtrl.Name = "totalBooksCtrl";
            this.totalBooksCtrl.Size = new System.Drawing.Size(235, 108);
            this.totalBooksCtrl.TabIndex = 6;
            // 
            // mostSoldBookCtrl
            // 
            this.mostSoldBookCtrl.BackColor = System.Drawing.Color.Navy;
            this.mostSoldBookCtrl.Location = new System.Drawing.Point(979, 12);
            this.mostSoldBookCtrl.Name = "mostSoldBookCtrl";
            this.mostSoldBookCtrl.Size = new System.Drawing.Size(235, 108);
            this.mostSoldBookCtrl.TabIndex = 13;
            // 
            // leastSoldBookCtrl
            // 
            this.leastSoldBookCtrl.BackColor = System.Drawing.Color.Navy;
            this.leastSoldBookCtrl.Location = new System.Drawing.Point(1220, 12);
            this.leastSoldBookCtrl.Name = "leastSoldBookCtrl";
            this.leastSoldBookCtrl.Size = new System.Drawing.Size(235, 108);
            this.leastSoldBookCtrl.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1464, 450);
            this.Controls.Add(this.leastSoldBookCtrl);
            this.Controls.Add(this.mostSoldBookCtrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pagesMaxAverageCtrl);
            this.Controls.Add(this.pagesMinAverageCtrl);
            this.Controls.Add(this.priceAverageCtrl);
            this.Controls.Add(this.totalBooksCtrl);
            this.Controls.Add(this.AuthorCB);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Book sales dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox AuthorCB;
        private StatLabelControl totalBooksCtrl;
        private StatLabelControl priceAverageCtrl;
        private StatLabelControl pagesMinAverageCtrl;
        private StatLabelControl pagesMaxAverageCtrl;
        private System.Windows.Forms.Label label1;
        private BookSalesStatControl mostSoldBookCtrl;
        private BookSalesStatControl leastSoldBookCtrl;
    }
}

