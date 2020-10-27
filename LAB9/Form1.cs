using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB9
{
    public partial class Form1 : Form
    {
        CustomerDAO customerDao = new CustomerDAO();
        BindingSource bindingSource = new BindingSource();
        List<CustomerModel> customers=new List<CustomerModel>();
        public Form1()
        {
            InitializeComponent();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            bindingSource.MoveFirst();
            SetValueGender();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customers = customerDao.GetAll();
            bindingSource.DataSource = customers;

            tbxName.DataBindings.Add("Text", bindingSource, "name");
            tbxAddress.DataBindings.Add("Text", bindingSource, "address");
            dtpBirthday.DataBindings.Add("Text", bindingSource, "dob");
            rbtnMale.DataBindings.Add("Checked", bindingSource, "gender", true, DataSourceUpdateMode.OnPropertyChanged, true);

            SetStatus(0);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bindingSource.MoveNext();
            SetValueGender();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bindingSource.MovePrevious();
            SetValueGender();
        }

        private void btnMoveLastItem_Click(object sender, EventArgs e)
        {
            bindingSource.MoveLast();
            SetValueGender();
        }

        private void SetValueGender()
        {
            if (!rbtnMale.Checked)
            {
                rbtnFemale.Checked = true;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            tbxName.Text = "";
            tbxAddress.Text = "";
            rbtnMale.Checked = true;
            SetStatus(1);
        }

        private void SetStatus(int status)
        {
            switch (status)
            {
                case 0:
                    btnAddNew.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;

                    tbxName.Enabled = false;
                    tbxAddress.Enabled = false;
                    dtpBirthday.Enabled = false;
                    rbtnMale.Enabled = false;
                    rbtnFemale.Enabled = false;

                    break;
                case 1:
                    btnAddNew.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;

                    tbxName.Enabled = true;
                    tbxAddress.Enabled = true;
                    dtpBirthday.Enabled = true;
                    rbtnMale.Enabled = true;
                    rbtnFemale.Enabled = true;
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbxName.Text = "";
            tbxAddress.Text = "";
            rbtnMale.Checked = true;
            SetStatus(0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomerModel customer = new CustomerModel(tbxName.Text,
                Convert.ToDateTime(dtpBirthday.Text), rbtnMale.Checked,tbxAddress.Text);
            customerDao.insert(customer);
            customers = customerDao.GetAll();
            MessageBox.Show("Insert Successfully", "Notify");
            SetStatus(0);

        }
    }
}
