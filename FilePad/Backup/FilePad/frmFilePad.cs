/*
 * frmFilePad.cs
 * 
 * Copyright © 2007 Aptech Software Limited. All rights reserved.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace FilePad
{
    /// <summary>
    /// Class frmFilePad is used to demonstrate the use of MDI application.
    /// </summary>
    public partial class frmFilePad : Form
    {
        FileStream fsFile;
        StreamWriter swFileWrite;
        StreamReader srFileRead;
        string strText = "";

        /// <summary>
        /// Constructor without parameters to initialize the
        /// controls for displaying the frmFilePad form. 
        /// </summary>
        public frmFilePad()
        {
            InitializeComponent();
        }

        // Loads the frmFilePad form
        private void frmFilePad_Load(object sender, EventArgs e)
        {
            stlblStatus.Text = "For help, press F1.";
        }

        // Opens a new file
        private void tlstrpmnuitemNew_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                DialogResult resDialog;
                resDialog = MessageBox.Show("Do you want save the current file?", "FilePad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (resDialog == DialogResult.Yes)
                {
                    Form activeChild = this.ActiveMdiChild;
                    tlstrpmnuitemSave_Click(sender, e);
                    tlstrpmnuitemClose_Click(sender, e);
                    tlstrpmnuitemNew_Click(sender, e);
                }
                else if (resDialog == DialogResult.No)
                {
                    tlstrpmnuitemClose_Click(sender, e);
                    tlstrpmnuitemNew_Click(sender, e);
                }
            }
            else
            {
                frmDocument newChild = new frmDocument();
                newChild.MdiParent = this;
                newChild.WindowState = FormWindowState.Maximized;
                newChild.Show();
            }
        }

        // Opens an existing file
        private void tlstrpmnuitemOpen_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                DialogResult resDialog;
                resDialog = MessageBox.Show("Do you want save the current file?", "FilePad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if ( resDialog == DialogResult.Yes)
                {
                   Form activeChild = this.ActiveMdiChild;
                   tlstrpmnuitemSave_Click(sender,e);
                   tlstrpmnuitemClose_Click(sender,e);
                   tlstrpmnuitemOpen_Click(sender, e);
                }
                else if (resDialog == DialogResult.No)
                {
                    tlstrpmnuitemClose_Click(sender, e);
                    tlstrpmnuitemOpen_Click(sender, e);
                }
            }
            else
            {
                OpenFileDialog odlgOpenFile = new OpenFileDialog();
                odlgOpenFile.InitialDirectory = "C:\\";
                odlgOpenFile.Title = "Open File";
                odlgOpenFile.Filter = "FilePad files (*.fp)|*.fp|All files (*.*)|*.*";
                if (odlgOpenFile.ShowDialog() == DialogResult.OK)
                {
                    frmDocument newChild = new frmDocument();
                    newChild.MdiParent = this;
                    newChild.WindowState = FormWindowState.Maximized;
                    newChild.Show();
                    Form activeChild = this.ActiveMdiChild;

                    if (activeChild != null)
                    {
                            RichTextBox rtbContent = (RichTextBox)activeChild.ActiveControl;
                            if (rtbContent != null)
                            {
                                strText = odlgOpenFile.FileName;
                                fsFile = new FileStream(strText, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                                srFileRead = new StreamReader(fsFile);
                                rtbContent.Text = srFileRead.ReadToEnd();
                                srFileRead.Close();
                                fsFile.Close();
                            }
                      
                    }
                    activeChild.Text = odlgOpenFile.FileName;
                }
            }
        }

        // Saves a file
        private void tlstrpmnuitemSave_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                Form activeChild = this.ActiveMdiChild;
                if (activeChild.Text == "New Document")
                {
                    SaveFileDialog sdlgFilePad = new SaveFileDialog();
                    sdlgFilePad.Title = "Save File";
                    sdlgFilePad.Filter = "FilePad files (*.fp)|*.fp|All files (*.*)|*.*";
                    if (sdlgFilePad.ShowDialog() == DialogResult.OK)
                    {

                        if (activeChild != null)
                        {
                            RichTextBox rtbContent = (RichTextBox)activeChild.ActiveControl;
                            if (rtbContent != null)
                            {
                                strText = sdlgFilePad.FileName;
                                fsFile = new FileStream(strText, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                                swFileWrite = new StreamWriter(fsFile);
                                swFileWrite.WriteLine(rtbContent.Text);
                                swFileWrite.Close();
                                fsFile.Close();

                            }
                            activeChild.Text = sdlgFilePad.FileName;
                        }
                    }
                }
                else
                {
                    if (activeChild != null)
                    {
                        RichTextBox rtbContent = (RichTextBox)activeChild.ActiveControl;
                        if (rtbContent != null)
                        {
                            fsFile = new FileStream(strText, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                            swFileWrite = new StreamWriter(fsFile);
                            swFileWrite.WriteLine(rtbContent.Text);
                            swFileWrite.Close();
                            fsFile.Close();
                        }
                    }
                }
            }
        }

        // Closes the child window
        private void tlstrpmnuitemClose_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (this.MdiChildren.Length > 0)
            {
                activeChild.Dispose();
            }
        }

        // Closes the application
        private void tlstrpmnuitemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Toggles the status bar
        private void tlstrpmnuitemStatusBar_Click(object sender, EventArgs e)
        {
            if (ststrpFilePad.Visible == true)
            {
                ststrpFilePad.Visible = false;
            }
            else
            {
                ststrpFilePad.Visible = true;
            }
        }

        // Toggles the tool bar
        private void tlstrpmnuitemToolBar_Click(object sender, EventArgs e)
        {
            if (tlstrpFilePad.Visible == true)
            {
                tlstrpFilePad.Visible = false;
            }
            else
            {
                tlstrpFilePad.Visible = true;
            }
        }

        // Opens a dialog box
        private void tlstrpmnuitemAboutUs_Click(object sender, EventArgs e)
        {
            frmAboutUs dlgAbout = new frmAboutUs();
            dlgAbout.ShowDialog();
        }

        // Displays the status on the status bar
        private void tlstrpmnuitemNew_MouseMove(object sender, MouseEventArgs e)
        {
            stlblStatus.Text = tlstrpmnuitemNew.ToolTipText;
        }

        // Displays the status on the status bar
        private void tlstrpmnuitemOpen_MouseMove(object sender, MouseEventArgs e)
        {
            stlblStatus.Text = tlstrpmnuitemOpen.ToolTipText;
        }

        // Displays the status on the status bar
        private void tlstrpmnuitemSave_MouseMove(object sender, MouseEventArgs e)
        {
            stlblStatus.Text = tlstrpmnuitemSave.ToolTipText;
        }

        // Displays the status on the status bar
        private void tlstrpmnuitemClose_MouseMove(object sender, MouseEventArgs e)
        {
            stlblStatus.Text = mnuitemClose.ToolTipText;
        }

        // Displays the status on the status bar
        private void tlstrpmnuitemExit_MouseMove(object sender, MouseEventArgs e)
        {
            stlblStatus.Text = tlstrpmnuitemExit.ToolTipText;
        }

        // Displays the status on the status bar
        private void tlstrpmnuitemStatusBar_MouseMove(object sender, MouseEventArgs e)
        {
            stlblStatus.Text = tlstrpmnuitemStatusBar.ToolTipText;
        }

        // Displays the status on the status bar
        private void tlstrpmnuitemToolBar_MouseMove(object sender, MouseEventArgs e)
        {
            stlblStatus.Text = tlstrpmnuitemToolBar.ToolTipText;
        }

        // Displays the status on the status bar
        private void tlstrpmnuitemAboutUs_MouseMove(object sender, MouseEventArgs e)
        {
            stlblStatus.Text = tlstrpmnuitemAboutUs.ToolTipText;
        }

        // Displays the status on the status bar
        private void tlstrpmnuitemFile_MouseHover(object sender, EventArgs e)
        {
            stlblStatus.Text = tlstrpmnuitemFile.ToolTipText;
        }

        // Displays the status on the status bar
        private void tlstrpmnuitemOptions_MouseHover(object sender, EventArgs e)
        {
            stlblStatus.Text = tlstrpmnuitemOptions.ToolTipText;
        }

        // Displays the status on the status bar
        private void tlstrpmnuitemHelp_MouseHover(object sender, EventArgs e)
        {
            stlblStatus.Text = tlstrpmnuitemHelp.ToolTipText;
        }

        // Opens a new file
        private void tlstrpbtnNew_Click(object sender, EventArgs e)
        {
            tlstrpmnuitemNew_Click(sender, e);
        }

        // Opens an existing file
        private void tlstrpbtnOpen_Click(object sender, EventArgs e)
        {
            tlstrpmnuitemOpen_Click(sender, e);
        }

        // Saves a file
        private void tlstrpbtnSave_Click(object sender, EventArgs e)
        {
            tlstrpmnuitemSave_Click(sender, e);
        }

        // Opens a dialog box
        private void tlstrpbtnHelp_Click(object sender, EventArgs e)
        {
            tlstrpmnuitemAboutUs_Click(sender, e);
        }
    }
}