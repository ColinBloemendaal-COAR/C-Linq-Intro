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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            InvoiceDb IDb = new InvoiceDb();
            using (var context = new Context())
            {
                List<Invoice> invoiceList = IDb.GetAllInvoices();
                var invoices = from invoice in invoiceList select invoice;

                decimal sum = 0;
                foreach (var invoice in invoices)
                    sum += invoice.InvoiceTotal;
                MessageBox.Show(sum.ToString());
            }
        }
    }
}
