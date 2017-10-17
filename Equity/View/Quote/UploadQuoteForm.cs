using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Equity.Helper;

namespace Equity.View.Quote
{
    public partial class UploadQuoteForm : Form
    {
        public UploadQuoteForm()
        {
            InitializeComponent();
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            FileHelper.UploadQuoteFile(QuoteDateTimePicker.Value);
        }
    }
}
