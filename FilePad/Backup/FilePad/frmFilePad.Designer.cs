/*
 * frmFilePad.Designer.cs
 * 
 * Copyright © 2007 Aptech Software Limited. All rights reserved.
 */

namespace FilePad
{
    partial class frmFilePad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ststrpFilePad = new System.Windows.Forms.StatusStrip();
            this.stlblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnustrpFilePad = new System.Windows.Forms.MenuStrip();
            this.tlstrpmnuitemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpSeperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuitemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpSeperator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tlstrpmnuitemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemToolBar = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpmnuitemAboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstrpFilePad = new System.Windows.Forms.ToolStrip();
            this.tlstrpbtnNew = new System.Windows.Forms.ToolStripButton();
            this.tlstrpbtnOpen = new System.Windows.Forms.ToolStripButton();
            this.tlstrpbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tlstrpSeperator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.ststrpFilePad.SuspendLayout();
            this.mnustrpFilePad.SuspendLayout();
            this.tlstrpFilePad.SuspendLayout();
            this.SuspendLayout();
            // 
            // ststrpFilePad
            // 
            this.ststrpFilePad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlblStatus});
            this.ststrpFilePad.Location = new System.Drawing.Point(0, 276);
            this.ststrpFilePad.Name = "ststrpFilePad";
            this.ststrpFilePad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ststrpFilePad.ShowItemToolTips = true;
            this.ststrpFilePad.Size = new System.Drawing.Size(433, 22);
            this.ststrpFilePad.TabIndex = 1;
            this.ststrpFilePad.Text = "StatusBar";
            // 
            // stlblStatus
            // 
            this.stlblStatus.AutoSize = false;
            this.stlblStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.stlblStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.stlblStatus.Name = "stlblStatus";
            this.stlblStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stlblStatus.Size = new System.Drawing.Size(418, 17);
            this.stlblStatus.Spring = true;
            this.stlblStatus.Text = "Status";
            this.stlblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnustrpFilePad
            // 
            this.mnustrpFilePad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpmnuitemFile,
            this.tlstrpmnuitemOptions,
            this.tlstrpmnuitemHelp});
            this.mnustrpFilePad.Location = new System.Drawing.Point(0, 0);
            this.mnustrpFilePad.Name = "mnustrpFilePad";
            this.mnustrpFilePad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnustrpFilePad.Size = new System.Drawing.Size(433, 24);
            this.mnustrpFilePad.TabIndex = 2;
            this.mnustrpFilePad.Text = "menuStrip1";
            // 
            // tlstrpmnuitemFile
            // 
            this.tlstrpmnuitemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpmnuitemNew,
            this.tlstrpmnuitemOpen,
            this.tlstrpmnuitemSave,
            this.tlstrpSeperator1,
            this.mnuitemClose,
            this.tlstrpSeperator3,
            this.tlstrpmnuitemExit});
            this.tlstrpmnuitemFile.Name = "tlstrpmnuitemFile";
            this.tlstrpmnuitemFile.Size = new System.Drawing.Size(35, 20);
            this.tlstrpmnuitemFile.Text = "&File";
            this.tlstrpmnuitemFile.ToolTipText = "Contains commands for working with the document";
            this.tlstrpmnuitemFile.MouseHover += new System.EventHandler(this.tlstrpmnuitemFile_MouseHover);
            // 
            // tlstrpmnuitemNew
            // 
            this.tlstrpmnuitemNew.Name = "tlstrpmnuitemNew";
            this.tlstrpmnuitemNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tlstrpmnuitemNew.Size = new System.Drawing.Size(155, 22);
            this.tlstrpmnuitemNew.Text = "&New";
            this.tlstrpmnuitemNew.ToolTipText = "Create new document";
            this.tlstrpmnuitemNew.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlstrpmnuitemNew_MouseMove);
            this.tlstrpmnuitemNew.Click += new System.EventHandler(this.tlstrpmnuitemNew_Click);
            // 
            // tlstrpmnuitemOpen
            // 
            this.tlstrpmnuitemOpen.Name = "tlstrpmnuitemOpen";
            this.tlstrpmnuitemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tlstrpmnuitemOpen.Size = new System.Drawing.Size(155, 22);
            this.tlstrpmnuitemOpen.Text = "&Open";
            this.tlstrpmnuitemOpen.ToolTipText = "Open an existing document";
            this.tlstrpmnuitemOpen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlstrpmnuitemOpen_MouseMove);
            this.tlstrpmnuitemOpen.Click += new System.EventHandler(this.tlstrpmnuitemOpen_Click);
            // 
            // tlstrpmnuitemSave
            // 
            this.tlstrpmnuitemSave.Name = "tlstrpmnuitemSave";
            this.tlstrpmnuitemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tlstrpmnuitemSave.Size = new System.Drawing.Size(155, 22);
            this.tlstrpmnuitemSave.Text = "&Save";
            this.tlstrpmnuitemSave.ToolTipText = "Save a document";
            this.tlstrpmnuitemSave.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlstrpmnuitemSave_MouseMove);
            this.tlstrpmnuitemSave.Click += new System.EventHandler(this.tlstrpmnuitemSave_Click);
            // 
            // tlstrpSeperator1
            // 
            this.tlstrpSeperator1.Name = "tlstrpSeperator1";
            this.tlstrpSeperator1.Size = new System.Drawing.Size(152, 6);
            // 
            // mnuitemClose
            // 
            this.mnuitemClose.Name = "mnuitemClose";
            this.mnuitemClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.mnuitemClose.Size = new System.Drawing.Size(155, 22);
            this.mnuitemClose.Text = "&Close";
            this.mnuitemClose.ToolTipText = "Close a current document";
            this.mnuitemClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlstrpmnuitemClose_MouseMove);
            this.mnuitemClose.Click += new System.EventHandler(this.tlstrpmnuitemClose_Click);
            // 
            // tlstrpSeperator3
            // 
            this.tlstrpSeperator3.Name = "tlstrpSeperator3";
            this.tlstrpSeperator3.Size = new System.Drawing.Size(152, 6);
            // 
            // tlstrpmnuitemExit
            // 
            this.tlstrpmnuitemExit.Name = "tlstrpmnuitemExit";
            this.tlstrpmnuitemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tlstrpmnuitemExit.Size = new System.Drawing.Size(155, 22);
            this.tlstrpmnuitemExit.Text = "E&xit";
            this.tlstrpmnuitemExit.ToolTipText = "Exit FilePad";
            this.tlstrpmnuitemExit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlstrpmnuitemExit_MouseMove);
            this.tlstrpmnuitemExit.Click += new System.EventHandler(this.tlstrpmnuitemExit_Click);
            // 
            // tlstrpmnuitemOptions
            // 
            this.tlstrpmnuitemOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpmnuitemStatusBar,
            this.tlstrpmnuitemToolBar});
            this.tlstrpmnuitemOptions.Name = "tlstrpmnuitemOptions";
            this.tlstrpmnuitemOptions.Size = new System.Drawing.Size(56, 20);
            this.tlstrpmnuitemOptions.Text = "&Options";
            this.tlstrpmnuitemOptions.ToolTipText = "Contains commands for toggling statusbar and toolbar";
            this.tlstrpmnuitemOptions.MouseHover += new System.EventHandler(this.tlstrpmnuitemOptions_MouseHover);
            // 
            // tlstrpmnuitemStatusBar
            // 
            this.tlstrpmnuitemStatusBar.Checked = true;
            this.tlstrpmnuitemStatusBar.CheckOnClick = true;
            this.tlstrpmnuitemStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tlstrpmnuitemStatusBar.Name = "tlstrpmnuitemStatusBar";
            this.tlstrpmnuitemStatusBar.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.tlstrpmnuitemStatusBar.Size = new System.Drawing.Size(151, 22);
            this.tlstrpmnuitemStatusBar.Text = "&Statusbar";
            this.tlstrpmnuitemStatusBar.ToolTipText = "Toggle Status bar";
            this.tlstrpmnuitemStatusBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlstrpmnuitemStatusBar_MouseMove);
            this.tlstrpmnuitemStatusBar.Click += new System.EventHandler(this.tlstrpmnuitemStatusBar_Click);
            // 
            // tlstrpmnuitemToolBar
            // 
            this.tlstrpmnuitemToolBar.Checked = true;
            this.tlstrpmnuitemToolBar.CheckOnClick = true;
            this.tlstrpmnuitemToolBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tlstrpmnuitemToolBar.Name = "tlstrpmnuitemToolBar";
            this.tlstrpmnuitemToolBar.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.tlstrpmnuitemToolBar.Size = new System.Drawing.Size(151, 22);
            this.tlstrpmnuitemToolBar.Text = "&Toolbar";
            this.tlstrpmnuitemToolBar.ToolTipText = "Toggle Tool Bar";
            this.tlstrpmnuitemToolBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlstrpmnuitemToolBar_MouseMove);
            this.tlstrpmnuitemToolBar.Click += new System.EventHandler(this.tlstrpmnuitemToolBar_Click);
            // 
            // tlstrpmnuitemHelp
            // 
            this.tlstrpmnuitemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpmnuitemAboutUs});
            this.tlstrpmnuitemHelp.Name = "tlstrpmnuitemHelp";
            this.tlstrpmnuitemHelp.Size = new System.Drawing.Size(40, 20);
            this.tlstrpmnuitemHelp.Text = "&Help";
            this.tlstrpmnuitemHelp.ToolTipText = "Contains About Us command";
            this.tlstrpmnuitemHelp.MouseHover += new System.EventHandler(this.tlstrpmnuitemHelp_MouseHover);
            // 
            // tlstrpmnuitemAboutUs
            // 
            this.tlstrpmnuitemAboutUs.Name = "tlstrpmnuitemAboutUs";
            this.tlstrpmnuitemAboutUs.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tlstrpmnuitemAboutUs.Size = new System.Drawing.Size(148, 22);
            this.tlstrpmnuitemAboutUs.Text = "&About Us";
            this.tlstrpmnuitemAboutUs.ToolTipText = "About FilePad";
            this.tlstrpmnuitemAboutUs.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlstrpmnuitemAboutUs_MouseMove);
            this.tlstrpmnuitemAboutUs.Click += new System.EventHandler(this.tlstrpmnuitemAboutUs_Click);
            // 
            // tlstrpFilePad
            // 
            this.tlstrpFilePad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrpbtnNew,
            this.tlstrpbtnOpen,
            this.tlstrpbtnSave,
            this.tlstrpSeperator2,
            this.btnHelp});
            this.tlstrpFilePad.Location = new System.Drawing.Point(0, 24);
            this.tlstrpFilePad.Name = "tlstrpFilePad";
            this.tlstrpFilePad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tlstrpFilePad.Size = new System.Drawing.Size(433, 25);
            this.tlstrpFilePad.TabIndex = 3;
            this.tlstrpFilePad.Text = "ToolBar";
            // 
            // tlstrpbtnNew
            // 
            this.tlstrpbtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlstrpbtnNew.Image = global::FilePad.Properties.Resources.New;
            this.tlstrpbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlstrpbtnNew.Name = "tlstrpbtnNew";
            this.tlstrpbtnNew.Size = new System.Drawing.Size(23, 22);
            this.tlstrpbtnNew.Text = "New";
            this.tlstrpbtnNew.Click += new System.EventHandler(this.tlstrpbtnNew_Click);
            // 
            // tlstrpbtnOpen
            // 
            this.tlstrpbtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlstrpbtnOpen.Image = global::FilePad.Properties.Resources.Open;
            this.tlstrpbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlstrpbtnOpen.Name = "tlstrpbtnOpen";
            this.tlstrpbtnOpen.Size = new System.Drawing.Size(23, 22);
            this.tlstrpbtnOpen.Text = "Open";
            this.tlstrpbtnOpen.Click += new System.EventHandler(this.tlstrpbtnOpen_Click);
            // 
            // tlstrpbtnSave
            // 
            this.tlstrpbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlstrpbtnSave.Image = global::FilePad.Properties.Resources.Save;
            this.tlstrpbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlstrpbtnSave.Name = "tlstrpbtnSave";
            this.tlstrpbtnSave.Size = new System.Drawing.Size(23, 22);
            this.tlstrpbtnSave.Text = "Save";
            this.tlstrpbtnSave.Click += new System.EventHandler(this.tlstrpbtnSave_Click);
            // 
            // tlstrpSeperator2
            // 
            this.tlstrpSeperator2.Name = "tlstrpSeperator2";
            this.tlstrpSeperator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnHelp
            // 
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHelp.Image = global::FilePad.Properties.Resources.Help;
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(23, 22);
            this.btnHelp.Text = "Help";
            this.btnHelp.Click += new System.EventHandler(this.tlstrpbtnHelp_Click);
            // 
            // frmFilePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 298);
            this.Controls.Add(this.tlstrpFilePad);
            this.Controls.Add(this.ststrpFilePad);
            this.Controls.Add(this.mnustrpFilePad);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnustrpFilePad;
            this.MaximizeBox = false;
            this.Name = "frmFilePad";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "FilePad";
            this.Load += new System.EventHandler(this.frmFilePad_Load);
            this.ststrpFilePad.ResumeLayout(false);
            this.ststrpFilePad.PerformLayout();
            this.mnustrpFilePad.ResumeLayout(false);
            this.mnustrpFilePad.PerformLayout();
            this.tlstrpFilePad.ResumeLayout(false);
            this.tlstrpFilePad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ststrpFilePad;
        private System.Windows.Forms.MenuStrip mnustrpFilePad;
        private System.Windows.Forms.ToolStrip tlstrpFilePad;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemFile;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemNew;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemOpen;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemSave;
        private System.Windows.Forms.ToolStripSeparator tlstrpSeperator1;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemExit;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemOptions;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemStatusBar;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemToolBar;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemHelp;
        private System.Windows.Forms.ToolStripMenuItem tlstrpmnuitemAboutUs;
        private System.Windows.Forms.ToolStripStatusLabel stlblStatus;
        private System.Windows.Forms.ToolStripButton tlstrpbtnNew;
        private System.Windows.Forms.ToolStripButton tlstrpbtnOpen;
        private System.Windows.Forms.ToolStripButton tlstrpbtnSave;
        private System.Windows.Forms.ToolStripSeparator tlstrpSeperator2;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuitemClose;
        private System.Windows.Forms.ToolStripSeparator tlstrpSeperator3;
    }
}

