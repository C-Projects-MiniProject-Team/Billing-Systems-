namespace Billing_System.Model
{
    partial class frmSupAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.sAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.InvlidN = new System.Windows.Forms.Label();
            this.sName = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(204, 33);
            this.label1.Text = "Supplier Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Address";
            // 
            // sAddress
            // 
            this.sAddress.BorderColor = System.Drawing.Color.DarkViolet;
            this.sAddress.BorderRadius = 9;
            this.sAddress.BorderThickness = 2;
            this.sAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sAddress.DefaultText = "";
            this.sAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sAddress.FillColor = System.Drawing.Color.Transparent;
            this.sAddress.FocusedState.BorderColor = System.Drawing.Color.Fuchsia;
            this.sAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.sAddress.ForeColor = System.Drawing.Color.DarkViolet;
            this.sAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sAddress.Location = new System.Drawing.Point(12, 259);
            this.sAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sAddress.Name = "sAddress";
            this.sAddress.PasswordChar = '\0';
            this.sAddress.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.sAddress.PlaceholderText = "Address";
            this.sAddress.SelectedText = "";
            this.sAddress.Size = new System.Drawing.Size(907, 59);
            this.sAddress.TabIndex = 23;
            this.sAddress.TabStop = false;
            this.sAddress.Tag = "v";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(627, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Email";
            // 
            // sEmail
            // 
            this.sEmail.BorderColor = System.Drawing.Color.DarkViolet;
            this.sEmail.BorderRadius = 9;
            this.sEmail.BorderThickness = 2;
            this.sEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sEmail.DefaultText = "";
            this.sEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sEmail.FillColor = System.Drawing.Color.Transparent;
            this.sEmail.FocusedState.BorderColor = System.Drawing.Color.Fuchsia;
            this.sEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.sEmail.ForeColor = System.Drawing.Color.DarkViolet;
            this.sEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sEmail.Location = new System.Drawing.Point(620, 159);
            this.sEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sEmail.Name = "sEmail";
            this.sEmail.PasswordChar = '\0';
            this.sEmail.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.sEmail.PlaceholderText = "Email Address";
            this.sEmail.SelectedText = "";
            this.sEmail.Size = new System.Drawing.Size(299, 59);
            this.sEmail.TabIndex = 22;
            this.sEmail.TabStop = false;
            this.sEmail.Tag = "v";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Phone";
            // 
            // sPhone
            // 
            this.sPhone.BorderColor = System.Drawing.Color.DarkViolet;
            this.sPhone.BorderRadius = 9;
            this.sPhone.BorderThickness = 2;
            this.sPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sPhone.DefaultText = "Phone No";
            this.sPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sPhone.FillColor = System.Drawing.Color.Transparent;
            this.sPhone.FocusedState.BorderColor = System.Drawing.Color.Fuchsia;
            this.sPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.sPhone.ForeColor = System.Drawing.Color.DarkViolet;
            this.sPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sPhone.Location = new System.Drawing.Point(317, 159);
            this.sPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sPhone.Name = "sPhone";
            this.sPhone.PasswordChar = '\0';
            this.sPhone.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.sPhone.PlaceholderText = "Phone No";
            this.sPhone.SelectedText = "";
            this.sPhone.Size = new System.Drawing.Size(299, 59);
            this.sPhone.TabIndex = 20;
            this.sPhone.TabStop = false;
            this.sPhone.Tag = "v";
            // 
            // InvlidN
            // 
            this.InvlidN.AutoSize = true;
            this.InvlidN.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvlidN.Location = new System.Drawing.Point(8, 135);
            this.InvlidN.Name = "InvlidN";
            this.InvlidN.Size = new System.Drawing.Size(49, 20);
            this.InvlidN.TabIndex = 17;
            this.InvlidN.Text = "Name";
            // 
            // sName
            // 
            this.sName.BorderColor = System.Drawing.Color.DarkViolet;
            this.sName.BorderRadius = 9;
            this.sName.BorderThickness = 2;
            this.sName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sName.DefaultText = "";
            this.sName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sName.FillColor = System.Drawing.Color.Transparent;
            this.sName.FocusedState.BorderColor = System.Drawing.Color.Fuchsia;
            this.sName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.sName.ForeColor = System.Drawing.Color.DarkViolet;
            this.sName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sName.Location = new System.Drawing.Point(12, 159);
            this.sName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sName.Name = "sName";
            this.sName.PasswordChar = '\0';
            this.sName.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.sName.PlaceholderText = "Name";
            this.sName.SelectedText = "";
            this.sName.Size = new System.Drawing.Size(299, 59);
            this.sName.TabIndex = 18;
            this.sName.TabStop = false;
            this.sName.Tag = "v";
            // 
            // frmSupAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sPhone);
            this.Controls.Add(this.InvlidN);
            this.Controls.Add(this.sName);
            this.Name = "frmSupAdd";
            this.Text = "frmSupAdd";
            this.Load += new System.EventHandler(this.frmSupAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox sAddress;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox sEmail;
        public Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        public Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog2;
        public Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog3;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox sPhone;
        private System.Windows.Forms.Label InvlidN;
        private Guna.UI2.WinForms.Guna2TextBox sName;
    }
}