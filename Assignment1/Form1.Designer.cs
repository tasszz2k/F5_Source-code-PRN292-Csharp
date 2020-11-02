namespace Assignment1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxLanaguage = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnYes = new System.Windows.Forms.RadioButton();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbxCode = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxCode);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAddNew);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.nudPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbxLanaguage);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbxTitle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 525);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "DVD Catalog";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "DVD Code Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "DVD Title:";
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(189, 127);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(218, 22);
            this.tbxTitle.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Language:";
            // 
            // cbxLanaguage
            // 
            this.cbxLanaguage.FormattingEnabled = true;
            this.cbxLanaguage.Location = new System.Drawing.Point(189, 173);
            this.cbxLanaguage.Name = "cbxLanaguage";
            this.cbxLanaguage.Size = new System.Drawing.Size(218, 24);
            this.cbxLanaguage.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price:";
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(189, 223);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(76, 22);
            this.nudPrice.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Dollars";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnNo);
            this.groupBox1.Controls.Add(this.rbtnYes);
            this.groupBox1.Location = new System.Drawing.Point(25, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 81);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subtitles";
            // 
            // rbtnYes
            // 
            this.rbtnYes.AutoSize = true;
            this.rbtnYes.Location = new System.Drawing.Point(44, 37);
            this.rbtnYes.Name = "rbtnYes";
            this.rbtnYes.Size = new System.Drawing.Size(53, 21);
            this.rbtnYes.TabIndex = 0;
            this.rbtnYes.TabStop = true;
            this.rbtnYes.Text = "Yes";
            this.rbtnYes.UseVisualStyleBackColor = true;
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Location = new System.Drawing.Point(253, 37);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(47, 21);
            this.rbtnNo.TabIndex = 1;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(25, 392);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 11;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(170, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(332, 392);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(100, 449);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(250, 449);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // cbxCode
            // 
            this.cbxCode.FormattingEnabled = true;
            this.cbxCode.Location = new System.Drawing.Point(189, 82);
            this.cbxCode.Name = "cbxCode";
            this.cbxCode.Size = new System.Drawing.Size(218, 24);
            this.cbxCode.TabIndex = 16;
            this.cbxCode.SelectedIndexChanged += new System.EventHandler(this.cbxCode_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 549);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "DVD Catalog";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxCode;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.RadioButton rbtnYes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxLanaguage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

