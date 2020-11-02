using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo_WebForm2
{
    public partial class Home : System.Web.UI.Page
    {
        static Dictionary<string, int> list = new Dictionary<string, int>();

        public static Dictionary<string, int> List
        {
            get => list;
            set => list = value;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            string selectedId = ddlBread.SelectedValue;
            string breadSelected = ddlBread.SelectedItem.Text;
            int quantity;
            //int quantity = Convert.ToInt32(tbxQuantity.Text);


            if (Int32.TryParse(tbxQuantity.Text, out quantity))
            {
                bool listContainsItem = isItemExist(ddlBread.SelectedValue, ListBoxSelected);

                if (!listContainsItem)
                {
                    ListBoxSelected.Items.Add(new ListItem(ddlBread.SelectedItem + "(" + quantity + ")", ddlBread.SelectedValue));
                    list.Add(ddlBread.SelectedItem.ToString(), quantity);
                }
                else
                {
                    int oldQuantity = 0;
                    if (list.TryGetValue(ddlBread.SelectedItem.ToString(), out oldQuantity))
                    {
                        oldQuantity = list[ddlBread.SelectedItem.ToString()];
                        list[ddlBread.SelectedItem.ToString()] += quantity;

                        ListBoxSelected.Items.FindByValue(ddlBread.SelectedValue).Text = ddlBread.SelectedItem + "(" + (list[ddlBread.SelectedItem.ToString()]) + ")";
                    }

                }
            }
           

        }

        protected void ListBoxSelected_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        bool isItemExist(string valueItem, ListBox listBox)
        {
            foreach (ListItem item in listBox.Items)
            {
                if (item.Value.Equals(valueItem))
                {
                    return true;
                }
            }

            return false;
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            ListBoxSelected.Items.Clear();
            list.Clear();
        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {
            Response.Redirect(String.Format("PrintOrder.aspx?customer={0}&address={1}&taxCode={2}",tbxCustomer.Text,tbxAddress.Text,tbxTaxCode.Text));
        }
    }
}