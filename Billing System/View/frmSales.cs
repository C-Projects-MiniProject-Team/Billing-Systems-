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
    public partial class frmSales : SampleView
    {
        public frmSales()
        {
            InitializeComponent();
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()

        {
            
            string qry = @"Select 0 'Sr' , mainID , mdate 'Date' , mDueDate 'Due Date', s.cName 'Customer Name' , 
                    mTotal 'Gross Amount' , Discount , NetAmount 'Net Amount' 
                    from tblInvMain m 
                    inner join tblCustomer s on m.PersonID = s.cusID 
                    where mType = 'Retail' and 
                    cName like '%" + txtSearch.Text + "%' order by mainID";
            MainClass.Functions.LoadData_Sales(qry, guna2DataGridView1);
         
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            new frmSaleAdd().ShowDialog();
           //LoadData();
        }

        public override void guna2DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (guna2DataGridView1.CurrentRow != null && guna2DataGridView1.CurrentRow.Cells[1].Value != null)
            {
                int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells[1].Value);
                new frmSaleAdd() { editID = id }.ShowDialog();
                LoadData();
            }
            else
            {
                MessageBox.Show("No row is selected or the data is not loaded correctly.");
            }
        }

    }
}
