using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWindow
{
    public partial class GreetingForm : Form
    {
        public GreetingForm()
        {
            InitializeComponent();
        }

        private void GreetingForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SayHello" + txtName.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("SayHi" + txtName.Text);

        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sravani" + txtName.Text);

        }
    }
}
