namespace Billing_System.Model
{
    partial class frmSaleAdd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.InvlidN = new System.Windows.Forms.Label();
            this.mDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PersonID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mDueDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.pType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Discount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NetAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.srno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2DataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.mainID = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.mType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(154, 33);
            this.label1.Text = "Sale Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // InvlidN
            // 
            this.InvlidN.AutoSize = true;
            this.InvlidN.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvlidN.Location = new System.Drawing.Point(301, 161);
            this.InvlidN.Name = "InvlidN";
            this.InvlidN.Size = new System.Drawing.Size(41, 20);
            this.InvlidN.TabIndex = 4;
            this.InvlidN.Text = "Date";
            this.InvlidN.Click += new System.EventHandler(this.InvlidN_Click);
            // 
            // mDate
            // 
            this.mDate.BorderColor = System.Drawing.Color.DarkViolet;
            this.mDate.BorderRadius = 9;
            this.mDate.BorderThickness = 2;
            this.mDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mDate.DefaultText = "";
            this.mDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mDate.FillColor = System.Drawing.Color.Transparent;
            this.mDate.FocusedState.BorderColor = System.Drawing.Color.Fuchsia;
            this.mDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.mDate.ForeColor = System.Drawing.Color.DarkViolet;
            this.mDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mDate.Location = new System.Drawing.Point(305, 184);
            this.mDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mDate.Name = "mDate";
            this.mDate.PasswordChar = '\0';
            this.mDate.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.mDate.PlaceholderText = "";
            this.mDate.SelectedText = "";
            this.mDate.Size = new System.Drawing.Size(171, 36);
            this.mDate.TabIndex = 5;
            this.mDate.TabStop = false;
            this.mDate.Tag = "v";
            this.mDate.TextChanged += new System.EventHandler(this.uName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Customer Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.PersonID.Items.AddRange(new object[] {
            "3",
            "4"});
            this.PersonID.Location = new System.Drawing.Point(24, 184);
            this.PersonID.Name = "PersonID";
            this.PersonID.Size = new System.Drawing.Size(265, 36);
            this.PersonID.TabIndex = 7;
            this.PersonID.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(490, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Due Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // mDueDate
            // 
            this.mDueDate.BorderColor = System.Drawing.Color.DarkViolet;
            this.mDueDate.BorderRadius = 9;
            this.mDueDate.BorderThickness = 2;
            this.mDueDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mDueDate.DefaultText = "";
            this.mDueDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mDueDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mDueDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mDueDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mDueDate.FillColor = System.Drawing.Color.Transparent;
            this.mDueDate.FocusedState.BorderColor = System.Drawing.Color.Fuchsia;
            this.mDueDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.mDueDate.ForeColor = System.Drawing.Color.DarkViolet;
            this.mDueDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mDueDate.Location = new System.Drawing.Point(493, 184);
            this.mDueDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mDueDate.Name = "mDueDate";
            this.mDueDate.PasswordChar = '\0';
            this.mDueDate.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.mDueDate.PlaceholderText = "";
            this.mDueDate.SelectedText = "";
            this.mDueDate.Size = new System.Drawing.Size(171, 36);
            this.mDueDate.TabIndex = 9;
            this.mDueDate.TabStop = false;
            this.mDueDate.Tag = "v";
            this.mDueDate.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // pType
            // 
            this.pType.BackColor = System.Drawing.Color.Transparent;
            this.pType.BorderColor = System.Drawing.Color.DarkViolet;
            this.pType.BorderRadius = 9;
            this.pType.BorderThickness = 2;
            this.pType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.pType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pType.FillColor = System.Drawing.Color.Transparent;
            this.pType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pType.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold);
            this.pType.ForeColor = System.Drawing.Color.DarkViolet;
            this.pType.ItemHeight = 30;
            this.pType.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.pType.Location = new System.Drawing.Point(683, 184);
            this.pType.Name = "pType";
            this.pType.Size = new System.Drawing.Size(104, 36);
            this.pType.TabIndex = 10;
            this.pType.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(679, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Type";
            // 
            // mTotal
            // 
            this.mTotal.BorderColor = System.Drawing.Color.DarkViolet;
            this.mTotal.BorderRadius = 9;
            this.mTotal.BorderThickness = 2;
            this.mTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mTotal.DefaultText = "";
            this.mTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mTotal.FillColor = System.Drawing.Color.Transparent;
            this.mTotal.FocusedState.BorderColor = System.Drawing.Color.Fuchsia;
            this.mTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.mTotal.ForeColor = System.Drawing.Color.DarkViolet;
            this.mTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mTotal.Location = new System.Drawing.Point(981, 427);
            this.mTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mTotal.Name = "mTotal";
            this.mTotal.PasswordChar = '\0';
            this.mTotal.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.mTotal.PlaceholderText = "";
            this.mTotal.SelectedText = "";
            this.mTotal.Size = new System.Drawing.Size(171, 36);
            this.mTotal.TabIndex = 12;
            this.mTotal.TabStop = false;
            this.mTotal.Tag = "v";
            this.mTotal.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(856, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gross Amount";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(856, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Discount";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Discount
            // 
            this.Discount.BorderColor = System.Drawing.Color.DarkViolet;
            this.Discount.BorderRadius = 9;
            this.Discount.BorderThickness = 2;
            this.Discount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Discount.DefaultText = "";
            this.Discount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Discount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Discount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Discount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Discount.FillColor = System.Drawing.Color.Transparent;
            this.Discount.FocusedState.BorderColor = System.Drawing.Color.Fuchsia;
            this.Discount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.Discount.ForeColor = System.Drawing.Color.DarkViolet;
            this.Discount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Discount.Location = new System.Drawing.Point(981, 471);
            this.Discount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Discount.Name = "Discount";
            this.Discount.PasswordChar = '\0';
            this.Discount.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.Discount.PlaceholderText = "";
            this.Discount.SelectedText = "";
            this.Discount.Size = new System.Drawing.Size(171, 36);
            this.Discount.TabIndex = 14;
            this.Discount.TabStop = false;
            this.Discount.Tag = "v";
            this.Discount.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(856, 521);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Net Amount";
            this.label7.Click += new System.EventHandler(this.label7_Click);
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
            this.NetAmount.Location = new System.Drawing.Point(981, 515);
            this.NetAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NetAmount.Name = "NetAmount";
            this.NetAmount.PasswordChar = '\0';
            this.NetAmount.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.NetAmount.PlaceholderText = "";
            this.NetAmount.SelectedText = "";
            this.NetAmount.Size = new System.Drawing.Size(171, 36);
            this.NetAmount.TabIndex = 16;
            this.NetAmount.TabStop = false;
            this.NetAmount.Tag = "v";
            this.NetAmount.TextChanged += new System.EventHandler(this.guna2TextBox4_TextChanged);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.guna2DataGridView1.ColumnHeadersHeight = 35;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.srno,
            this.detailID,
            this.proID,
            this.proName,
            this.qty,
            this.Price,
            this.Amount});
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle21;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(24, 236);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 30;
            this.guna2DataGridView1.Size = new System.Drawing.Size(763, 349);
            this.guna2DataGridView1.TabIndex = 3;
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
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 30;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            this.guna2DataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellEndEdit);
            this.guna2DataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.guna2DataGridView1_CellFormatting);
            this.guna2DataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.guna2DataGridView1_EditingControlShowing);
            // 
            // srno
            // 
            this.srno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.srno.FillWeight = 70F;
            this.srno.HeaderText = "Sr#";
            this.srno.MinimumWidth = 70;
            this.srno.Name = "srno";
            this.srno.Width = 70;
            // 
            // detailID
            // 
            this.detailID.FillWeight = 7.259058F;
            this.detailID.HeaderText = "id";
            this.detailID.MinimumWidth = 6;
            this.detailID.Name = "detailID";
            this.detailID.Visible = false;
            // 
            // proID
            // 
            this.proID.HeaderText = "proID";
            this.proID.MinimumWidth = 6;
            this.proID.Name = "proID";
            this.proID.Visible = false;
            // 
            // proName
            // 
            this.proName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.proName.FillWeight = 1000F;
            this.proName.HeaderText = "Product Name";
            this.proName.MinimumWidth = 6;
            this.proName.Name = "proName";
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.qty.HeaderText = "Qty";
            this.qty.MinimumWidth = 100;
            this.qty.Name = "qty";
            this.qty.Width = 125;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 100;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 100;
            this.Amount.Name = "Amount";
            // 
            // guna2DataGridView2
            // 
            this.guna2DataGridView2.AllowUserToAddRows = false;
            this.guna2DataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.guna2DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.guna2DataGridView2.ColumnHeadersHeight = 35;
            this.guna2DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView2.DefaultCellStyle = dataGridViewCellStyle24;
            this.guna2DataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.guna2DataGridView2.Location = new System.Drawing.Point(153, 347);
            this.guna2DataGridView2.Name = "guna2DataGridView2";
            this.guna2DataGridView2.ReadOnly = true;
            this.guna2DataGridView2.RowHeadersVisible = false;
            this.guna2DataGridView2.RowHeadersWidth = 51;
            this.guna2DataGridView2.RowTemplate.Height = 30;
            this.guna2DataGridView2.Size = new System.Drawing.Size(464, 194);
            this.guna2DataGridView2.TabIndex = 17;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.guna2DataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(54)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 35;
            this.guna2DataGridView2.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Height = 30;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView2.Visible = false;
            this.guna2DataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView2_CellClick);
            // 
            // mainID
            // 
            this.mainID.AutoSize = true;
            this.mainID.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainID.Location = new System.Drawing.Point(939, 211);
            this.mainID.Name = "mainID";
            this.mainID.Size = new System.Drawing.Size(68, 20);
            this.mainID.TabIndex = 20;
            this.mainID.Text = "purchase";
            this.mainID.Visible = false;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(1053, 211);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(68, 20);
            this.description.TabIndex = 21;
            this.description.Text = "purchase";
            this.description.Visible = false;
            // 
            // mType
            // 
            this.mType.AutoSize = true;
            this.mType.Location = new System.Drawing.Point(939, 161);
            this.mType.Name = "mType";
            this.mType.Size = new System.Drawing.Size(49, 28);
            this.mType.TabIndex = 22;
            this.mType.Text = "sale";
            this.mType.Visible = false;
            this.mType.Click += new System.EventHandler(this.label8_Click);
            // 
            // frmSaleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 743);
            this.Controls.Add(this.mType);
            this.Controls.Add(this.description);
            this.Controls.Add(this.mainID);
            this.Controls.Add(this.guna2DataGridView2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NetAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mDueDate);
            this.Controls.Add(this.PersonID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InvlidN);
            this.Controls.Add(this.mDate);
            this.Controls.Add(this.guna2DataGridView1);
            this.Name = "frmSaleAdd";
            this.Text = "frmSaleAdd";
            this.Load += new System.EventHandler(this.frmSaleAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label InvlidN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn srno;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn proID;
        private System.Windows.Forms.DataGridViewTextBoxColumn proName;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        public Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView2;
        private System.Windows.Forms.Label mainID;
        private System.Windows.Forms.Label description;
        public System.Windows.Forms.Label mType;
        public Guna.UI2.WinForms.Guna2TextBox mDate;
        public Guna.UI2.WinForms.Guna2ComboBox PersonID;
        public Guna.UI2.WinForms.Guna2TextBox mDueDate;
        public Guna.UI2.WinForms.Guna2ComboBox pType;
        public Guna.UI2.WinForms.Guna2TextBox mTotal;
        public Guna.UI2.WinForms.Guna2TextBox Discount;
        public Guna.UI2.WinForms.Guna2TextBox NetAmount;
    }
}