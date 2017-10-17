namespace Equity.View.Quote
{
    partial class EditQuoteForm
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
            this.EditStockQuoteLabel = new System.Windows.Forms.Label();
            this.fileDateLabel = new System.Windows.Forms.Label();
            this.EditQuoteDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EditStockQuoteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditStockQuoteLabel
            // 
            this.EditStockQuoteLabel.AutoSize = true;
            this.EditStockQuoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditStockQuoteLabel.Location = new System.Drawing.Point(73, 26);
            this.EditStockQuoteLabel.Name = "EditStockQuoteLabel";
            this.EditStockQuoteLabel.Size = new System.Drawing.Size(199, 29);
            this.EditStockQuoteLabel.TabIndex = 0;
            this.EditStockQuoteLabel.Text = "Edit Stock Quote ";
            // 
            // fileDateLabel
            // 
            this.fileDateLabel.AutoSize = true;
            this.fileDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileDateLabel.Location = new System.Drawing.Point(12, 62);
            this.fileDateLabel.Name = "fileDateLabel";
            this.fileDateLabel.Size = new System.Drawing.Size(82, 24);
            this.fileDateLabel.TabIndex = 1;
            this.fileDateLabel.Text = "File date";
            // 
            // EditQuoteDateTimePicker
            // 
            this.EditQuoteDateTimePicker.Location = new System.Drawing.Point(119, 66);
            this.EditQuoteDateTimePicker.Name = "EditQuoteDateTimePicker";
            this.EditQuoteDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.EditQuoteDateTimePicker.TabIndex = 2;
            // 
            // EditStockQuoteButton
            // 
            this.EditStockQuoteButton.Location = new System.Drawing.Point(119, 111);
            this.EditStockQuoteButton.Name = "EditStockQuoteButton";
            this.EditStockQuoteButton.Size = new System.Drawing.Size(75, 23);
            this.EditStockQuoteButton.TabIndex = 3;
            this.EditStockQuoteButton.Text = "Upload";
            this.EditStockQuoteButton.UseVisualStyleBackColor = true;
            this.EditStockQuoteButton.Click += new System.EventHandler(this.EditStockQuoteButton_Click);
            // 
            // EditQuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 173);
            this.Controls.Add(this.EditStockQuoteButton);
            this.Controls.Add(this.EditQuoteDateTimePicker);
            this.Controls.Add(this.fileDateLabel);
            this.Controls.Add(this.EditStockQuoteLabel);
            this.Name = "EditQuoteForm";
            this.Text = "EditQuoteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EditStockQuoteLabel;
        private System.Windows.Forms.Label fileDateLabel;
        private System.Windows.Forms.DateTimePicker EditQuoteDateTimePicker;
        private System.Windows.Forms.Button EditStockQuoteButton;
    }
}