namespace Equity.View
{
    partial class StockChartForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.HoldingChartLabel = new System.Windows.Forms.Label();
            this.StockChartLabel = new System.Windows.Forms.Label();
            this.StockLabel = new System.Windows.Forms.Label();
            this.StockChartTextBox = new System.Windows.Forms.TextBox();
            this.StockSearchButton = new System.Windows.Forms.Button();
            this.StockHoldingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StockChartMonthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StockChartGroupBox = new System.Windows.Forms.GroupBox();
            this.StockChartTitleGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.StockHoldingChart)).BeginInit();
            this.StockChartGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HoldingChartLabel
            // 
            this.HoldingChartLabel.AutoSize = true;
            this.HoldingChartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoldingChartLabel.Location = new System.Drawing.Point(484, 48);
            this.HoldingChartLabel.Name = "HoldingChartLabel";
            this.HoldingChartLabel.Size = new System.Drawing.Size(193, 33);
            this.HoldingChartLabel.TabIndex = 0;
            this.HoldingChartLabel.Text = "Holding Chart";
            // 
            // StockChartLabel
            // 
            this.StockChartLabel.AutoSize = true;
            this.StockChartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockChartLabel.Location = new System.Drawing.Point(540, 12);
            this.StockChartLabel.Name = "StockChartLabel";
            this.StockChartLabel.Size = new System.Drawing.Size(88, 33);
            this.StockChartLabel.TabIndex = 1;
            this.StockChartLabel.Text = "Stock";
            // 
            // StockLabel
            // 
            this.StockLabel.AutoSize = true;
            this.StockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockLabel.Location = new System.Drawing.Point(490, 96);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(50, 20);
            this.StockLabel.TabIndex = 2;
            this.StockLabel.Text = "Stock";
            // 
            // StockChartTextBox
            // 
            this.StockChartTextBox.Location = new System.Drawing.Point(597, 98);
            this.StockChartTextBox.Name = "StockChartTextBox";
            this.StockChartTextBox.Size = new System.Drawing.Size(80, 20);
            this.StockChartTextBox.TabIndex = 3;
            // 
            // StockSearchButton
            // 
            this.StockSearchButton.Location = new System.Drawing.Point(597, 161);
            this.StockSearchButton.Name = "StockSearchButton";
            this.StockSearchButton.Size = new System.Drawing.Size(80, 20);
            this.StockSearchButton.TabIndex = 4;
            this.StockSearchButton.Text = "Search";
            this.StockSearchButton.UseVisualStyleBackColor = true;
            this.StockSearchButton.Click += new System.EventHandler(this.StockSearchButton_Click);
            // 
            // StockHoldingChart
            // 
            this.StockHoldingChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.StockHoldingChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.StockHoldingChart.Legends.Add(legend1);
            this.StockHoldingChart.Location = new System.Drawing.Point(6, 19);
            this.StockHoldingChart.Name = "StockHoldingChart";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Domestic Holding";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Lime;
            series2.Legend = "Legend1";
            series2.Name = "Foreign Holding";
            this.StockHoldingChart.Series.Add(series1);
            this.StockHoldingChart.Series.Add(series2);
            this.StockHoldingChart.Size = new System.Drawing.Size(445, 307);
            this.StockHoldingChart.TabIndex = 5;
            this.StockHoldingChart.Text = "Stock Chart";
            // 
            // StockChartMonthDateTimePicker
            // 
            this.StockChartMonthDateTimePicker.Location = new System.Drawing.Point(490, 124);
            this.StockChartMonthDateTimePicker.Name = "StockChartMonthDateTimePicker";
            this.StockChartMonthDateTimePicker.Size = new System.Drawing.Size(187, 20);
            this.StockChartMonthDateTimePicker.TabIndex = 6;
            // 
            // StockChartGroupBox
            // 
            this.StockChartGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StockChartGroupBox.Controls.Add(this.StockChartTitleGroupBox);
            this.StockChartGroupBox.Controls.Add(this.StockHoldingChart);
            this.StockChartGroupBox.Location = new System.Drawing.Point(12, 12);
            this.StockChartGroupBox.Name = "StockChartGroupBox";
            this.StockChartGroupBox.Size = new System.Drawing.Size(466, 349);
            this.StockChartGroupBox.TabIndex = 7;
            this.StockChartGroupBox.TabStop = false;
            // 
            // StockChartTitleGroupBox
            // 
            this.StockChartTitleGroupBox.Location = new System.Drawing.Point(472, 0);
            this.StockChartTitleGroupBox.Name = "StockChartTitleGroupBox";
            this.StockChartTitleGroupBox.Size = new System.Drawing.Size(263, 349);
            this.StockChartTitleGroupBox.TabIndex = 8;
            this.StockChartTitleGroupBox.TabStop = false;
            // 
            // StockChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 367);
            this.Controls.Add(this.StockSearchButton);
            this.Controls.Add(this.StockChartLabel);
            this.Controls.Add(this.StockChartMonthDateTimePicker);
            this.Controls.Add(this.HoldingChartLabel);
            this.Controls.Add(this.StockChartTextBox);
            this.Controls.Add(this.StockLabel);
            this.Controls.Add(this.StockChartGroupBox);
            this.Name = "StockChartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StockChartForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StockChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockHoldingChart)).EndInit();
            this.StockChartGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HoldingChartLabel;
        private System.Windows.Forms.Label StockChartLabel;
        private System.Windows.Forms.Label StockLabel;
        private System.Windows.Forms.TextBox StockChartTextBox;
        private System.Windows.Forms.Button StockSearchButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart StockHoldingChart;
        private System.Windows.Forms.DateTimePicker StockChartMonthDateTimePicker;
        private System.Windows.Forms.GroupBox StockChartGroupBox;
        private System.Windows.Forms.GroupBox StockChartTitleGroupBox;
    }
}