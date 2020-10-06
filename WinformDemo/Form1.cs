using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            txtOutput.BackColor = Color.WhiteSmoke;
            String output = "";
            try
            {
                int a = Convert.ToInt32(txtA.Text);
                int b = Convert.ToInt32(txtB.Text);
                int c = Convert.ToInt32(txtC.Text);
        
            

            float delta = (float) b * b - 4 * a * c;

            if (delta < 0)
            {
                output = "No solution!";
            }else if (delta == 0)
            {
                float x = (float) -b / (2 * a);
                output = "x1 = x2 = " + x;
            }
            else
            {
                float x1 = (float) (-b + Math.Sqrt(delta)) / (2 * a);
                float x2 = (float)(-b - Math.Sqrt(delta)) / (2 * a);
                output = "x1 = " + x1 + Environment.NewLine +"x2 = " + x2;
            }
            }
            catch (Exception ex)
            {
                output = "Invalid Input!";
                txtOutput.BackColor = Color.Red;
            }
            txtOutput.Text = output;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtOutput.BackColor = Color.WhiteSmoke;
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtOutput.Text = "";
            txtA.Focus();
        }
    }
}
