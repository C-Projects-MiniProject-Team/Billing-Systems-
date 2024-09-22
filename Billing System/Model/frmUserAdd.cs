using System;
using System.Collections;
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
    public partial class frmUserAdd : SampleAdd
    {
        public frmUserAdd()
        {
            InitializeComponent();
        }

        private void frmUserAdd_Load(object sender, EventArgs e)
        {

            if (editID > 0)
            {
                MainClass.Functions.AutoLoadForEdit(this, "tblUser", editID);
                
            }

        }



        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (MainClass.Functions.Validatation(this) == false)
            {
                return;
            }

            if (editID == 0) // save
            {
                MainClass.Functions.AutoSQL(this, "tblUser", MainClass.Functions.enmType.Insert, editID);
                guna2MessageDialog1.Show();
                MainClass.Functions.ClearAll(this);

            }
            else //update
            {
                MainClass.Functions.AutoSQL(this, "tblUser", MainClass.Functions.enmType.Update, editID);
                guna2MessageDialog3.Show();
            }
            editID = 0;
            MainClass.Functions.ClearAll(this);
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            // Show the confirmation dialog with Yes/No buttons
            DialogResult result = guna2MessageDialog2.Show();

            // Proceed with deletion only if the user selects "Yes"
            if (result == DialogResult.Yes)
            {
                MainClass.Functions.AutoSQL(this, "tblUser", MainClass.Functions.enmType.Delete, editID);
                editID = 0;
                MainClass.Functions.ClearAll(this);
            }
            else
            {
                // Optional: Handle "No" result if needed, or do nothing
                
            }
        }


    }
}
