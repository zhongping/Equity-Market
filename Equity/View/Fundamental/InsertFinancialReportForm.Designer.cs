namespace Equity.View.Fundamental
{
    partial class InsertFinancialReportForm
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
            this.StockTickerLabel = new System.Windows.Forms.Label();
            this.FinancialDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StockDateLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TickerComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.CashFlowTextBox = new System.Windows.Forms.TextBox();
            this.CashFlowLabel = new System.Windows.Forms.Label();
            this.NetIncomeTextBox = new System.Windows.Forms.TextBox();
            this.NetIncomeLabel = new System.Windows.Forms.Label();
            this.GrossProfitTextBox = new System.Windows.Forms.TextBox();
            this.GrossProfitLabel = new System.Windows.Forms.Label();
            this.EquityTextBox = new System.Windows.Forms.TextBox();
            this.EquityLabel = new System.Windows.Forms.Label();
            this.SalesTextBox = new System.Windows.Forms.TextBox();
            this.SalesLabel = new System.Windows.Forms.Label();
            this.LiabilitiesTextBox = new System.Windows.Forms.TextBox();
            this.LiabilitiesLabel = new System.Windows.Forms.Label();
            this.AssetTextBox = new System.Windows.Forms.TextBox();
            this.AssetLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StockTickerLabel
            // 
            this.StockTickerLabel.AutoSize = true;
            this.StockTickerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockTickerLabel.Location = new System.Drawing.Point(7, 15);
            this.StockTickerLabel.Name = "StockTickerLabel";
            this.StockTickerLabel.Size = new System.Drawing.Size(71, 25);
            this.StockTickerLabel.TabIndex = 1;
            this.StockTickerLabel.Text = "Ticker";
            // 
            // FinancialDateTimePicker
            // 
            this.FinancialDateTimePicker.Location = new System.Drawing.Point(363, 18);
            this.FinancialDateTimePicker.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.FinancialDateTimePicker.Name = "FinancialDateTimePicker";
            this.FinancialDateTimePicker.Size = new System.Drawing.Size(133, 20);
            this.FinancialDateTimePicker.TabIndex = 2;
            // 
            // StockDateLabel
            // 
            this.StockDateLabel.AutoSize = true;
            this.StockDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockDateLabel.Location = new System.Drawing.Point(210, 13);
            this.StockDateLabel.Name = "StockDateLabel";
            this.StockDateLabel.Size = new System.Drawing.Size(127, 25);
            this.StockDateLabel.TabIndex = 3;
            this.StockDateLabel.Text = "Report Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TickerComboBox);
            this.groupBox1.Controls.Add(this.FinancialDateTimePicker);
            this.groupBox1.Controls.Add(this.StockDateLabel);
            this.groupBox1.Controls.Add(this.StockTickerLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 52);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // TickerComboBox
            // 
            this.TickerComboBox.FormattingEnabled = true;
            this.TickerComboBox.Location = new System.Drawing.Point(83, 17);
            this.TickerComboBox.Name = "TickerComboBox";
            this.TickerComboBox.Size = new System.Drawing.Size(121, 21);
            this.TickerComboBox.TabIndex = 4;
            this.TickerComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TickerComboBox_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.InsertButton);
            this.groupBox2.Controls.Add(this.CashFlowTextBox);
            this.groupBox2.Controls.Add(this.CashFlowLabel);
            this.groupBox2.Controls.Add(this.NetIncomeTextBox);
            this.groupBox2.Controls.Add(this.NetIncomeLabel);
            this.groupBox2.Controls.Add(this.GrossProfitTextBox);
            this.groupBox2.Controls.Add(this.GrossProfitLabel);
            this.groupBox2.Controls.Add(this.EquityTextBox);
            this.groupBox2.Controls.Add(this.EquityLabel);
            this.groupBox2.Controls.Add(this.SalesTextBox);
            this.groupBox2.Controls.Add(this.SalesLabel);
            this.groupBox2.Controls.Add(this.LiabilitiesTextBox);
            this.groupBox2.Controls.Add(this.LiabilitiesLabel);
            this.groupBox2.Controls.Add(this.AssetTextBox);
            this.groupBox2.Controls.Add(this.AssetLabel);
            this.groupBox2.Location = new System.Drawing.Point(13, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(767, 396);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // InsertButton
            // 
            this.InsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertButton.Location = new System.Drawing.Point(121, 178);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(181, 30);
            this.InsertButton.TabIndex = 14;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // CashFlowTextBox
            // 
            this.CashFlowTextBox.Location = new System.Drawing.Point(492, 87);
            this.CashFlowTextBox.Name = "CashFlowTextBox";
            this.CashFlowTextBox.Size = new System.Drawing.Size(181, 20);
            this.CashFlowTextBox.TabIndex = 13;
            // 
            // CashFlowLabel
            // 
            this.CashFlowLabel.AutoSize = true;
            this.CashFlowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashFlowLabel.Location = new System.Drawing.Point(345, 87);
            this.CashFlowLabel.Name = "CashFlowLabel";
            this.CashFlowLabel.Size = new System.Drawing.Size(113, 25);
            this.CashFlowLabel.TabIndex = 12;
            this.CashFlowLabel.Text = "Cash Flow";
            // 
            // NetIncomeTextBox
            // 
            this.NetIncomeTextBox.Location = new System.Drawing.Point(492, 49);
            this.NetIncomeTextBox.Name = "NetIncomeTextBox";
            this.NetIncomeTextBox.Size = new System.Drawing.Size(181, 20);
            this.NetIncomeTextBox.TabIndex = 11;
            // 
            // NetIncomeLabel
            // 
            this.NetIncomeLabel.AutoSize = true;
            this.NetIncomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetIncomeLabel.Location = new System.Drawing.Point(345, 49);
            this.NetIncomeLabel.Name = "NetIncomeLabel";
            this.NetIncomeLabel.Size = new System.Drawing.Size(120, 25);
            this.NetIncomeLabel.TabIndex = 10;
            this.NetIncomeLabel.Text = "Net Income";
            // 
            // GrossProfitTextBox
            // 
            this.GrossProfitTextBox.Location = new System.Drawing.Point(492, 16);
            this.GrossProfitTextBox.Name = "GrossProfitTextBox";
            this.GrossProfitTextBox.Size = new System.Drawing.Size(181, 20);
            this.GrossProfitTextBox.TabIndex = 9;
            // 
            // GrossProfitLabel
            // 
            this.GrossProfitLabel.AutoSize = true;
            this.GrossProfitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrossProfitLabel.Location = new System.Drawing.Point(345, 12);
            this.GrossProfitLabel.Name = "GrossProfitLabel";
            this.GrossProfitLabel.Size = new System.Drawing.Size(125, 25);
            this.GrossProfitLabel.TabIndex = 8;
            this.GrossProfitLabel.Text = "Gross Profit";
            // 
            // EquityTextBox
            // 
            this.EquityTextBox.Location = new System.Drawing.Point(121, 131);
            this.EquityTextBox.Name = "EquityTextBox";
            this.EquityTextBox.Size = new System.Drawing.Size(181, 20);
            this.EquityTextBox.TabIndex = 7;
            // 
            // EquityLabel
            // 
            this.EquityLabel.AutoSize = true;
            this.EquityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquityLabel.Location = new System.Drawing.Point(5, 131);
            this.EquityLabel.Name = "EquityLabel";
            this.EquityLabel.Size = new System.Drawing.Size(72, 25);
            this.EquityLabel.TabIndex = 6;
            this.EquityLabel.Text = "Equity";
            // 
            // SalesTextBox
            // 
            this.SalesTextBox.Location = new System.Drawing.Point(121, 92);
            this.SalesTextBox.Name = "SalesTextBox";
            this.SalesTextBox.Size = new System.Drawing.Size(181, 20);
            this.SalesTextBox.TabIndex = 5;
            // 
            // SalesLabel
            // 
            this.SalesLabel.AutoSize = true;
            this.SalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesLabel.Location = new System.Drawing.Point(5, 92);
            this.SalesLabel.Name = "SalesLabel";
            this.SalesLabel.Size = new System.Drawing.Size(66, 25);
            this.SalesLabel.TabIndex = 4;
            this.SalesLabel.Text = "Sales";
            // 
            // LiabilitiesTextBox
            // 
            this.LiabilitiesTextBox.Location = new System.Drawing.Point(121, 54);
            this.LiabilitiesTextBox.Name = "LiabilitiesTextBox";
            this.LiabilitiesTextBox.Size = new System.Drawing.Size(181, 20);
            this.LiabilitiesTextBox.TabIndex = 3;
            // 
            // LiabilitiesLabel
            // 
            this.LiabilitiesLabel.AutoSize = true;
            this.LiabilitiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiabilitiesLabel.Location = new System.Drawing.Point(5, 54);
            this.LiabilitiesLabel.Name = "LiabilitiesLabel";
            this.LiabilitiesLabel.Size = new System.Drawing.Size(102, 25);
            this.LiabilitiesLabel.TabIndex = 2;
            this.LiabilitiesLabel.Text = "Liabilities";
            // 
            // AssetTextBox
            // 
            this.AssetTextBox.Location = new System.Drawing.Point(121, 16);
            this.AssetTextBox.Name = "AssetTextBox";
            this.AssetTextBox.Size = new System.Drawing.Size(181, 20);
            this.AssetTextBox.TabIndex = 1;
            // 
            // AssetLabel
            // 
            this.AssetLabel.AutoSize = true;
            this.AssetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssetLabel.Location = new System.Drawing.Point(6, 16);
            this.AssetLabel.Name = "AssetLabel";
            this.AssetLabel.Size = new System.Drawing.Size(66, 25);
            this.AssetLabel.TabIndex = 0;
            this.AssetLabel.Text = "Asset";
            // 
            // InsertFinancialReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 478);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "InsertFinancialReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insert Financial Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InsertFinancialReportForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label StockTickerLabel;
        private System.Windows.Forms.DateTimePicker FinancialDateTimePicker;
        private System.Windows.Forms.Label StockDateLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox EquityTextBox;
        private System.Windows.Forms.Label EquityLabel;
        private System.Windows.Forms.TextBox SalesTextBox;
        private System.Windows.Forms.Label SalesLabel;
        private System.Windows.Forms.TextBox LiabilitiesTextBox;
        private System.Windows.Forms.Label LiabilitiesLabel;
        private System.Windows.Forms.TextBox AssetTextBox;
        private System.Windows.Forms.Label AssetLabel;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.TextBox CashFlowTextBox;
        private System.Windows.Forms.Label CashFlowLabel;
        private System.Windows.Forms.TextBox NetIncomeTextBox;
        private System.Windows.Forms.Label NetIncomeLabel;
        private System.Windows.Forms.TextBox GrossProfitTextBox;
        private System.Windows.Forms.Label GrossProfitLabel;
        private System.Windows.Forms.ComboBox TickerComboBox;
    }
}