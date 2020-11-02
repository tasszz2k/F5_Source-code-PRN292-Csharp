using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        private List<string> languageList = new List<string>();
        private List<DVDLibrary> dvdLibraryList = new List<DVDLibrary>();

        LanguageDAO languageDao = new LanguageDAO();
        DVDLibraryDAO dvdLibraryDao = new DVDLibraryDAO();
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dvdLibraryList = dvdLibraryDao.getAll();
            languageList = languageDao.GetAll();
            foreach (string language in languageList)
            {
                cbxLanaguage.Items.Add(language);
            }

            foreach (DVDLibrary dvd in dvdLibraryList)
            {
                cbxCode.Items.Add(dvd.Code.ToString());
            }

        }

        private void cbxCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(cbxCode.SelectedItem.ToString());
            DVDLibrary dvdLibrary = dvdLibraryDao.findById(code);

            tbxTitle.Text = dvdLibrary.Title;
            cbxLanaguage.Text = dvdLibrary.Language;
            nudPrice.Text = dvdLibrary.Price.ToString();
            if (dvdLibrary.Subtitles)
            {
                rbtnYes.Checked = true;
            }
            else
            {
                rbtnNo.Checked = true;
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = tbxTitle.Text;
            string language = cbxLanaguage.Text;
            bool subtitle = rbtnYes.Checked ? true : false;
            float price = (float) Convert.ToDouble(nudPrice.Text);

            DVDLibrary dvd = new DVDLibrary(title,language,subtitle,price);


            dvdLibraryDao.Insert(dvd);

            MessageBox.Show("Inserted");

        }
    }
}
