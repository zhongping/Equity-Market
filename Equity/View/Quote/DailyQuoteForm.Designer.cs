namespace Equity.View.Quote
{
    partial class DailyQuoteForm
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
            this.StockQuoteLabel = new System.Windows.Forms.Label();
            this.DailyQuoteDataGridView = new System.Windows.Forms.DataGridView();
            this.StockNameLabel = new System.Windows.Forms.Label();
            this.QuoteSearchTextBox = new System.Windows.Forms.TextBox();
            this.QuoteSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DailyQuoteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StockQuoteLabel
            // 
            this.StockQuoteLabel.AutoSize = true;
            this.StockQuoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockQuoteLabel.Location = new System.Drawing.Point(255, 10);
            this.StockQuoteLabel.Name = "StockQuoteLabel";
            this.StockQuoteLabel.Size = new System.Drawing.Size(84, 37);
            this.StockQuoteLabel.TabIndex = 0;
            this.StockQuoteLabel.Text = "label";
            // 
            // DailyQuoteDataGridView
            // 
            this.DailyQuoteDataGridView.AllowUserToAddRows = false;
            this.DailyQuoteDataGridView.AllowUserToDeleteRows = false;
            this.DailyQuoteDataGridView.AllowUserToOrderColumns = true;
            this.DailyQuoteDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DailyQuoteDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DailyQuoteDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DailyQuoteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DailyQuoteDataGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DailyQuoteDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DailyQuoteDataGridView.Location = new System.Drawing.Point(12, 54);
            this.DailyQuoteDataGridView.Name = "DailyQuoteDataGridView";
            this.DailyQuoteDataGridView.ReadOnly = true;
            this.DailyQuoteDataGridView.Size = new System.Drawing.Size(787, 391);
            this.DailyQuoteDataGridView.TabIndex = 1;
            // 
            // StockNameLabel
            // 
            this.StockNameLabel.AutoSize = true;
            this.StockNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockNameLabel.Location = new System.Drawing.Point(362, 10);
            this.StockNameLabel.Name = "StockNameLabel";
            this.StockNameLabel.Size = new System.Drawing.Size(84, 37);
            this.StockNameLabel.TabIndex = 2;
            this.StockNameLabel.Text = "label";
            // 
            // QuoteSearchTextBox
            // 
            this.QuoteSearchTextBox.Location = new System.Drawing.Point(12, 22);
            this.QuoteSearchTextBox.Name = "QuoteSearchTextBox";
            this.QuoteSearchTextBox.Size = new System.Drawing.Size(100, 20);
            this.QuoteSearchTextBox.TabIndex = 3;
            // 
            // QuoteSearchButton
            // 
            this.QuoteSearchButton.Location = new System.Drawing.Point(118, 20);
            this.QuoteSearchButton.Name = "QuoteSearchButton";
            this.QuoteSearchButton.Size = new System.Drawing.Size(75, 23);
            this.QuoteSearchButton.TabIndex = 4;
            this.QuoteSearchButton.Text = "Search";
            this.QuoteSearchButton.UseVisualStyleBackColor = true;
            this.QuoteSearchButton.Click += new System.EventHandler(this.QuoteSearchButton_Click);
            // 
            // DailyQuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 457);
            this.Controls.Add(this.QuoteSearchButton);
            this.Controls.Add(this.QuoteSearchTextBox);
            this.Controls.Add(this.StockNameLabel);
            this.Controls.Add(this.DailyQuoteDataGridView);
            this.Controls.Add(this.StockQuoteLabel);
            this.Name = "DailyQuoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Daily Quote ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DailyQuoteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DailyQuoteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StockQuoteLabel;
        private System.Windows.Forms.DataGridView DailyQuoteDataGridView;
        private System.Windows.Forms.Label StockNameLabel;
        private System.Windows.Forms.TextBox QuoteSearchTextBox;
        private System.Windows.Forms.Button QuoteSearchButton;
    }
}