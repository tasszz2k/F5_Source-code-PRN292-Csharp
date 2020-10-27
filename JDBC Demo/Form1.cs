using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JDBC_Demo
{
    public partial class Form1 : Form
    {
        CustomerDAO customerDao = new CustomerDAO();
        CountryDAO countryDao = new CountryDAO();
        List<CustomerModel> customers = new List<CustomerModel>();
        private CustomerModel customerSelected = new CustomerModel();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbxCustomerName.Text = "";
            tbxAddress.Text = "";
            tbxCity.Text = "";
            mtbxPhone.Text = "";
            mtbxZipCode.Text = "";
            SetStatusOfButtons(0);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> countries = countryDao.getAll();
            foreach (string country in countries)
            {
                cbxCountry.Items.Add(country);
            }

            cbxCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCountry.SelectedIndex = 0;

            //load data to listView
            UpdateDataListVIew();

            //set status button
            SetStatusOfButtons(2);


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem row = listView1.SelectedItems[0];
                //set value to attribute of customerSlected
                int customerId = Convert.ToInt32(row.SubItems[0].Text);
                customerSelected = customerDao.findById(customerId);

                tbxCustomerName.Text = customerSelected.Name;
                tbxAddress.Text = customerSelected.Address;
                tbxCity.Text = customerSelected.City;
                mtbxPhone.Text = customerSelected.Phone;
                mtbxZipCode.Text = customerSelected.ZipCode;
                SetStatusOfButtons(0);
            }
            else
            {
                tbxCustomerName.Text = "";
                tbxAddress.Text = "";
                tbxCity.Text = "";
                mtbxPhone.Text = "";
                mtbxZipCode.Text = "";
                SetStatusOfButtons(2);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            tbxCustomerName.Text = "";
            tbxAddress.Text = "";
            tbxCity.Text = "";
            mtbxPhone.Text = "";
            mtbxZipCode.Text = "";

            //set status button
            SetStatusOfButtons(1);

        }

        private void UpdateDataListVIew()
        {
            listView1.Items.Clear();
            customers = customerDao.GetAll();

            foreach (CustomerModel customer in customers)
            {
                ListViewItem row = new ListViewItem(customer.GetListViewItem());
                listView1.Items.Add(row);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (IsFullInput())
            {
                customerDao.deleteById(customerSelected.Id);
                UpdateDataListVIew();
                MessageBox.Show("Delete Successfully", "Notitfy");
            }
            else
            {
                MessageBox.Show("You have to input all text box!", "Error");
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private bool IsFullInput()
        {
            if (tbxCustomerName.Text.Trim() != ""&&
            tbxAddress.Text.Trim() != "" &&
            tbxCity.Text.Trim() != "" &&
            mtbxPhone.Text.Trim() != "" &&
            mtbxZipCode.Text.Trim() != "")
            {
                return true;
            }
           
            return false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (IsFullInput())
            {
                CustomerModel customer = new CustomerModel(customerSelected.Id, tbxCustomerName.Text,
                    tbxAddress.Text, tbxCity.Text, cbxCountry.SelectedItem.ToString(),
                    mtbxPhone.Text, mtbxZipCode.Text);
                customerDao.update(customer);
                UpdateDataListVIew();
                MessageBox.Show("Edit Successfully!", "Notify");
            }
            else
            {
                MessageBox.Show("You have to input all text box!", "Error");

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsFullInput())
            {
                CustomerModel customer = new CustomerModel(tbxCustomerName.Text,
                    tbxAddress.Text, tbxCity.Text, cbxCountry.SelectedItem.ToString(),
                    mtbxPhone.Text, mtbxZipCode.Text);
                customerDao.insert(customer);
                UpdateDataListVIew();
                MessageBox.Show("Insert Successfully!", "Notify");
                SetStatusOfButtons(0);
            }
            else
            {
                MessageBox.Show("You have to input all text box!", "Error");

            }
        }

        private void SetStatusOfButtons(int status)
        {
            switch (status)
            {
                case 0://default
                    //set status button
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;

                    btnAddNew.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    break;
                case 1://add new
                    //set status button
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;

                    btnAddNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    break;
                case 2:
                    //set status button
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;

                    btnAddNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    break;
            }
        }
    }
}
