namespace Equity.View.Portfolio
{
    partial class CreateTransactionForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TickerComboBox = new System.Windows.Forms.ComboBox();
            this.TransactionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TransactionDateLabel = new System.Windows.Forms.Label();
            this.StockTickerLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.BrokerComboBox = new System.Windows.Forms.ComboBox();
            this.BrokerCodeLabel = new System.Windows.Forms.Label();
            this.TransactionPriceTextBox = new System.Windows.Forms.TextBox();
            this.TransactionPriceLabel = new System.Windows.Forms.Label();
            this.SellRadioButton = new System.Windows.Forms.RadioButton();
            this.BuyRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SharesNumberTextBox = new System.Windows.Forms.TextBox();
            this.SharesLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TickerComboBox);
            this.groupBox1.Controls.Add(this.TransactionDateTimePicker);
            this.groupBox1.Controls.Add(this.TransactionDateLabel);
            this.groupBox1.Controls.Add(this.StockTickerLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 52);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // TickerComboBox
            // 
            this.TickerComboBox.FormattingEnabled = true;
            this.TickerComboBox.Location = new System.Drawing.Point(83, 17);
            this.TickerComboBox.Name = "TickerComboBox";
            this.TickerComboBox.Size = new System.Drawing.Size(121, 21);
            this.TickerComboBox.TabIndex = 4;
            // 
            // TransactionDateTimePicker
            // 
            this.TransactionDateTimePicker.Location = new System.Drawing.Point(444, 19);
            this.TransactionDateTimePicker.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.TransactionDateTimePicker.Name = "TransactionDateTimePicker";
            this.TransactionDateTimePicker.Size = new System.Drawing.Size(198, 20);
            this.TransactionDateTimePicker.TabIndex = 2;
            // 
            // TransactionDateLabel
            // 
            this.TransactionDateLabel.AutoSize = true;
            this.TransactionDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionDateLabel.Location = new System.Drawing.Point(262, 16);
            this.TransactionDateLabel.Name = "TransactionDateLabel";
            this.TransactionDateLabel.Size = new System.Drawing.Size(176, 25);
            this.TransactionDateLabel.TabIndex = 3;
            this.TransactionDateLabel.Text = "Transaction Date";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CreateButton);
            this.groupBox2.Controls.Add(this.BrokerComboBox);
            this.groupBox2.Controls.Add(this.BrokerCodeLabel);
            this.groupBox2.Controls.Add(this.TransactionPriceTextBox);
            this.groupBox2.Controls.Add(this.TransactionPriceLabel);
            this.groupBox2.Controls.Add(this.SellRadioButton);
            this.groupBox2.Controls.Add(this.BuyRadioButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.SharesNumberTextBox);
            this.groupBox2.Controls.Add(this.SharesLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 377);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(156, 177);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(204, 23);
            this.CreateButton.TabIndex = 9;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // BrokerComboBox
            // 
            this.BrokerComboBox.FormattingEnabled = true;
            this.BrokerComboBox.Location = new System.Drawing.Point(157, 130);
            this.BrokerComboBox.Name = "BrokerComboBox";
            this.BrokerComboBox.Size = new System.Drawing.Size(203, 21);
            this.BrokerComboBox.TabIndex = 8;
            // 
            // BrokerCodeLabel
            // 
            this.BrokerCodeLabel.AutoSize = true;
            this.BrokerCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrokerCodeLabel.Location = new System.Drawing.Point(12, 130);
            this.BrokerCodeLabel.Name = "BrokerCodeLabel";
            this.BrokerCodeLabel.Size = new System.Drawing.Size(56, 20);
            this.BrokerCodeLabel.TabIndex = 7;
            this.BrokerCodeLabel.Text = "Broker";
            // 
            // TransactionPriceTextBox
            // 
            this.TransactionPriceTextBox.Location = new System.Drawing.Point(156, 94);
            this.TransactionPriceTextBox.Name = "TransactionPriceTextBox";
            this.TransactionPriceTextBox.Size = new System.Drawing.Size(204, 20);
            this.TransactionPriceTextBox.TabIndex = 6;
            this.TransactionPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TransactionPriceTextBox_KeyPress);
            // 
            // TransactionPriceLabel
            // 
            this.TransactionPriceLabel.AutoSize = true;
            this.TransactionPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionPriceLabel.Location = new System.Drawing.Point(12, 94);
            this.TransactionPriceLabel.Name = "TransactionPriceLabel";
            this.TransactionPriceLabel.Size = new System.Drawing.Size(131, 20);
            this.TransactionPriceLabel.TabIndex = 5;
            this.TransactionPriceLabel.Text = "Transaction Price";
            // 
            // SellRadioButton
            // 
            this.SellRadioButton.AutoSize = true;
            this.SellRadioButton.Location = new System.Drawing.Point(318, 59);
            this.SellRadioButton.Name = "SellRadioButton";
            this.SellRadioButton.Size = new System.Drawing.Size(42, 17);
            this.SellRadioButton.TabIndex = 4;
            this.SellRadioButton.TabStop = true;
            this.SellRadioButton.Text = "Sell";
            this.SellRadioButton.UseVisualStyleBackColor = true;
            // 
            // BuyRadioButton
            // 
            this.BuyRadioButton.AutoSize = true;
            this.BuyRadioButton.Location = new System.Drawing.Point(157, 59);
            this.BuyRadioButton.Name = "BuyRadioButton";
            this.BuyRadioButton.Size = new System.Drawing.Size(43, 17);
            this.BuyRadioButton.TabIndex = 3;
            this.BuyRadioButton.TabStop = true;
            this.BuyRadioButton.Text = "Buy";
            this.BuyRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transaction Types";
            // 
            // SharesNumberTextBox
            // 
            this.SharesNumberTextBox.Location = new System.Drawing.Point(156, 19);
            this.SharesNumberTextBox.Name = "SharesNumberTextBox";
            this.SharesNumberTextBox.Size = new System.Drawing.Size(204, 20);
            this.SharesNumberTextBox.TabIndex = 1;
            this.SharesNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SharesNumberTextBox_KeyPress);
            // 
            // SharesLabel
            // 
            this.SharesLabel.AutoSize = true;
            this.SharesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SharesLabel.Location = new System.Drawing.Point(12, 20);
            this.SharesLabel.Name = "SharesLabel";
            this.SharesLabel.Size = new System.Drawing.Size(138, 20);
            this.SharesLabel.TabIndex = 0;
            this.SharesLabel.Text = "Number of Shares";
            // 
            // CreateTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 452);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateTransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateTransactionForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CreateTransactionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox TickerComboBox;
        private System.Windows.Forms.DateTimePicker TransactionDateTimePicker;
        private System.Windows.Forms.Label TransactionDateLabel;
        private System.Windows.Forms.Label StockTickerLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SharesNumberTextBox;
        private System.Windows.Forms.Label SharesLabel;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.ComboBox BrokerComboBox;
        private System.Windows.Forms.Label BrokerCodeLabel;
        private System.Windows.Forms.TextBox TransactionPriceTextBox;
        private System.Windows.Forms.Label TransactionPriceLabel;
        private System.Windows.Forms.RadioButton SellRadioButton;
        private System.Windows.Forms.RadioButton BuyRadioButton;
        private System.Windows.Forms.Label label1;
    }
}