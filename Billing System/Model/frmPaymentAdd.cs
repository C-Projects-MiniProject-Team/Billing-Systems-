using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System.Model
{
    public partial class frmPaymentAdd : SampleAdd
    {
        public frmPaymentAdd()
        {
            InitializeComponent();
        }

        private void mdate_TextChanged(object sender, EventArgs e)
        {
           // MainClass.Functions.Maskd(mdate);
        }

        private void frmPaymentAdd_Load(object sender, EventArgs e)
        {
          

           /*PersonID.SelectedIndexChanged -= PersonID_SelectedIndexChanged;

            string qry = "Select supID 'id' , sName 'name' from tblSupplier ";
            MainClass.Functions.CBFill(qry, PersonID);

            
            if (editID>0)
            {
                MainClass.Functions.AutoLoadForEdit(this, "tblPayment", editID);
            }
            
            PersonID.SelectedIndexChanged += PersonID_SelectedIndexChanged;*/

        }

        private void PersonID_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* int partyID = 0;
            if (PersonID.SelectedIndex == -1)
            {
                partyID = 0;
            }
            else
            {
                partyID = Convert.ToInt32(PersonID.SelectedValue);
            }

            string qry = @"select 0 'Sr#', m.mainID, m.mTotal 'Invoice Amount', 
               (Select ISNULL(sum(p.NetAmount),0) from tblPayment p where p.mainID = m.mainID) 'Payment', 
               m.mTotal - (Select ISNULL(sum(p.NetAmount),0) from tblPayment p where p.mainID = m.mainID) 'Balance' 
               from tblInvMain m 
               where m.mTotal - (Select ISNULL(sum(p.NetAmount),0) from tblPayment p where p.mainID = m.mainID) <> 0";

            MainClass.Functions.LoadData(qry, guna2DataGridView1);*/

        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int row = guna2DataGridView1.CurrentCell.RowIndex;
                mainID.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            }

        }


        public override void btnSave_Click(object sender, EventArgs e)
        {

           /* if (mainID.Text == "0")
            {
                MessageBox.Show("Please select an invoice first");
                return;
            }



            if (MainClass.Functions.Validate(this) == false)
            {
                return;
            }
            if (editID == 0) // save
            {
                MainClass.Functions.AutoSQL(this, "tblPayment", MainClass.Functions.enmType.Insert, editID);
            }
            else
            {
                MainClass.Functions.AutoSQL(this, "tblPayment", MainClass.Functions.enmType.Update, editID);
            }
            editID = 0;
            MainClass.Functions.Reset_All(this);*/
        }

       /* public override void btnDel_Click(object sender, EventArgs e)
        {
            MainClass.Functions.AutoSQL(this, "tblPayment", MainClass.Functions.enmType.Delete, editID);
            editID = 0;
            MainClass.Functions.Reset_All(this);
        }*/



    }
}
