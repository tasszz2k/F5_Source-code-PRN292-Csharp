using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB10_1
{
    public partial class LAB10_1 : Form
    {
        CustomerDAO customerDao = new CustomerDAO();
        BindingSource bindingSource = new BindingSource();
        public LAB10_1()
        {
            InitializeComponent();
        }

        private void LAB10_1_Load(object sender, EventArgs e)
        {
            //style dadaGridView
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //end style dadaGridView

          PopulateDataGridViewCustomer();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
                //DataGridViewRow dgvCurrentRow = dgvCustomer.CurrentRow;
                //if (dgvCurrentRow.Cells[0].Value != DBNull.Value)
                //{
                //    if (MessageBox.Show("Are you sure to detele this record?", "DataGridView",
                //            MessageBoxButtons.YesNo) ==
                //        DialogResult.Yes)
                //    {
                //        customerDao.Delete(dgvCurrentRow);
                //        //PopulateDataGridViewCustomer();
                //    }
                //    else
                //    {
                //        //e.Cancel = true;
                //    }
                //}
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //bindingSource.EndEdit();
            //customerDao.UpdateData();
        }

        private void dgvCustomer_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvCustomer.CurrentRow != null)
            {
                DataGridViewRow dgvCurrentRow = dgvCustomer.CurrentRow;
                if (dgvCurrentRow.Cells[0].Value == DBNull.Value)//insert
                {
                    customerDao.Insert(dgvCurrentRow);
                }
                else //Update
                {
                    customerDao.Update(dgvCurrentRow);
                }
                PopulateDataGridViewCustomer();
            }
        }


        private void PopulateDataGridViewCustomer()
        {
            bindingSource.DataSource = customerDao.GetAll();

            dgvCustomer.DataSource = bindingSource;
            bnavCustomer.BindingSource = bindingSource;
        }

        private void dgvCustomer_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridViewRow dgvCurrentRow = dgvCustomer.CurrentRow;
            if (dgvCurrentRow.Cells[0].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are you sure to detele this record?", "dgvCustomer", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    customerDao.Delete(dgvCurrentRow);
                    //PopulateDataGridViewCustomer();
                }
                else
                {
                    e.Cancel = true;
                }
              

            }
        }
    }
}
