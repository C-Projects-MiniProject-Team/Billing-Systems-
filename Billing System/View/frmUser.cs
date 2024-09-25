using Billing_System.Model;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System.View
{
    public partial class frmUser : SampleView
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            LoadData();


        }

        private async void LoadData()
        {
            string qry = @"Select ROW_NUMBER() OVER(ORDER BY userID) AS 'Sr#', userID, uName 'Name', uUser 'Role',uPass 'Password', uPhone 'Phone', uEmail 'Email' 
               from tbluser where uName like '%" + txtSearch.Text + "%' order by userID";

            DataTable dt = null;

            // Run the data-fetching task asynchronously
            await Task.Run(() =>
            {
                // Fetch data in the background thread
                dt = MainClass.Functions.GetData(qry);
            });

            // Update the DataGridView on the UI thread
            if (guna2DataGridView1.InvokeRequired)
            {
                guna2DataGridView1.Invoke((MethodInvoker)delegate
                {
                    guna2DataGridView1.DataSource = dt;
                    SetSrColumnWidth(); // Call this after data is loaded
                });
            }
            else
            {
                guna2DataGridView1.DataSource = dt;
                SetSrColumnWidth(); // Call this after data is loaded
            }
        }

        // Method to adjust the "Sr" column width
        private void SetSrColumnWidth()
        {
            if (guna2DataGridView1.Columns["Sr#"] != null)
            {
                guna2DataGridView1.Columns["Sr#"].Width = 80; // Set the width of "Sr" to 30 pixels
            }
            // Adjust the "userID" column width
            if (guna2DataGridView1.Columns["userID"] != null)
            {
                guna2DataGridView1.Columns["userID"].Width = 80; // Set the width of "userID" to 50 pixels (adjust as needed)
            }
        }







        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
        public override void btnAdd_Click(object sender, EventArgs e)
        {

            new frmUserAdd().ShowDialog();
            LoadData();
        }

        public override void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[1].Value);
            new frmUserAdd() { editID = id }.ShowDialog();
            LoadData();
        }
    }
}
