namespace Equity.View.Holding
{
    partial class DomesticIndividualForm
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
            this.StockTitleGroupBox = new System.Windows.Forms.GroupBox();
            this.StockSearchButton = new System.Windows.Forms.Button();
            this.StockSearchedTextBox = new System.Windows.Forms.TextBox();
            this.StockSearchedLabel = new System.Windows.Forms.Label();
            this.DomesticIndividualChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StockTitleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DomesticIndividualChart)).BeginInit();
            this.SuspendLayout();
            // 
            // StockTitleGroupBox
            // 
            this.StockTitleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StockTitleGroupBox.Controls.Add(this.StockSearchButton);
            this.StockTitleGroupBox.Controls.Add(this.StockSearchedTextBox);
            this.StockTitleGroupBox.Controls.Add(this.StockSearchedLabel);
            this.StockTitleGroupBox.Location = new System.Drawing.Point(12, 2);
            this.StockTitleGroupBox.Name = "StockTitleGroupBox";
            this.StockTitleGroupBox.Size = new System.Drawing.Size(704, 53);
            this.StockTitleGroupBox.TabIndex = 1;
            this.StockTitleGroupBox.TabStop = false;
            // 
            // StockSearchButton
            // 
            this.StockSearchButton.Location = new System.Drawing.Point(197, 21);
            this.StockSearchButton.Name = "StockSearchButton";
            this.StockSearchButton.Size = new System.Drawing.Size(75, 20);
            this.StockSearchButton.TabIndex = 2;
            this.StockSearchButton.Text = "Search";
            this.StockSearchButton.UseVisualStyleBackColor = true;
            this.StockSearchButton.Click += new System.EventHandler(this.StockSearchButton_Click);
            // 
            // StockSearchedTextBox
            // 
            this.StockSearchedTextBox.Location = new System.Drawing.Point(78, 19);
            this.StockSearchedTextBox.Name = "StockSearchedTextBox";
            this.StockSearchedTextBox.Size = new System.Drawing.Size(100, 20);
            this.StockSearchedTextBox.TabIndex = 1;
            // 
            // StockSearchedLabel
            // 
            this.StockSearchedLabel.AutoSize = true;
            this.StockSearchedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockSearchedLabel.Location = new System.Drawing.Point(6, 16);
            this.StockSearchedLabel.Name = "StockSearchedLabel";
            this.StockSearchedLabel.Size = new System.Drawing.Size(66, 25);
            this.StockSearchedLabel.TabIndex = 0;
            this.StockSearchedLabel.Text = "Stock";
            // 
            // DomesticIndividualChart
            // 
            this.DomesticIndividualChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.DomesticIndividualChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.DomesticIndividualChart.Legends.Add(legend1);
            this.DomesticIndividualChart.Location = new System.Drawing.Point(12, 61);
            this.DomesticIndividualChart.Name = "DomesticIndividualChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Domestic Individual";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Foreign Total";
            this.DomesticIndividualChart.Series.Add(series1);
            this.DomesticIndividualChart.Series.Add(series2);
            this.DomesticIndividualChart.Size = new System.Drawing.Size(703, 387);
            this.DomesticIndividualChart.TabIndex = 2;
            // 
            // DomesticIndividualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 460);
            this.Controls.Add(this.DomesticIndividualChart);
            this.Controls.Add(this.StockTitleGroupBox);
            this.Name = "DomesticIndividualForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DomesticIndividualForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DomesticIndividualForm_Load);
            this.StockTitleGroupBox.ResumeLayout(false);
            this.StockTitleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DomesticIndividualChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox StockTitleGroupBox;
        private System.Windows.Forms.Button StockSearchButton;
        private System.Windows.Forms.TextBox StockSearchedTextBox;
        private System.Windows.Forms.Label StockSearchedLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart DomesticIndividualChart;
    }
}