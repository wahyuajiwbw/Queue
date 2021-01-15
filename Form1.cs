using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        int pc1 = 0;
        int pc2 = 0;
        int pc3 = 0;
        int pc4 = 0;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void reseet()
        {
            pc1.ToString("00");
            pc2.ToString("00");
            pc3.ToString("00");
            pc4.ToString("00");
        }
            
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pc1++;
            lbl1.Text = pc1.ToString();
            if (pc1 < 10)
            {
                lbl1.Text = "0" + pc1;
            }
            else
            {
                lbl1.Text = pc1.ToString();
            }
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("HH:mm");
            lbldate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            
        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            pc2++;
            lbl2.Text = pc2.ToString();
            if (pc2 < 10)
            {
                lbl2.Text = "0" + pc2;
            }
            else
            {
                lbl2.Text = pc2.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pc3++;
            lbl3.Text = pc3.ToString();
            if (pc3 < 10)
            {
                lbl3.Text = "0" + pc3;
            }
            else
            {
                lbl3.Text = pc3.ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pc4++;
            lbl4.Text = pc4.ToString();
            if (pc4 < 10)
            {
                lbl4.Text = "0" + pc4;
            }
            else
            {
                lbl4.Text = pc4.ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            reseet();
        }
    }
}
