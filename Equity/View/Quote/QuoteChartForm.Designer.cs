namespace Equity.View.Quote
{
    partial class QuoteChartForm
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
            this.QuoteChartTextBox = new System.Windows.Forms.TextBox();
            this.QuoteChartButton = new System.Windows.Forms.Button();
            this.QuoteChartLabel = new System.Windows.Forms.Label();
            this.QuoteNameLabel = new System.Windows.Forms.Label();
            this.QuoteChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.QuoteChart)).BeginInit();
            this.SuspendLayout();
            // 
            // QuoteChartTextBox
            // 
            this.QuoteChartTextBox.Location = new System.Drawing.Point(12, 12);
            this.QuoteChartTextBox.Name = "QuoteChartTextBox";
            this.QuoteChartTextBox.Size = new System.Drawing.Size(100, 20);
            this.QuoteChartTextBox.TabIndex = 0;
            // 
            // QuoteChartButton
            // 
            this.QuoteChartButton.Location = new System.Drawing.Point(119, 12);
            this.QuoteChartButton.Name = "QuoteChartButton";
            this.QuoteChartButton.Size = new System.Drawing.Size(75, 20);
            this.QuoteChartButton.TabIndex = 1;
            this.QuoteChartButton.Text = "Search";
            this.QuoteChartButton.UseVisualStyleBackColor = true;
            this.QuoteChartButton.Click += new System.EventHandler(this.QuoteChartButton_Click);
            // 
            // QuoteChartLabel
            // 
            this.QuoteChartLabel.AutoSize = true;
            this.QuoteChartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteChartLabel.Location = new System.Drawing.Point(200, 4);
            this.QuoteChartLabel.Name = "QuoteChartLabel";
            this.QuoteChartLabel.Size = new System.Drawing.Size(71, 31);
            this.QuoteChartLabel.TabIndex = 2;
            this.QuoteChartLabel.Text = "label";
            // 
            // QuoteNameLabel
            // 
            this.QuoteNameLabel.AutoSize = true;
            this.QuoteNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteNameLabel.Location = new System.Drawing.Point(277, 4);
            this.QuoteNameLabel.Name = "QuoteNameLabel";
            this.QuoteNameLabel.Size = new System.Drawing.Size(71, 31);
            this.QuoteNameLabel.TabIndex = 3;
            this.QuoteNameLabel.Text = "label";
            // 
            // QuoteChart
            // 
            this.QuoteChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.QuoteChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.QuoteChart.Legends.Add(legend1);
            this.QuoteChart.Location = new System.Drawing.Point(12, 38);
            this.QuoteChart.Name = "QuoteChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.Legend = "Legend1";
            series1.Name = "Daily Quote";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Volume";
            this.QuoteChart.Series.Add(series1);
            this.QuoteChart.Series.Add(series2);
            this.QuoteChart.Size = new System.Drawing.Size(862, 392);
            this.QuoteChart.TabIndex = 4;
            // 
            // QuoteChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 442);
            this.Controls.Add(this.QuoteChart);
            this.Controls.Add(this.QuoteNameLabel);
            this.Controls.Add(this.QuoteChartLabel);
            this.Controls.Add(this.QuoteChartButton);
            this.Controls.Add(this.QuoteChartTextBox);
            this.Name = "QuoteChartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QuoteChartForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuoteChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuoteChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QuoteChartTextBox;
        private System.Windows.Forms.Button QuoteChartButton;
        private System.Windows.Forms.Label QuoteChartLabel;
        private System.Windows.Forms.Label QuoteNameLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart QuoteChart;
    }
}