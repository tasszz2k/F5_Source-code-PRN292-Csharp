using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advance_Control_EX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            
            if (!richTextBox1.SelectionFont.Bold)
            {
                SetFontForSlectedText(FontStyle.Bold, true);

            }
            else
            {
                SetFontForSlectedText(FontStyle.Bold, false);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.SelectionFont.Italic)
            {
                SetFontForSlectedText(FontStyle.Italic, true);
            }
            else
            {
                SetFontForSlectedText(FontStyle.Italic, false);
            }
        }

        private void SetFontForSlectedText(FontStyle fontStyle, bool action)
        {
            System.Drawing.FontStyle newFontStyle = FontStyle.Regular;
            if (richTextBox1.SelectionFont.Bold) newFontStyle |= FontStyle.Bold;
            if (richTextBox1.SelectionFont.Italic) newFontStyle |= FontStyle.Italic;
            if (richTextBox1.SelectionFont.Underline) newFontStyle |= FontStyle.Underline;
            if (action)
            {
                newFontStyle |= fontStyle;
            }
            else
            {
                newFontStyle ^= fontStyle;
            }
            richTextBox1.SelectionFont = new Font(richTextBox1.Font, newFontStyle);
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.SelectionFont.Underline)
            {
                SetFontForSlectedText(FontStyle.Underline, true);

            }
            else
            {
                SetFontForSlectedText(FontStyle.Underline, false);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FontStyle.Bold.GetType() + "", "");
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;

        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            //richTextBox1.SelectAll();
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;

        }
    }
}
