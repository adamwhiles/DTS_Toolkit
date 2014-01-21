using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;
using System.Management;
using Excel = Microsoft.Office.Interop.Excel; 



namespace DTS_Toolkit
{

    public partial class Form1 : Form
    {
         // Setup Excel Sheet Base Info
         Excel.Application xlApp;
         object misValue = System.Reflection.Missing.Value;
         Excel.Workbook xlWorkBook;
         Excel.Worksheet xlWorksheet;

        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String searchName = txtSearchedName.Text;
            //Setup LDAP to connect to AD
            DirectoryEntry deRoot = new DirectoryEntry("LDAP://afni.net");
            DirectorySearcher dsFindUser = new DirectorySearcher(deRoot);
            // Setup filter to search for name input by the user
            dsFindUser.Filter = "(&(objectClass=user)(samaccountname="+ searchName +"))";
            dsFindUser.SearchScope = SearchScope.Subtree;
            SearchResult result = dsFindUser.FindOne();

            // check if the mail property is empty because all employees have a email
            if (result.GetDirectoryEntry().Properties["mail"].Value != null)
            {

                 // Get Manager Name and Strip other info
                String managerName = result.GetDirectoryEntry().Properties["manager"].Value.ToString();

                //var managerEdited = managerName.Split(',').Select(pair => pair.Split('=').LastOrDefault()).ToArray().GetValue(0);

                txtName.Text = result.GetDirectoryEntry().Properties["givenname"].Value.ToString() + " " + result.GetDirectoryEntry().Properties["sn"].Value.ToString();
                //txtSupervisor.Text = managerEdited.ToString();
                txtLocation.Text = result.GetDirectoryEntry().Properties["l"].Value.ToString();
                if (result.GetDirectoryEntry().Properties["homeDirectory"].Value != null)
                {
                    txtHome.Text = result.GetDirectoryEntry().Properties["homeDirectory"].Value.ToString();
                }
                else { txtHome.Text = "none"; }
                txtPSID.Text = result.GetDirectoryEntry().Properties["physicalDeliveryOfficeName"].Value.ToString();
                txtDepartment.Text = result.GetDirectoryEntry().Properties["department"].Value.ToString();
                txtEmail.Text = result.GetDirectoryEntry().Properties["mail"].Value.ToString();
                if (result.GetDirectoryEntry().InvokeGet("IsAccountLocked").ToString() == "False")
                {
                    txtStatus.Text = "Active (Not Locked)";
                }
                else
                {
                    txtStatus.Text = "Account Locked";
                    
                }

            }
            else
            {
                txtEmail.Text = "null";
            }

        }

