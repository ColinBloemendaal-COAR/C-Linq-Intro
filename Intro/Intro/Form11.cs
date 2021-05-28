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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            
            compareDel invoiceOver150 = total => total > 150;

            decimal invoiceTotal = 188.46m;
            string invoiceMessage = "";
            invoiceMessage += "Invoice Total: " +
             invoiceTotal.ToString("c") +
             "\n" + "Invoice over $150: " +
             invoiceOver150(invoiceTotal);
            MessageBox.Show(invoiceMessage, "Invoice Test");
        }

        delegate bool compareDel(decimal total);
    }
}
