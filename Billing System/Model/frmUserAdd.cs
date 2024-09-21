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
            }
            else //update
            {
                MainClass.Functions.AutoSQL(this, "tblUser", MainClass.Functions.enmType.Update, editID);
            }
            editID = 0;
            MainClass.Functions.ClearAll(this);
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            MainClass.Functions.AutoSQL(this, "tblUser", MainClass.Functions.enmType.Delete, editID);
            editID = 0;
            MainClass.Functions.ClearAll(this);
        }

    }
}
