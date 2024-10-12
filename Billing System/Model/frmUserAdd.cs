using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

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
            // Disable autocomplete for password field
            uPass.AutoCompleteMode = AutoCompleteMode.None;
            uPass.AutoCompleteSource = AutoCompleteSource.None;

            // Set the password to be hidden initially
            uPass.UseSystemPasswordChar = true;

            // Ensure the checkbox is unchecked by default
            checkBoxBTN.Checked = false;

            // Existing user edit logic
            if (editID > 0)
            {
                MainClass.Functions.AutoLoadForEdit(this, "tblUser", editID);
                object userRoleObj = MainClass.Functions.GetFieldValue("SELECT uRole FROM tblUser WHERE userID = " + editID);

                if (userRoleObj != null && userRoleObj != DBNull.Value)
                {
                    int userRoleId = Convert.ToInt32(userRoleObj);
                    LoadRoles();
                    uRole.SelectedValue = userRoleId;
                }
                else
                {
                    MessageBox.Show("Error: No role found for the user.");
                }
            }
            else
            {
                LoadRoles();
                uRole.SelectedIndex = -1;
            }

            uRole.Visible = true;
            uRole.Enabled = true;
        }





        // Helper method to load roles
        private void LoadRoles()
        {
            string roleQuery = "SELECT RoleID, RoleName FROM tblRole";
            DataTable roleTable = MainClass.Functions.GetDataTable(roleQuery);

            if (roleTable != null && roleTable.Rows.Count > 0)
            {
                uRole.DataSource = roleTable;
                uRole.DisplayMember = "RoleName";  // Display the RoleName (e.g., Admin, User)
                uRole.ValueMember = "RoleID";      // Use RoleID as the value
            }
            else
            {
                MessageBox.Show("No roles found.");
            }
        }


        // Save button click handler
        public override void btnSave_Click(object sender, EventArgs e)
        {
            // Clear previous error labels if any
            ClearErrorLabels();

            bool isValid = true;

            // Validate Name field
            if (string.IsNullOrWhiteSpace(uName.Text)) // Change txtName to uName
            {
                ShowValidationError(uName, "Required");
                isValid = false;
            }

            // Validate Role field
            if (uRole.SelectedIndex == -1)
            {
                ShowValidationError(uRole, "Required");
                isValid = false;
            }

            // Validate Password field
            if (string.IsNullOrWhiteSpace(uPass.Text)) // Change txtPassword to uPass
            {
                ShowValidationError(uPass, "Required");
                isValid = false;
            }

            // Stop execution if any validation fails
            if (!isValid)
            {
                return;
            }

            // Proceed with save operation if validation passes
            if (editID == 0) // Insert new user
            {
                MainClass.Functions.AutoSQL(this, "tblUser", MainClass.Functions.enmType.Insert, editID);
                guna2MessageDialog1.Show();
                ClearFields(); // Clear all fields including image
            }
            else // Update existing user
            {
                MainClass.Functions.AutoSQL(this, "tblUser", MainClass.Functions.enmType.Update, editID);
                guna2MessageDialog3.Show();
            }

            editID = 0;
        }





        // Method to show validation error message below the control
        private void ShowValidationError(Control control, string errorMessage)
        {
            Label lblError = new Label();
            lblError.Text = errorMessage;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(control.Location.X, control.Location.Y + control.Height + 5);
            lblError.Name = "lbl" + control.Name;
            this.Controls.Add(lblError);
        }






        // Method to clear all error labels from the form
        private void ClearErrorLabels()
        {
            var labels = this.Controls.OfType<Label>().Where(lbl => lbl.ForeColor == Color.Red).ToList();
            foreach (var lbl in labels)
            {
                this.Controls.Remove(lbl);
            }
        }

        // Method to clear a specific error label
        private void ClearSpecificErrorLabel(string labelName)
        {
            var label = this.Controls.OfType<Label>().FirstOrDefault(l => l.Name == labelName);
            if (label != null)
            {
                this.Controls.Remove(label);
            }
        }

        private void ClearFields()
        {
            MainClass.Functions.ClearAll(this); // Clear all input fields
            picuterBoxUser.Image = null; // Clear the image display
            uRole.SelectedIndex = -1; // Clear role selection
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            // Show confirmation dialog
            DialogResult result = guna2MessageDialog2.Show();

            if (result == DialogResult.Yes) // Delete user if confirmed
            {
                MainClass.Functions.AutoSQL(this, "tblUser", MainClass.Functions.enmType.Delete, editID);
                editID = 0;
                ClearFields(); // Clear fields after deletion
            }
        }

        private void PicUpload_Click(object sender, EventArgs e)
        {
            // Assuming picuterBoxUser is the PictureBox control on your form
            MainClass.Functions.BrowsePicture(picuterBoxUser);
        }


        private void picuterBoxUser_Click(object sender, EventArgs e)
        {
            // You can add custom behavior for clicking on the PictureBox here if needed
        }

        private void checkBoxBTN_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            if (checkBoxBTN.Checked)
            {
                // Show password
                uPass.UseSystemPasswordChar = false;
            }
            else
            {
                // Hide password
                uPass.UseSystemPasswordChar = true;
            }
        }


    }
}
