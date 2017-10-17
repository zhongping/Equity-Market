namespace Equity.View
{
    partial class StockChartTimeBasedForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.StockLabelGroupBox = new System.Windows.Forms.GroupBox();
            this.StockSearchButton = new System.Windows.Forms.Button();
            this.StockTextBox = new System.Windows.Forms.TextBox();
            this.StockLabel = new System.Windows.Forms.Label();
            this.StockChartGroupBox = new System.Windows.Forms.GroupBox();
            this.StockChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.StockLabelGroupBox.SuspendLayout();
            this.StockChartGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StockChart)).BeginInit();
            this.SuspendLayout();
            // 
            // StockLabelGroupBox
            // 
            this.StockLabelGroupBox.Controls.Add(this.ToLabel);
            this.StockLabelGroupBox.Controls.Add(this.FromLabel);
            this.StockLabelGroupBox.Controls.Add(this.ToDateTimePicker);
            this.StockLabelGroupBox.Controls.Add(this.FromDateTimePicker);
            this.StockLabelGroupBox.Controls.Add(this.StockSearchButton);
            this.StockLabelGroupBox.Controls.Add(this.StockTextBox);
            this.StockLabelGroupBox.Controls.Add(this.StockLabel);
            this.StockLabelGroupBox.Location = new System.Drawing.Point(13, 2);
            this.StockLabelGroupBox.Name = "StockLabelGroupBox";
            this.StockLabelGroupBox.Size = new System.Drawing.Size(645, 45);
            this.StockLabelGroupBox.TabIndex = 0;
            this.StockLabelGroupBox.TabStop = false;
            // 
            // StockSearchButton
            // 
            this.StockSearchButton.Location = new System.Drawing.Point(178, 17);
            this.StockSearchButton.Name = "StockSearchButton";
            this.StockSearchButton.Size = new System.Drawing.Size(75, 20);
            this.StockSearchButton.TabIndex = 2;
            this.StockSearchButton.Text = "Search";
            this.StockSearchButton.UseVisualStyleBackColor = true;
            this.StockSearchButton.Click += new System.EventHandler(this.StockSearchButton_Click);
            // 
            // StockTextBox
            // 
            this.StockTextBox.Location = new System.Drawing.Point(63, 17);
            this.StockTextBox.MaxLength = 4;
            this.StockTextBox.Name = "StockTextBox";
            this.StockTextBox.Size = new System.Drawing.Size(100, 20);
            this.StockTextBox.TabIndex = 1;
            // 
            // StockLabel
            // 
            this.StockLabel.AutoSize = true;
            this.StockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockLabel.Location = new System.Drawing.Point(7, 20);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(42, 16);
            this.StockLabel.TabIndex = 0;
            this.StockLabel.Text = "Stock";
            // 
            // StockChartGroupBox
            // 
            this.StockChartGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StockChartGroupBox.Controls.Add(this.StockChart);
            this.StockChartGroupBox.Location = new System.Drawing.Point(13, 54);
            this.StockChartGroupBox.Name = "StockChartGroupBox";
            this.StockChartGroupBox.Size = new System.Drawing.Size(645, 309);
            this.StockChartGroupBox.TabIndex = 1;
            this.StockChartGroupBox.TabStop = false;
            // 
            // StockChart
            // 
            this.StockChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.StockChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.StockChart.Legends.Add(legend1);
            this.StockChart.Location = new System.Drawing.Point(6, 9);
            this.StockChart.Name = "StockChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Domestic Insurance";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            series2.Legend = "Legend1";
            series2.Name = "Domestic Company";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series3.Legend = "Legend1";
            series3.Name = "Domestic Pension Fund";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Yellow;
            series4.Legend = "Legend1";
            series4.Name = "Domestic Bank";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Lime;
            series5.Legend = "Legend1";
            series5.Name = "Domestic Individual";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            series6.Legend = "Legend1";
            series6.Name = "Domestic Mutual Fund";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.DarkTurquoise;
            series7.Legend = "Legend1";
            series7.Name = "Domestic Security";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.DarkBlue;
            series8.Legend = "Legend1";
            series8.Name = "Domestic Foundation";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.GreenYellow;
            series9.Legend = "Legend1";
            series9.Name = "Domestic Others";
            series10.ChartArea = "ChartArea1";
            series10.Color = System.Drawing.Color.Red;
            series10.Legend = "Legend1";
            series10.Name = "Foreign Insurance";
            series11.ChartArea = "ChartArea1";
            series11.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            series11.Legend = "Legend1";
            series11.Name = "Foreign Company";
            series12.ChartArea = "ChartArea1";
            series12.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series12.Legend = "Legend1";
            series12.Name = "Foreign Pension Fund";
            series13.ChartArea = "ChartArea1";
            series13.Color = System.Drawing.Color.Yellow;
            series13.Legend = "Legend1";
            series13.Name = "Foreign Bank";
            series14.ChartArea = "ChartArea1";
            series14.Color = System.Drawing.Color.Lime;
            series14.Legend = "Legend1";
            series14.Name = "Foreign Individual";
            series15.ChartArea = "ChartArea1";
            series15.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            series15.Legend = "Legend1";
            series15.Name = "Foreign Mutual Fund";
            series16.ChartArea = "ChartArea1";
            series16.Color = System.Drawing.Color.DarkTurquoise;
            series16.Legend = "Legend1";
            series16.Name = "Foreign Security";
            series17.ChartArea = "ChartArea1";
            series17.Color = System.Drawing.Color.DarkBlue;
            series17.Legend = "Legend1";
            series17.Name = "Foreign Foundation";
            series18.ChartArea = "ChartArea1";
            series18.Color = System.Drawing.Color.GreenYellow;
            series18.Legend = "Legend1";
            series18.Name = "Foreign Others";
            this.StockChart.Series.Add(series1);
            this.StockChart.Series.Add(series2);
            this.StockChart.Series.Add(series3);
            this.StockChart.Series.Add(series4);
            this.StockChart.Series.Add(series5);
            this.StockChart.Series.Add(series6);
            this.StockChart.Series.Add(series7);
            this.StockChart.Series.Add(series8);
            this.StockChart.Series.Add(series9);
            this.StockChart.Series.Add(series10);
            this.StockChart.Series.Add(series11);
            this.StockChart.Series.Add(series12);
            this.StockChart.Series.Add(series13);
            this.StockChart.Series.Add(series14);
            this.StockChart.Series.Add(series15);
            this.StockChart.Series.Add(series16);
            this.StockChart.Series.Add(series17);
            this.StockChart.Series.Add(series18);
            this.StockChart.Size = new System.Drawing.Size(633, 279);
            this.StockChart.TabIndex = 0;
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.Location = new System.Drawing.Point(338, 16);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.Size = new System.Drawing.Size(109, 20);
            this.FromDateTimePicker.TabIndex = 3;
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.Location = new System.Drawing.Point(525, 17);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.Size = new System.Drawing.Size(114, 20);
            this.ToDateTimePicker.TabIndex = 4;
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLabel.Location = new System.Drawing.Point(286, 16);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(46, 20);
            this.FromLabel.TabIndex = 5;
            this.FromLabel.Text = "From";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.Location = new System.Drawing.Point(474, 17);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(27, 20);
            this.ToLabel.TabIndex = 6;
            this.ToLabel.Text = "To";
            // 
            // StockChartTimeBasedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 354);
            this.Controls.Add(this.StockChartGroupBox);
            this.Controls.Add(this.StockLabelGroupBox);
            this.Name = "StockChartTimeBasedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StockChartTimeBasedForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StockChartTimeBasedForm_Load);
            this.StockLabelGroupBox.ResumeLayout(false);
            this.StockLabelGroupBox.PerformLayout();
            this.StockChartGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StockChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox StockLabelGroupBox;
        private System.Windows.Forms.Button StockSearchButton;
        private System.Windows.Forms.TextBox StockTextBox;
        private System.Windows.Forms.Label StockLabel;
        private System.Windows.Forms.GroupBox StockChartGroupBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart StockChart;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label FromLabel;
    }
}