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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] numbers = new int[6];
            for (int i = 0; i < numbers.Length; i++) numbers[i] = i;
            var numberList = from number in numbers
                             where number % 2 == 0
                             orderby number descending
                             select number;
            string numberDisplay = "";
            foreach (var number in numberList) numberDisplay += number + "\t\t\n";
            MessageBox.Show(numberDisplay, "Sorted Even Numbers");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Hide();
            f2.ShowDialog();
            Close();
        }
    }
}
