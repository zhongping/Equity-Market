namespace Equity.View.Quote
{
    partial class ForeignChartForm
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
            this.foreignChartButton = new System.Windows.Forms.Button();
            this.ForeignChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ForeignChartTextBox = new System.Windows.Forms.TextBox();
            this.ForeignStockLabel = new System.Windows.Forms.Label();
            this.ForeignStockNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ForeignChart)).BeginInit();
            this.SuspendLayout();
            // 
            // foreignChartButton
            // 
            this.foreignChartButton.Location = new System.Drawing.Point(132, 9);
            this.foreignChartButton.Name = "foreignChartButton";
            this.foreignChartButton.Size = new System.Drawing.Size(75, 23);
            this.foreignChartButton.TabIndex = 0;
            this.foreignChartButton.Text = "Search";
            this.foreignChartButton.UseVisualStyleBackColor = true;
            this.foreignChartButton.Click += new System.EventHandler(this.foreignChartButton_Click);
            // 
            // ForeignChart
            // 
            this.ForeignChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.ForeignChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ForeignChart.Legends.Add(legend1);
            this.ForeignChart.Location = new System.Drawing.Point(12, 41);
            this.ForeignChart.Name = "ForeignChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "Foreign Net Buy";
            this.ForeignChart.Series.Add(series1);
            this.ForeignChart.Size = new System.Drawing.Size(798, 401);
            this.ForeignChart.TabIndex = 1;
            // 
            // ForeignChartTextBox
            // 
            this.ForeignChartTextBox.Location = new System.Drawing.Point(13, 12);
            this.ForeignChartTextBox.Name = "ForeignChartTextBox";
            this.ForeignChartTextBox.Size = new System.Drawing.Size(113, 20);
            this.ForeignChartTextBox.TabIndex = 2;
            // 
            // ForeignStockLabel
            // 
            this.ForeignStockLabel.AutoSize = true;
            this.ForeignStockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeignStockLabel.Location = new System.Drawing.Point(223, -1);
            this.ForeignStockLabel.Name = "ForeignStockLabel";
            this.ForeignStockLabel.Size = new System.Drawing.Size(77, 33);
            this.ForeignStockLabel.TabIndex = 3;
            this.ForeignStockLabel.Text = "label";
            // 
            // ForeignStockNameLabel
            // 
            this.ForeignStockNameLabel.AutoSize = true;
            this.ForeignStockNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeignStockNameLabel.Location = new System.Drawing.Point(306, -1);
            this.ForeignStockNameLabel.Name = "ForeignStockNameLabel";
            this.ForeignStockNameLabel.Size = new System.Drawing.Size(77, 33);
            this.ForeignStockNameLabel.TabIndex = 4;
            this.ForeignStockNameLabel.Text = "label";
            // 
            // ForeignChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 454);
            this.Controls.Add(this.ForeignStockNameLabel);
            this.Controls.Add(this.ForeignStockLabel);
            this.Controls.Add(this.ForeignChartTextBox);
            this.Controls.Add(this.ForeignChart);
            this.Controls.Add(this.foreignChartButton);
            this.Name = "ForeignChartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ForeignChartForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ForeignChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ForeignChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button foreignChartButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart ForeignChart;
        private System.Windows.Forms.TextBox ForeignChartTextBox;
        private System.Windows.Forms.Label ForeignStockLabel;
        private System.Windows.Forms.Label ForeignStockNameLabel;
    }
}