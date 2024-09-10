using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_System
{
    public partial class frmLogin : Sample
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLoginClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //show the frmMain form condition are user name : admin and password : admin123 equal not quilie then show the error message visibale fale true labele InvlidN and InvalidPd
            if (enterBoxName.Text == "admin" && enterBoxPassowrd.Text == "admin123")
            {
                frmMain obj = new frmMain();
                this.Hide();
                obj.Show();
            }
            else
            {
                InvlidN.Visible = true;
                InvalidPd.Visible = true;
               
                //font color red
                InvlidN.ForeColor = Color.Red;
                InvalidPd.ForeColor = Color.Red;

                //and border color red
               
                enterBoxName.BorderColor = Color.Red;
                enterBoxPassowrd.BorderColor = Color.Red;



            }



        }
    }
}
