namespace DTS_Toolkit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHome = new System.Windows.Forms.TextBox();
            this.lblHome = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtSupervisor = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPSID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearchedName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtImportLoc = new System.Windows.Forms.TextBox();
            this.btnImportNames = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBIOSVer = new System.Windows.Forms.TextBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMAC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtManf = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(596, 255);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(588, 229);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "AD Tools";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtSearchedName);
            this.groupBox1.Location = new System.Drawing.Point(0, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Lookup";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtHome);
            this.panel1.Controls.Add(this.lblHome);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtStatus);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtDepartment);
            this.panel1.Controls.Add(this.txtSupervisor);
            this.panel1.Controls.Add(this.txtLocation);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPSID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 165);
            this.panel1.TabIndex = 5;
            // 
            // txtHome
            // 
            this.txtHome.Location = new System.Drawing.Point(67, 82);
            this.txtHome.Name = "txtHome";
            this.txtHome.ReadOnly = true;
            this.txtHome.Size = new System.Drawing.Size(478, 20);
            this.txtHome.TabIndex = 27;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Location = new System.Drawing.Point(-3, 85);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(70, 13);
            this.lblHome.TabIndex = 26;
            this.lblHome.Text = "Home Folder:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(452, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Reset Password";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Unlock Account";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(92, 128);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(243, 20);
            this.txtStatus.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Account Status:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(295, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Department:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(300, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Supervisor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Location:";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(366, 55);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(179, 20);
            this.txtDepartment.TabIndex = 15;
            // 
            // txtSupervisor
            // 
            this.txtSupervisor.Location = new System.Drawing.Point(366, 29);
            this.txtSupervisor.Name = "txtSupervisor";
            this.txtSupervisor.ReadOnly = true;
            this.txtSupervisor.Size = new System.Drawing.Size(179, 20);
            this.txtSupervisor.TabIndex = 14;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(366, 6);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(179, 20);
            this.txtLocation.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(68, 55);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(201, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email:";
            // 
            // txtPSID
            // 
            this.txtPSID.Location = new System.Drawing.Point(68, 29);
            this.txtPSID.Name = "txtPSID";
            this.txtPSID.ReadOnly = true;
            this.txtPSID.Size = new System.Drawing.Size(202, 20);
            this.txtPSID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "PSID:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 3);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(202, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearchedName
            // 
            this.txtSearchedName.AcceptsReturn = true;
            this.txtSearchedName.Location = new System.Drawing.Point(8, 16);
            this.txtSearchedName.Name = "txtSearchedName";
            this.txtSearchedName.Size = new System.Drawing.Size(179, 20);
            this.txtSearchedName.TabIndex = 1;
            this.txtSearchedName.Text = "Name";
            this.txtSearchedName.TextChanged += new System.EventHandler(this.txtSearchedName_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(588, 229);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mapping Tools";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(588, 229);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Other Tools";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage4.Controls.Add(this.txtImportLoc);
            this.tabPage4.Controls.Add(this.btnImportNames);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.txtUser);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.txtBIOSVer);
            this.tabPage4.Controls.Add(this.txtSerial);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.txtMAC);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.txtManf);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.txtModel);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.txtIP);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.txtRAM);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.txtHostName);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(588, 229);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "PC Info";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // txtImportLoc
            // 
            this.txtImportLoc.Location = new System.Drawing.Point(376, 6);
            this.txtImportLoc.Name = "txtImportLoc";
            this.txtImportLoc.ReadOnly = true;
            this.txtImportLoc.Size = new System.Drawing.Size(100, 20);
            this.txtImportLoc.TabIndex = 19;
            // 
            // btnImportNames
            // 
            this.btnImportNames.Location = new System.Drawing.Point(294, 7);
            this.btnImportNames.Name = "btnImportNames";
            this.btnImportNames.Size = new System.Drawing.Size(75, 23);
            this.btnImportNames.TabIndex = 18;
            this.btnImportNames.Text = "Import";
            this.btnImportNames.UseVisualStyleBackColor = true;
            this.btnImportNames.Click += new System.EventHandler(this.btnImportNames_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(310, 58);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "Current User:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(385, 55);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(199, 20);
            this.txtUser.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "BIOS Version:";
            // 
            // txtBIOSVer
            // 
            this.txtBIOSVer.Location = new System.Drawing.Point(80, 56);
            this.txtBIOSVer.Name = "txtBIOSVer";
            this.txtBIOSVer.ReadOnly = true;
            this.txtBIOSVer.Size = new System.Drawing.Size(112, 20);
            this.txtBIOSVer.TabIndex = 14;
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(80, 82);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.ReadOnly = true;
            this.txtSerial.Size = new System.Drawing.Size(112, 20);
            this.txtSerial.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Serial #:";
            // 
            // txtMAC
            // 
            this.txtMAC.Location = new System.Drawing.Point(80, 208);
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.ReadOnly = true;
            this.txtMAC.Size = new System.Drawing.Size(112, 20);
            this.txtMAC.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "MAC:";
            // 
            // txtManf
            // 
            this.txtManf.Location = new System.Drawing.Point(80, 108);
            this.txtManf.Name = "txtManf";
            this.txtManf.ReadOnly = true;
            this.txtManf.Size = new System.Drawing.Size(112, 20);
            this.txtManf.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Manufacturer:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(80, 134);
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(112, 20);
            this.txtModel.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Model:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(80, 184);
            this.txtIP.Name = "txtIP";
            this.txtIP.ReadOnly = true;
            this.txtIP.Size = new System.Drawing.Size(112, 20);
            this.txtIP.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "IP Addr: ";
            // 
            // txtRAM
            // 
            this.txtRAM.Location = new System.Drawing.Point(80, 159);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.ReadOnly = true;
            this.txtRAM.Size = new System.Drawing.Size(112, 20);
            this.txtRAM.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RAM:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(208, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Get Info";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtHostName
            // 
            this.txtHostName.Location = new System.Drawing.Point(10, 7);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(192, 20);
            this.txtHostName.TabIndex = 0;
            this.txtHostName.Text = "Remote PC Host Name";
            this.txtHostName.TextChanged += new System.EventHandler(this.txtHostName_TextChanged);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 255);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DTS Toolkit";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPSID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSearchedName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtSupervisor;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label13;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox txtHome;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.TextBox txtManf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMAC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBIOSVer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnImportNames;
        private System.Windows.Forms.TextBox txtImportLoc;
    }
}

