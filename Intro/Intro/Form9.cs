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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            InvoiceDb IDb = new InvoiceDb();
            CustomerDb CDb = new CustomerDb();
            List<Invoice> invoiceList = IDb.GetAllInvoices();
            List<Customer> customerList = CDb.GetAllCustomers();

            var invoices = from invoice in invoiceList join customer in customerList on invoice.CustomerID equals customer.CustomerID where invoice.InvoiceTotal > 150 orderby customer.Name, invoice.InvoiceTotal descending select new { customer.Name, invoice.InvoiceTotal };

            string invoiceDisplay = "Customer Name\t\tInvoice amount\n";
            foreach (var invoice in invoices)
            {
                invoiceDisplay += invoice.Name + "\t\t";
                invoiceDisplay += invoice.InvoiceTotal.ToString("c") + "\n";
            }
            MessageBox.Show(invoiceDisplay,
             "Joined Customer and Invoice Data");
        }
    }
}
