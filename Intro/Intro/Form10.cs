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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            string phoneNumber = "5595551212";
            string formattedPhoneNumber =
            phoneNumber.FormattedPhoneNumber(".");
            MessageBox.Show(formattedPhoneNumber + "\t", "Extension Method");
        }
    }
}
