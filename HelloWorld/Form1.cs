using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HWButton_Click(object sender, EventArgs e)
        {
            HWLabel.Show();
            HWButton.Hide();
            ExitButton.Show();
        }
        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
