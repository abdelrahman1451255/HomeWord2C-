using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2ndHomeWork
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hellowrod");
        }

        private void Dis_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            i++;
            if (i % 2 != 0)
            {
                label1.Visible = false;
            }
            else
            {
                label1.Visible = true;
            }
        }

        private void Ex_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
