using Billing_System.Model;
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
    public partial class frmPayment : SampleView
    {
        public frmPayment()
        {
            InitializeComponent();
        }



        private void frmPayment_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string searchValue = txtSearch.Text; // txtSearch.Text 
            string qry = $@"Select 0 'Sr', payID, mainID 'Payment Date', sName 'Supplier Name', 
                    description 'Description', NetAmount 'Amount' 
                    from tblSupplier
                    inner join tblPayment on PersonID = supID
                    where sName like '%{searchValue}%' order by payID";
            
            MainClass.Functions.LoadData_Payment(qry, guna2DataGridView1);
        }


        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            new frmPaymentAdd().ShowDialog();
            LoadData();
        }

        public override void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[1].Value);
            new frmPaymentAdd() { editID = id }.ShowDialog();
            LoadData();
        }


    }
}
