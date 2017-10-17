namespace Equity.View
{
    partial class StockChartTotalForm
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
            this.ToTotalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToTotalLabel = new System.Windows.Forms.Label();
            this.FromTotalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromTotalLabel = new System.Windows.Forms.Label();
            this.StockSearchButton = new System.Windows.Forms.Button();
            this.StockSearchedTextBox = new System.Windows.Forms.TextBox();
            this.StockSearchedLabel = new System.Windows.Forms.Label();
            this.StockChartGroupBox = new System.Windows.Forms.GroupBox();
            this.StockTotalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StockTitleGroupBox.SuspendLayout();
            this.StockChartGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockTotalChart)).BeginInit();
            this.SuspendLayout();
            // 
            // StockTitleGroupBox
            // 
            this.StockTitleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StockTitleGroupBox.Controls.Add(this.ToTotalDateTimePicker);
            this.StockTitleGroupBox.Controls.Add(this.ToTotalLabel);
            this.StockTitleGroupBox.Controls.Add(this.FromTotalDateTimePicker);
            this.StockTitleGroupBox.Controls.Add(this.FromTotalLabel);
            this.StockTitleGroupBox.Controls.Add(this.StockSearchButton);
            this.StockTitleGroupBox.Controls.Add(this.StockSearchedTextBox);
            this.StockTitleGroupBox.Controls.Add(this.StockSearchedLabel);
            this.StockTitleGroupBox.Location = new System.Drawing.Point(12, 1);
            this.StockTitleGroupBox.Name = "StockTitleGroupBox";
            this.StockTitleGroupBox.Size = new System.Drawing.Size(761, 61);
            this.StockTitleGroupBox.TabIndex = 0;
            this.StockTitleGroupBox.TabStop = false;
            // 
            // ToTotalDateTimePicker
            // 
            this.ToTotalDateTimePicker.Location = new System.Drawing.Point(541, 21);
            this.ToTotalDateTimePicker.Name = "ToTotalDateTimePicker";
            this.ToTotalDateTimePicker.Size = new System.Drawing.Size(144, 20);
            this.ToTotalDateTimePicker.TabIndex = 6;
            // 
            // ToTotalLabel
            // 
            this.ToTotalLabel.AutoSize = true;
            this.ToTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToTotalLabel.Location = new System.Drawing.Point(498, 20);
            this.ToTotalLabel.Name = "ToTotalLabel";
            this.ToTotalLabel.Size = new System.Drawing.Size(37, 25);
            this.ToTotalLabel.TabIndex = 5;
            this.ToTotalLabel.Text = "To";
            // 
            // FromTotalDateTimePicker
            // 
            this.FromTotalDateTimePicker.Location = new System.Drawing.Point(367, 21);
            this.FromTotalDateTimePicker.Name = "FromTotalDateTimePicker";
            this.FromTotalDateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.FromTotalDateTimePicker.TabIndex = 4;
            // 
            // FromTotalLabel
            // 
            this.FromTotalLabel.AutoSize = true;
            this.FromTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromTotalLabel.Location = new System.Drawing.Point(300, 18);
            this.FromTotalLabel.Name = "FromTotalLabel";
            this.FromTotalLabel.Size = new System.Drawing.Size(61, 25);
            this.FromTotalLabel.TabIndex = 3;
            this.FromTotalLabel.Text = "From";
            // 
            // StockSearchButton
            // 
            this.StockSearchButton.Location = new System.Drawing.Point(206, 21);
            this.StockSearchButton.Name = "StockSearchButton";
            this.StockSearchButton.Size = new System.Drawing.Size(75, 20);
            this.StockSearchButton.TabIndex = 2;
            this.StockSearchButton.Text = "Search";
            this.StockSearchButton.UseVisualStyleBackColor = true;
            this.StockSearchButton.Click += new System.EventHandler(this.StockSearchButton_Click);
            // 
            // StockSearchedTextBox
            // 
            this.StockSearchedTextBox.Location = new System.Drawing.Point(89, 21);
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
            // StockChartGroupBox
            // 
            this.StockChartGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StockChartGroupBox.Controls.Add(this.StockTotalChart);
            this.StockChartGroupBox.Location = new System.Drawing.Point(11, 68);
            this.StockChartGroupBox.Name = "StockChartGroupBox";
            this.StockChartGroupBox.Size = new System.Drawing.Size(762, 360);
            this.StockChartGroupBox.TabIndex = 1;
            this.StockChartGroupBox.TabStop = false;
            // 
            // StockTotalChart
            // 
            this.StockTotalChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.StockTotalChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.StockTotalChart.Legends.Add(legend1);
            this.StockTotalChart.Location = new System.Drawing.Point(6, 10);
            this.StockTotalChart.Name = "StockTotalChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Domestic Total";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Foreign Total";
            this.StockTotalChart.Series.Add(series1);
            this.StockTotalChart.Series.Add(series2);
            this.StockTotalChart.Size = new System.Drawing.Size(750, 344);
            this.StockTotalChart.TabIndex = 0;
            // 
            // StockChartTotalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 435);
            this.Controls.Add(this.StockChartGroupBox);
            this.Controls.Add(this.StockTitleGroupBox);
            this.Name = "StockChartTotalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StockChartTotalForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StockChartTotalForm_Load);
            this.StockTitleGroupBox.ResumeLayout(false);
            this.StockTitleGroupBox.PerformLayout();
            this.StockChartGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StockTotalChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox StockTitleGroupBox;
        private System.Windows.Forms.GroupBox StockChartGroupBox;
        private System.Windows.Forms.TextBox StockSearchedTextBox;
        private System.Windows.Forms.Label StockSearchedLabel;
        private System.Windows.Forms.Button StockSearchButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart StockTotalChart;
        private System.Windows.Forms.DateTimePicker ToTotalDateTimePicker;
        private System.Windows.Forms.Label ToTotalLabel;
        private System.Windows.Forms.DateTimePicker FromTotalDateTimePicker;
        private System.Windows.Forms.Label FromTotalLabel;
    }
}