namespace Billing_System.Model
{
    partial class frmPaymentAdd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PersonID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InvlidN = new System.Windows.Forms.Label();
            this.mdate = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.description = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NetAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mainID = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(208, 33);
            this.label1.Text = "Payment Details";
            // 
            // PersonID
            // 
            this.PersonID.BackColor = System.Drawing.Color.Transparent;
            this.PersonID.BorderColor = System.Drawing.Color.DarkViolet;
            this.PersonID.BorderRadius = 9;
            this.PersonID.BorderThickness = 2;
            this.PersonID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PersonID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PersonID.FillColor = System.Drawing.Color.Transparent;
            this.PersonID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PersonID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PersonID.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.PersonID.ForeColor = System.Drawing.Color.DarkViolet;
            this.PersonID.ItemHeight = 30;
            this.PersonID.Location = new System.Drawing.Point(226, 181);
            this.PersonID.Name = "PersonID";
            this.PersonID.Size = new System.Drawing.Size(265, 36);
            this.PersonID.TabIndex = 11;
            this.PersonID.SelectedIndexChanged += new System.EventHandler(this.PersonID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Customer Name";
            // 
            // InvlidN
            // 
            this.InvlidN.AutoSize = true;
            this.InvlidN.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvlidN.Location = new System.Drawing.Point(31, 158);
            this.InvlidN.Name = "InvlidN";
            this.InvlidN.Size = new System.Drawing.Size(41, 20);
            this.InvlidN.TabIndex = 8;
            this.InvlidN.Text = "Date";
            // 
            // mdate
            // 
            this.mdate.BorderColor = System.Drawing.Color.DarkViolet;
            this.mdate.BorderRadius = 9;
            this.mdate.BorderThickness = 2;
            this.mdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mdate.DefaultText = "";
            this.mdate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mdate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mdate.FillColor = System.Drawing.Color.Transparent;
            this.mdate.FocusedState.BorderColor = System.Drawing.Color.Fuchsia;
            this.mdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.mdate.ForeColor = System.Drawing.Color.DarkViolet;
            this.mdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mdate.Location = new System.Drawing.Point(27, 181);
            this.mdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mdate.Name = "mdate";
            this.mdate.PasswordChar = '\0';
            this.mdate.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.mdate.PlaceholderText = "";
            this.mdate.SelectedText = "";
            this.mdate.Size = new System.Drawing.Size(171, 36);
            this.mdate.TabIndex = 9;
            this.mdate.TabStop = false;
            this.mdate.Tag = "v";
            this.mdate.TextChanged += new System.EventHandler(this.mdate_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Description";
            // 
            // description
            // 
            this.description.BorderColor = System.Drawing.Color.DarkViolet;
            this.description.BorderRadius = 9;
            this.description.BorderThickness = 2;
            this.description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.description.DefaultText = "";
            this.description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.description.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.description.FillColor = System.Drawing.Color.Transparent;
            this.description.FocusedState.BorderColor = System.Drawing.Color.Fuchsia;
            this.description.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.description.ForeColor = System.Drawing.Color.DarkViolet;
            this.description.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.description.Location = new System.Drawing.Point(27, 275);
            this.description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.description.Name = "description";
            this.description.PasswordChar = '\0';
            this.description.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.description.PlaceholderText = "";
            this.description.SelectedText = "";
            this.description.Size = new System.Drawing.Size(464, 36);
            this.description.TabIndex = 13;
            this.description.TabStop = false;
            this.description.Tag = "v";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Amount";
            // 
            // NetAmount
            // 
            this.NetAmount.BorderColor = System.Drawing.Color.DarkViolet;
            this.NetAmount.BorderRadius = 9;
            this.NetAmount.BorderThickness = 2;
            this.NetAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NetAmount.DefaultText = "";
            this.NetAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NetAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NetAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NetAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NetAmount.FillColor = System.Drawing.Color.Transparent;
            this.NetAmount.FocusedState.BorderColor = System.Drawing.Color.Fuchsia;
            this.NetAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.NetAmount.ForeColor = System.Drawing.Color.DarkViolet;
            this.NetAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NetAmount.Location = new System.Drawing.Point(27, 367);
            this.NetAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NetAmount.Name = "NetAmount";
            this.NetAmount.PasswordChar = '\0';
            this.NetAmount.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.NetAmount.PlaceholderText = "";
            this.NetAmount.SelectedText = "";
            this.NetAmount.Size = new System.Drawing.Size(171, 36);
            this.NetAmount.TabIndex = 15;
            this.NetAmount.TabStop = false;
            this.NetAmount.Tag = "v";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(266, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Invoice #";
            // 
            // mainID
            // 
            this.mainID.AutoSize = true;
            this.mainID.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainID.Location = new System.Drawing.Point(266, 383);
            this.mainID.Name = "mainID";
            this.mainID.Size = new System.Drawing.Size(17, 20);
            this.mainID.TabIndex = 17;
            this.mainID.Text = "0";
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 35;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(521, 148);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 30;
            this.guna2DataGridView1.Size = new System.Drawing.Size(552, 310);
            this.guna2DataGridView1.TabIndex = 18;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 35;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 30;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
            // 
            // frmPaymentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 596);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.mainID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NetAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.description);
            this.Controls.Add(this.PersonID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InvlidN);
            this.Controls.Add(this.mdate);
            this.Name = "frmPaymentAdd";
            this.Text = "frmPaymentAdd";
            this.Load += new System.EventHandler(this.frmPaymentAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox PersonID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label InvlidN;
        private Guna.UI2.WinForms.Guna2TextBox mdate;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox description;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox NetAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label mainID;
        public Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
    }
}