        private void txtHostName_Click(object sender, EventArgs e)
        {
            txtHostName.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtHostName.Text = txtHostName.Text.Trim();
            if (txtHostName.Text != "")
            {

                try
                {

                    //Setup WMI connection and impersonate current logged on user
                    ConnectionOptions connection = new ConnectionOptions();
                    connection.Impersonation = ImpersonationLevel.Impersonate;

                    // Connect to WMI service on remote pc based on user input of hostname
                    ManagementScope scope = new ManagementScope(@"\\" + txtHostName.Text + @"\root\cimv2", connection);
                    scope.Connect();

                    ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_ComputerSystem");
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);

                    foreach (ManagementObject queryObj in searcher.Get())
                    {
                        string manufacturer = queryObj["manufacturer"].ToString();
                        txtManf.Text = manufacturer;
                        string model = queryObj["model"].ToString();
                        txtModel.Text = model;
                        string ramCount = queryObj["TotalPhysicalMemory"].ToString();
                        txtRAM.Text = ramCount;
                        long ramCountFinal = Int64.Parse(ramCount);
                        txtRAM.Text = ((ramCountFinal / 1024) / 1024).ToString() + " MB";
                        string currentUser = "";
                        if (queryObj["UserName"] != null)
                        {
                            currentUser = queryObj["UserName"].ToString();
                        }
                        else { currentUser = "No User"; }
                        txtUser.Text = currentUser;
                    }

                    ObjectQuery query2 = new ObjectQuery("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'");
                    ManagementObjectSearcher searcher2 = new ManagementObjectSearcher(scope, query2);
                    ManagementObjectCollection queryCollection = searcher2.Get();


                    foreach (ManagementObject m in queryCollection)
                    {
                        string[] ipAddr = (string[])m["IPAddress"];
                        txtIP.Text = ipAddr[0];
                        string macAddr = m["MACAddress"].ToString();
                        txtMAC.Text = macAddr;

                    }

                    ObjectQuery query3 = new ObjectQuery("SELECT * FROM Win32_BIOS");
                    ManagementObjectSearcher searcher3 = new ManagementObjectSearcher(scope, query3);
                    ManagementObjectCollection queryCollection2 = searcher3.Get();

                    foreach (ManagementObject n in queryCollection2)
                    {
                        string serial = (String)n["SerialNumber"];
                        txtSerial.Text = serial;
                        string[] version = (string[])n["BIOSVersion"];
                        string finalVersion = version[1].Substring((version[1].Length - 3), 3);

                        txtBIOSVer.Text = finalVersion;


                    }

                }
                catch
                {
                    MessageBox.Show("Unable to Connect to WMI Service on Remote Host", "",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("Please enter a hostname.", "",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        public void btnImportNames_Click(object sender, EventArgs e)
        {
            //Setup our file dialog for import
            OpenFileDialog importDialog = new OpenFileDialog();
            importDialog.Filter = "Text Files (.txt)|*.txt";
            importDialog.FilterIndex = 1;
            importDialog.Multiselect = false;
            string line;
            // If the user selected a file read the contents and run into excel
            if (importDialog.ShowDialog() == DialogResult.OK)
            {
               
                // Read in the text file the user chose
                System.IO.StreamReader file = new System.IO.StreamReader(importDialog.FileName);
                
                List<string> lines = new List<string>(); // Build the string list
                
                // Loop through imported text file and add each line to string list
                while ((line = file.ReadLine()) != null) {
                    lines.Add(line);
                }
                file.Close(); // close our import file  
                setupSheet(); // Call setupSheet function to build the template for our output sheet in excel
                for (int i = 1; i <= lines.Count; i++) // Loop through string list with pc names and add to excel sheet
                {

                    getPCInfo(lines[i - 1], i+1); // send the pc name and index to getPCInfo function that will query WMI
                }
            }
        }

        public void setupSheet()
        {
            // Setup Excel Sheet
            xlApp = new Excel.Application();
            xlApp.Visible = true;
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorksheet = (Excel.Worksheet)xlWorkBook.Sheets[1];
            xlWorksheet.Cells[1, 1] = "Machine Name";
            xlWorksheet.Cells[1, 2] = "Manufacturer";
            xlWorksheet.Cells[1, 3] = "Model";
            xlWorksheet.Cells[1, 4] = "Physical Memory";
            xlWorksheet.Cells[1, 5] = "IP Address";
            xlWorksheet.Cells[1, 6] = "MAC Address";
            xlWorksheet.Cells[1, 7] = "Serial Number";
            xlWorksheet.Cells[1, 8] = "BIOS Version";
            var range = xlWorksheet.get_Range("A1", "H1");
            range.Select();
            range.Font.Bold = true;
            range.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkOrange);
            
        }


        public void getPCInfo(string pcName, int index)
        {
            if (pcName != null)
            {

                try
                {
                    ConnectionOptions connection = new ConnectionOptions();
                    connection.Impersonation = ImpersonationLevel.Impersonate;
                    ManagementScope scope = new ManagementScope(@"\\" + pcName + @"\root\cimv2", connection);
                    scope.Connect();

                    ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_ComputerSystem");
                    ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);

                    foreach (ManagementObject queryObj in searcher.Get())
                    {

                        xlWorksheet.Cells[index, 1] = pcName;
                        string manufacturer = queryObj["manufacturer"].ToString();
                        xlWorksheet.Cells[index, 2] = manufacturer;
                        string model = queryObj["model"].ToString();
                        xlWorksheet.Cells[index, 3] = model;
                        string ramCount = queryObj["TotalPhysicalMemory"].ToString();
                        long ramCountFinal = Int64.Parse(ramCount);
                        xlWorksheet.Cells[index, 4] = ((ramCountFinal / 1024) / 1024).ToString() + " MB";
                    }

                    ObjectQuery query2 = new ObjectQuery("SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = 'TRUE'");
                    ManagementObjectSearcher searcher2 = new ManagementObjectSearcher(scope, query2);
                    ManagementObjectCollection queryCollection = searcher2.Get();


                    foreach (ManagementObject m in queryCollection)
                    {
                        string[] ipAddr = (string[])m["IPAddress"];
                        xlWorksheet.Cells[index, 5] = ipAddr[0];
                        string macAddr = m["MACAddress"].ToString();
                        xlWorksheet.Cells[index, 6] = macAddr;

                    }

                    ObjectQuery query3 = new ObjectQuery("SELECT * FROM Win32_BIOS");
                    ManagementObjectSearcher searcher3 = new ManagementObjectSearcher(scope, query3);
                    ManagementObjectCollection queryCollection2 = searcher3.Get();

                    foreach (ManagementObject n in queryCollection2)
                    {
                        string serial = (String)n["SerialNumber"];
                        xlWorksheet.Cells[index, 7] = serial;
                        string[] version = (string[])n["BIOSVersion"];
                        string finalVersion = version[1].Substring((version[1].Length - 3), 3);
                        xlWorksheet.Cells[index, 8] = finalVersion;
                        xlWorksheet.Cells.EntireColumn.AutoFit();
                    }

                }
                catch
                {
                    MessageBox.Show("Unable to Connect to WMI Service on Remote Host", "",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("No hostnames were imported, please check you txt file to remove any white space and put one hostname on each line.", "",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }


        }

        private void txtSearchedName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHostName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
