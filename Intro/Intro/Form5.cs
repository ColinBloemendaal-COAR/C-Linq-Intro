using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intro
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            InvoiceDb IDb = new InvoiceDb();
            List<Invoice> invoiceList = IDb.GetAllInvoices();
            var invoices = from invoice in invoiceList where invoice.InvoiceTotal > 150 select invoice;

            string invoiceDisplay = "";
            foreach (var invoice in invoices)
                invoiceDisplay +=
                invoice.InvoiceTotal.ToString("c") + "\t\t\n";
            MessageBox.Show(invoiceDisplay, "Invoices Over $150");
        }
    }
}
