namespace Equity.View.Quote
{
    partial class UploadQuoteForm
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
            this.uploadLabel = new System.Windows.Forms.Label();
            this.fileDateLabel = new System.Windows.Forms.Label();
            this.QuoteDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.UploadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uploadLabel
            // 
            this.uploadLabel.AutoSize = true;
            this.uploadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadLabel.Location = new System.Drawing.Point(67, 18);
            this.uploadLabel.Name = "uploadLabel";
            this.uploadLabel.Size = new System.Drawing.Size(229, 29);
            this.uploadLabel.TabIndex = 0;
            this.uploadLabel.Text = "Upload Stock Quote";
            this.uploadLabel.UseMnemonic = false;
            // 
            // fileDateLabel
            // 
            this.fileDateLabel.AutoSize = true;
            this.fileDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileDateLabel.Location = new System.Drawing.Point(22, 62);
            this.fileDateLabel.Name = "fileDateLabel";
            this.fileDateLabel.Size = new System.Drawing.Size(82, 24);
            this.fileDateLabel.TabIndex = 1;
            this.fileDateLabel.Text = "File date";
            // 
            // QuoteDateTimePicker
            // 
            this.QuoteDateTimePicker.Location = new System.Drawing.Point(121, 66);
            this.QuoteDateTimePicker.Name = "QuoteDateTimePicker";
            this.QuoteDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.QuoteDateTimePicker.TabIndex = 2;
            // 
            // UploadButton
            // 
            this.UploadButton.Location = new System.Drawing.Point(121, 109);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(75, 23);
            this.UploadButton.TabIndex = 3;
            this.UploadButton.Text = "Upload";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // UploadQuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 174);
            this.Controls.Add(this.UploadButton);
            this.Controls.Add(this.QuoteDateTimePicker);
            this.Controls.Add(this.fileDateLabel);
            this.Controls.Add(this.uploadLabel);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "UploadQuoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UploadQuoteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uploadLabel;
        private System.Windows.Forms.Label fileDateLabel;
        private System.Windows.Forms.DateTimePicker QuoteDateTimePicker;
        private System.Windows.Forms.Button UploadButton;
    }
}