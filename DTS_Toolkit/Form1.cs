using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;
using System.Management;



namespace DTS_Toolkit
{
    public partial class Form1 : Form
    {
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
            DirectoryEntry deRoot = new DirectoryEntry("LDAP://afni.net");
            DirectorySearcher dsFindUser = new DirectorySearcher(deRoot);
            dsFindUser.Filter = "(&(objectClass=user)(samaccountname="+ searchName +"))";
            dsFindUser.SearchScope = SearchScope.Subtree;
            SearchResult result = dsFindUser.FindOne();


            if (result.GetDirectoryEntry().Properties["mail"].Value.ToString() != null)
            {

                 // Get Manager Name and Strip other info
                String managerName = result.GetDirectoryEntry().Properties["manager"].Value.ToString();

                var managerEdited = managerName.Split(',').Select(pair => pair.Split('=').LastOrDefault()).ToArray().GetValue(0);

                txtName.Text = result.GetDirectoryEntry().Properties["givenname"].Value.ToString() + " " + result.GetDirectoryEntry().Properties["sn"].Value.ToString();
                txtSupervisor.Text = managerEdited.ToString();
                txtLocation.Text = result.GetDirectoryEntry().Properties["l"].Value.ToString();
                txtHome.Text = result.GetDirectoryEntry().Properties["homeDirectory"].Value.ToString();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConnectionOptions connection = new ConnectionOptions();
            connection.Impersonation = ImpersonationLevel.Impersonate;
            ManagementScope scope = new ManagementScope(@"\\" + txtHostName.Text + @"\root\cimv2", connection);
            scope.Connect();

            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);

            foreach (ManagementObject queryObj in searcher.Get())
            {
                txtRAM.Text = queryObj["TotalVisibleMemorySize"].ToString();
            }
            


        }
    }
}
