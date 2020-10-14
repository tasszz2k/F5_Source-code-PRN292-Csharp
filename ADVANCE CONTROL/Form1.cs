using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADVANCE_CONTROL
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
            listVehicles.Add(new Vehicle("Desmosedici RR",2, "Ducati"));
            listVehicles[0].ListOptions.Add(new Option(2005, 125, 40000));
            listVehicles[0].ListOptions.Add(new Option(2006, 125, 42000));

            listVehicles.Add(new Vehicle("YZF R1",2, "Yamaha"));
            listVehicles[1].ListOptions.Add(new Option( 2006, 150, 52000));

            listVehicles.Add(new Vehicle("Accord",4, "Honda"));
            listVehicles[2].ListOptions.Add(new Option( 2006, 300, 750000));
            listVehicles[2].ListOptions.Add(new Option( 2007, 400, 700000));

            listVehicles.Add(new Vehicle("Accent",4, "Huyndai"));
            listVehicles[3].ListOptions.Add(new Option( 2006, 300, 750000));
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
                }else if (vehicle.NumberWheeler == 4)
                {
                    treeNodeNumberWheeler4.Nodes.Add(vehicle.Name);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
