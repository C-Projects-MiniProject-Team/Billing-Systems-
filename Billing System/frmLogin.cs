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
            // Set the password field to hide text initially
            txtPass.UseSystemPasswordChar = true;
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
            string username = txtUser.Text;
            string password = txtPass.Text;

            // Validate fields first
            if (MainClass.Functions.Validate(this) == false)
            {
                return;
            }

            // Username සහ password validate කිරීම
            if (MainClass.Functions.IsValidUser(username, password))
            {
                // Login සාර්ථකයි නම් frmMain form එක විවෘත කරන්න
                new frmMain().Show();
                this.Hide();
            }
            else
            {
                InvlidN.Visible = true;
                InvalidPd.Visible = true;

                //font color red
                InvlidN.ForeColor = Color.Red;
                InvalidPd.ForeColor = Color.Red;

                //and border color red

                txtUser.BorderColor = Color.Red;
                txtPass.BorderColor = Color.Red;
                // Login අසාර්ථක නම් error message එක පෙන්වන්න
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            txtPass.UseSystemPasswordChar = !guna2ToggleSwitch1.Checked;
        }
    }
}
