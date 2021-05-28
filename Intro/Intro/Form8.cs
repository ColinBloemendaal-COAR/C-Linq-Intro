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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            SortedList<string, decimal> employeeSales = new SortedList<string, decimal> { ["Anderson"] = 1286.45m, ["Menendez"] = 2433.49m, ["Thompson"] = 2893.85m, ["Wilkinson"] = 2094.53m };

            var employeeList = from sales in employeeSales where sales.Value > 2000 orderby sales.Value descending select sales.Key;

            string employeeDisplay = "";
            foreach (var employee in employeeList) 
                employeeDisplay += employee + "\t\t\t\n";

            MessageBox.Show(employeeDisplay, "Sorted Employees With Sales Over $2000");


        }
    }
}
