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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            InvoiceDb IDb = new InvoiceDb();
            List<Invoice> invoiceList = IDb.GetAllInvoices();
            var invoices = invoiceList .Where(i => i.InvoiceTotal > 150) .OrderBy(i => i.CustomerID).ThenByDescending(i => i.InvoiceTotal).Select(i => new { i.CustomerID, i.InvoiceTotal });

            BindingSource binding = new BindingSource();
            binding.DataSource = invoices;
            dataGridView1.DataSource = binding;
        }
    }
}
