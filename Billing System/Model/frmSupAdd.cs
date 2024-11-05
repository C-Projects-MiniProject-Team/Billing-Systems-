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

namespace Billing_System.Model
{
    public partial class frmSupAdd : SampleAdd
    {
        public frmSupAdd()
        {
            InitializeComponent();
        }

        private void frmSupAdd_Load(object sender, EventArgs e)
        {
            if (editID > 0) // If editing an existing user
            {
                // Load user data for editing
                MainClass.Functions.AutoLoadForEdit(this, "tblSupplier", editID);

            }
        }
        private void frmCusAdd_Load(object sender, EventArgs e)
        {
            if (editID > 0) // If editing an existing user
            {
                // Load user data for editing
                MainClass.Functions.AutoLoadForEdit(this, "tblSupplier", editID);

            }
        }

        private void ClearErrorLabels()
        {
            var labels = this.Controls.OfType<Label>().Where(lbl => lbl.ForeColor == Color.Red).ToList();
            foreach (var lbl in labels)
            {
                this.Controls.Remove(lbl);
            }
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

        public override void btnSave_Click(object sender, EventArgs e)
        {
            // Clear previous error labels if any
            ClearErrorLabels();

            bool isValid = true;

            // Validate Name field
            if (string.IsNullOrWhiteSpace(sName.Text)) // Validate uName field
            {
                ShowValidationError(sName, "Required");
                isValid = false;
            }


            // Proceed with save operation if validation passes
            if (editID == 0) // Insert new user
            {
                // Encrypt the password before saving
                MainClass.Functions.AutoSQL(this, "tblSupplier", MainClass.Functions.enmType.Insert, editID);
                guna2MessageDialog1.Show(); // Show success message
                ClearFields(); // Clear all fields including image
            }
            else // Update existing user
            {
                // Encrypt the password before saving
                MainClass.Functions.AutoSQL(this, "tblSupplier", MainClass.Functions.enmType.Update, editID);
                guna2MessageDialog3.Show(); // Show update message
            }

            editID = 0; // Reset editID after save/update
        }

        private void ClearFields()
        {
            MainClass.Functions.ClearAll(this); // Clear all input fields
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            // Show confirmation dialog
            DialogResult result = guna2MessageDialog2.Show();

            if (result == DialogResult.Yes) // Delete user if confirmed
            {
                MainClass.Functions.AutoSQL(this, "tblSupplier", MainClass.Functions.enmType.Delete, editID);
                editID = 0;
                ClearFields(); // Clear fields after deletion
            }
        }
    }
}
