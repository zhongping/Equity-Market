namespace Equity.View.Quote.Analysis
{
    partial class DailyForeignNetBuyChartForm
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
            this.TickerComboBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ForeignDailyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ForeignDailyChart)).BeginInit();
            this.SuspendLayout();
            // 
            // TickerComboBox
            // 
            this.TickerComboBox.FormattingEnabled = true;
            this.TickerComboBox.Location = new System.Drawing.Point(13, 13);
            this.TickerComboBox.Name = "TickerComboBox";
            this.TickerComboBox.Size = new System.Drawing.Size(121, 21);
            this.TickerComboBox.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(155, 13);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ForeignDailyChart
            // 
            this.ForeignDailyChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ForeignChartArea";
            this.ForeignDailyChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ForeignDailyChart.Legends.Add(legend1);
            this.ForeignDailyChart.Location = new System.Drawing.Point(12, 42);
            this.ForeignDailyChart.Name = "ForeignDailyChart";
            series1.ChartArea = "ForeignChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.Legend = "Legend1";
            series1.Name = "Daily Quote";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "ForeignChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Black;
            series2.Legend = "Legend1";
            series2.Name = "Foreign Net Buy";
            this.ForeignDailyChart.Series.Add(series1);
            this.ForeignDailyChart.Series.Add(series2);
            this.ForeignDailyChart.Size = new System.Drawing.Size(566, 361);
            this.ForeignDailyChart.TabIndex = 2;
            // 
            // DailyForeignNetBuyChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 415);
            this.Controls.Add(this.ForeignDailyChart);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.TickerComboBox);
            this.Name = "DailyForeignNetBuyChartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DailyForeignNetBuyChartForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DailyForeignNetBuyChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ForeignDailyChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox TickerComboBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart ForeignDailyChart;
    }
}