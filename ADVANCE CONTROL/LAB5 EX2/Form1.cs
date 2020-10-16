using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB5_EX2
{
    public partial class Form1 : Form
    {
        private int totalAmount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            DateTime orderDate =dtpOrderDate.Value.Date;
            String strName = tbxName.Text;
            String strAddress = tbxAddress.Text;
            String strContactNo = tbxContactNo.Text;
            String strEmail = tbxEmail.Text;

            if (string.IsNullOrEmpty(strName))
            {
                MessageBox.Show("You have to input name!");
                //TODO: change pointer
                tbxName.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(strAddress))
            {
                MessageBox.Show("You have to input Address!");
                //TODO: change pointer
                tbxAddress.Focus();

                return;
            }
            else if (string.IsNullOrEmpty(strContactNo))
            {
                MessageBox.Show("You have to input Contact No!");
                //TODO: change pointer
                tbxContactNo.Focus();

                return;
            }
            else if (string.IsNullOrEmpty(strEmail))
            {
                MessageBox.Show("You have to input Email!");
                //TODO: change pointer
                tbxEmail.Focus();

                return;
            }
            else
            {
                FormProductDetail frmProductDetail = new FormProductDetail();
             

                DialogResult dr = new DialogResult();
                dr = frmProductDetail.ShowDialog();

                if (dr == DialogResult.OK)
                {

                    String product = frmProductDetail.CbxProduct.SelectedItem.ToString();
                    String price = frmProductDetail.TbxPrice.Text;
                    String quantity = frmProductDetail.TbxQuantity.Text;
                    String amount = frmProductDetail.TbxAmount.Text;
                    if (!quantity.Equals("0"))
                    {
                        String[] row =
                        {
                            (listView1.Items.Count+1).ToString(), product,price,quantity,amount
                        };
                        listView1.Items.Add(new ListViewItem(row));

                        totalAmount += Convert.ToInt32(amount);
                        tbxTotalAmount.Text = totalAmount.ToString();
                    }
                   
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
