using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LAB5_EX2
{
    public partial class FormProductDetail : Form
    {

        List<Product> products  = new List<Product>();

        public FormProductDetail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProductDetail_Load(object sender, EventArgs e)
        {
            this.cbxProduct.DropDownStyle = ComboBoxStyle.DropDownList;

            products.Add(new Product("Product 1", 100));
            products.Add(new Product("Product 2", 200));
            products.Add(new Product("Product 3", 300));
            products.Add(new Product("Product 4", 400));
            products.Add(new Product("Product 5", 500));

            foreach (Product product in products)
            {
                cbxProduct.Items.Add(product.Name);
            }

            //set default cbx
            cbxProduct.SelectedItem = cbxProduct.Items[0];
            tbxPrice.Text = products[0].Price.ToString();
        }

        private void tbxQuantity_TextChanged(object sender, EventArgs e)
        {
            changeValueTbx();
        }

        private void cbxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbxProduct.SelectedIndex;
            tbxPrice.Text = products[index].Price.ToString();
            changeValueTbx();
        }

        private void changeValueTbx()
        {
            int quantity = Convert.ToInt32(tbxQuantity.Text);
            int price = Convert.ToInt32(tbxPrice.Text);
            int amount = quantity * price;
            tbxAmount.Text = amount.ToString();
        }




        public IContainer Components
        {
            get => components;
            set => components = value;
        }

        public GroupBox GroupBox1
        {
            get => groupBox1;
            set => groupBox1 = value;
        }

        public TextBox TbxAmount
        {
            get => tbxAmount;
            set => tbxAmount = value;
        }

        public TextBox TbxQuantity
        {
            get => tbxQuantity;
            set => tbxQuantity = value;
        }

        public TextBox TbxPrice
        {
            get => tbxPrice;
            set => tbxPrice = value;
        }

        public Label Label3
        {
            get => label3;
            set => label3 = value;
        }

        public Label Label4
        {
            get => label4;
            set => label4 = value;
        }

        public Label Label2
        {
            get => label2;
            set => label2 = value;
        }

        public ComboBox CbxProduct
        {
            get => cbxProduct;
            set => cbxProduct = value;
        }

        public Label Label1
        {
            get => label1;
            set => label1 = value;
        }

        public Button BtnCancel
        {
            get => btnCancel;
            set => btnCancel = value;
        }

        public Button BtnOk
        {
            get => btnOK;
            set => btnOK = value;
        }
    }
}
