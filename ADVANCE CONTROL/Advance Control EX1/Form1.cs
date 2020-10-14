using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advance_Control_EX1
{
    public partial class Form1 : Form
    {
        List<Vehicle> listVehicles = new List<Vehicle>();
        public Form1()
        {
            InitializeComponent();
            init();
            
        }


        public void init()
        {
            //add data
            listVehicles.Add(new Vehicle("Desmosedici RR", 2, "Ducati"));
            listVehicles[0].ListOptions.Add(new Option(2005, 125, 40000));
            listVehicles[0].ListOptions.Add(new Option(2006, 125, 42000));

            listVehicles.Add(new Vehicle("YZF R1", 2, "Yamaha"));
            listVehicles[1].ListOptions.Add(new Option(2006, 150, 52000));

            listVehicles.Add(new Vehicle("Accord", 4, "Honda"));
            listVehicles[2].ListOptions.Add(new Option(2006, 300, 750000));
            listVehicles[2].ListOptions.Add(new Option(2007, 400, 700000));

            listVehicles.Add(new Vehicle("Accent", 4, "Huyndai"));
            listVehicles[3].ListOptions.Add(new Option(2006, 300, 750000));
            listVehicles[3].ListOptions.Add(new Option(2007, 400, 700000));

            //add data to tree view
            TreeNode treeNodeNumberWheeler2 = new TreeNode("Two Wheeler");
            TreeNode treeNodeNumberWheeler4 = new TreeNode("Four Wheeler");

            treeView.Nodes.Add(treeNodeNumberWheeler2);
            treeView.Nodes.Add(treeNodeNumberWheeler4);

            foreach (Vehicle vehicle in listVehicles)
            {
                if (vehicle.NumberWheeler == 2)
                {
                    treeNodeNumberWheeler2.Nodes.Add(vehicle.Name);
                }
                else if (vehicle.NumberWheeler == 4)
                {
                    treeNodeNumberWheeler4.Nodes.Add(vehicle.Name);
                }
            }


            listView.View = View.Details;
            listView.GridLines = true;
            //listView.FullRowSelect = true;

            listView.Columns.Add("Manufacturer");
            listView.Columns.Add("Make");
            listView.Columns.Add("Engine Capacity");
            listView.Columns.Add("Price");

            listView.Columns[0].Width = -2;
            listView.Columns[1].Width = -2;
            listView.Columns[2].Width = -2;
            listView.Columns[3].Width = -2;

            //Add data to domainUpDown
            DomainUpDown.DomainUpDownItemCollection collection = this.domainUpDown.Items;


            collection.Add("A/C System");
            collection.Add("Stereo Deck System");
            collection.Add("Insurance");
            collection.Add("Service Contract");

            this.domainUpDown.Text = collection[0].ToString();

            numericUpDown.Text = 1.ToString();
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void treeView_DoubleClick(object sender, EventArgs e)
        {
            listView.Items.Clear();
            String vehicleName = treeView.SelectedNode.Text;
            foreach (Vehicle vehicle in listVehicles)
            {
                if (vehicle.Name.Equals(vehicleName))
                {
                    foreach (Option option in vehicle.ListOptions)
                    {
                        String[] row =
                        {
                            vehicle.Manufacturer, option.Make.ToString(),
                            option.EngineCapacity.ToString(), option.Price.ToString()
                        };
                        listView.Items.Add(new ListViewItem(row));
                    }
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SizeLastColumn(listView);
        }

        private void listView_Resize(object sender, System.EventArgs e)
        {
            SizeLastColumn((ListView)sender);
        }

        private void SizeLastColumn(ListView lv)
        {
            lv.Columns[lv.Columns.Count - 1].Width = -2;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("You have to select option!", "Message");
            }
            else
            {
                String message = "";
                message += "Vehicle: " + treeView.SelectedNode.Text;
                message += "\nManufacturer: " + listView.SelectedItems[0].SubItems[0].Text;
                message += "\nQuantity: " + numericUpDown.Text;
                message += "\nTotal Amount: " + tbxTotalAmount.Text;
                message += "\nAddon Features: " + domainUpDown.Text;
                MessageBox.Show(message, "Purchase Order");
            }
              
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
                return;

            ListViewItem itemSelected = listView.SelectedItems[0];
            //fill the text boxes
            int price = Convert.ToInt32(itemSelected.SubItems[3].Text);
            int quantity = Convert.ToInt32(numericUpDown.Text);
            int totalAmounts = price * quantity;
            tbxTotalAmount.Text = totalAmounts.ToString();
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
                return;

            ListViewItem itemSelected = listView.SelectedItems[0];
            //fill the text boxes
            int price = Convert.ToInt32(itemSelected.SubItems[3].Text);
            int quantity = Convert.ToInt32(numericUpDown.Text);
            int totalAmounts = price * quantity;
            tbxTotalAmount.Text = totalAmounts.ToString();
        }
    }
}
