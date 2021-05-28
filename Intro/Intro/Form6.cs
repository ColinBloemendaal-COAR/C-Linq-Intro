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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            decimal[] salesTotals = new decimal[4] { 1286.45m, 2433.49m, 2893.85m, 2094.53m };
            var salesList = from sales in salesTotals where sales > 2000 orderby sales select sales;

            string salesDisplay = "";
            foreach (var sales in salesList)
                salesDisplay += sales.ToString("c") + "\t\t\t\n";
            MessageBox.Show(salesDisplay, "Sorted Sales Over $2000");
        }
    }
}
