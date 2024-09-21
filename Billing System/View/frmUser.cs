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

        private void LoadData()
        {
            string qry = @"Select 0 'Sr', userID, uName 'Name', uUser 'username', uPhone 'Phone', uEmail 'Email' from tbluser where uName like '%" + txtSearch.Text + "%' order by userID";
            MainClass.Functions.LoadData(qry, guna2DataGridView1);
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
            new frmUserAdd() { editID = id}.ShowDialog();
            LoadData();
        }
    }
}
