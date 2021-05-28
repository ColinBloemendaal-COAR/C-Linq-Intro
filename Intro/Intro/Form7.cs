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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            InvoiceDb IDb = new InvoiceDb();
            List<Invoice> invoiceList = IDb.GetAllInvoices();
            var invoices = from invoice in invoiceList where invoice.InvoiceTotal > 150 orderby invoice.CustomerID, invoice.InvoiceTotal descending select invoice;

            string invoiceDisplay = "Cust ID\tInvoice amount\n";
            foreach (var invoice in invoices)
                invoiceDisplay += invoice.CustomerID + "\t" + invoice.InvoiceTotal.ToString("c") + "\n";

            MessageBox.Show(invoiceDisplay, "Sorted Invoices Over $150");

        }
    }
}
