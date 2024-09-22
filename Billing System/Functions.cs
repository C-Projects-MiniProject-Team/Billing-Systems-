using Billing_System;
using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MainClass
{
    class Functions
    {

        //Creat Connection
        public static string MsgCaption = "Billing System"; // Add this if needed
        public static string conString = "Data Source=LAHIRU\\SQLEXPRESS;Initial Catalog=BillingSystem;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(conString);

        //GetData
        public static bool IsValidUser(string user, string pass)
        {
            bool isValid = false;

            string qry = "Select * from tblUser where uUser ='" + user + "' and uPass = '" + pass + "' ";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
            }

            return isValid;
        }


        // For Insert, Update, Delete
        public static int SQL(string qry, Hashtable ht)
        {
            int res = 0;

            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }

                if (con.State == ConnectionState.Closed) { con.Open(); }
                res = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open) { con.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }

            return res;
        }

        public static DataTable GetData(string qry)
        {
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            return dt;
        }




        public static void CBFill(string qry, ComboBox cb)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(qry, Functions.con);
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb.DisplayMember = "name";
                cb.ValueMember = "id";
                cb.DataSource = dt;
                cb.SelectedIndex = 0;
                cb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                Functions.con.Close();
                MessageBox.Show(ex.Message);
            }
        }


        public static void loadData(string qry, DataGridView gv, ListBox lb)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(qry, Functions.con);
                cmd.CommandType = System.Data.CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colName1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colName1].DataPropertyName = dt.Columns[i].ToString();
                }

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                Functions.con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        public static void LoadData(string qry, DataGridView gv)
        {
            // Serial no in gridview
            gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_CellFormatting);

            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }

        private static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Guna.UI2.WinForms.Guna2DataGridView gv = (Guna.UI2.WinForms.Guna2DataGridView)sender;
            int count = 0;

            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        // Clear controls on form
        public static void ClearAll(Form F)
        {
            foreach (Control c in F.Controls)
            {
                Type type = c.GetType();

                if (type == typeof(Guna.UI2.WinForms.Guna2TextBox))
                {
                    Guna.UI2.WinForms.Guna2TextBox t = (Guna.UI2.WinForms.Guna2TextBox)c;
                    t.Text = "";
                }
                else if (type == typeof(Guna.UI2.WinForms.Guna2ComboBox))
                {
                    Guna.UI2.WinForms.Guna2ComboBox cb = (Guna.UI2.WinForms.Guna2ComboBox)c;
                    cb.SelectedIndex = 0;
                    cb.SelectedIndex = -1;
                }
                else if (type == typeof(CheckBox))
                {
                    ((CheckBox)c).Checked = false;
                }
                // You can add other controls like this
            }
        }

        public static void BlurBackground(Form Model)
        {
            Form Background = new Form();
            using (Model)
            {
                Background.StartPosition = FormStartPosition.Manual;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.5d;
                Background.BackColor = Color.Black;
                //Background.Size = frmMain.Instance.Size;
                //Background.Location = frmMain.Instance.Location;
                Background.ShowInTaskbar = false;
                Background.Show();
                Model.Owner = Background;
                Model.ShowDialog(Background);
                Background.Dispose();
            }
        }

        // Combo box fill
        public static void CBFfill(string qry, ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cb.DisplayMember = "name";
            cb.ValueMember = "id";
            cb.DataSource = dt;
            cb.SelectedIndex = -1;
        }





        public static void SrNo(Guna.UI2.WinForms.Guna2DataGridView gv)
        {
            try
            {
                int count = 0;
                foreach (DataGridViewRow row in gv.Rows)
                {
                    count++;
                    row.Cells[0].Value = count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }



        
        
        private static Color vColor = Color.FromArgb(245, 29, 70);

        // Validation
        public static bool Validatation(Form F) // for validiton you can see my form validatin video for details
        {
            bool isValid = true;
            int count = 0;
            int x;
            int y;

            // Remove old Labels
            var dynamicLabels = F.Controls.OfType<Label>().Where(c => c.Tag != null && c.Tag.ToString() == "remove").ToList();
            foreach (var lbl in dynamicLabels)
            {
                F.Controls.Remove(lbl);
            }

            foreach (Control c in F.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2Button)
                {
                }
                else
                {
                    if (c.Tag == null || c.Tag.ToString() == string.Empty)
                    {
                    }
                    else
                    {
                        Label lbl1 = new Label();
                        lbl1.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                        lbl1.AutoSize = true;

                        if (c is Guna.UI2.WinForms.Guna2TextBox) // TextBox
                        {
                            Guna.UI2.WinForms.Guna2TextBox t = (Guna.UI2.WinForms.Guna2TextBox)c;
                            if (t.AutoRoundedCorners == true)
                            {
                                x = int.Parse(c.Location.X.ToString()) + 10;
                                y = int.Parse(c.Location.Y.ToString()) + 5 + int.Parse(c.Height.ToString());
                            }
                            else
                            {
                                x = int.Parse(c.Location.X.ToString());
                                y = int.Parse(c.Location.Y.ToString()) + 5 + int.Parse(c.Height.ToString());
                            }

                            if (t.Text == "")
                            {
                                string cname = "lbl" + c.Name;
                                lbl1.Name = cname;
                                lbl1.Tag = "remove";
                                lbl1.Text = "Required";
                                lbl1.ForeColor = vColor;
                                //lbl1.Font = new Font("Bookman Old Style", 9, FontStyle.Regular);
                                F.Controls.Add(lbl1);

                                lbl1.Location = new System.Drawing.Point(x, y);
                                count++;
                            }

                            if (t.Tag.ToString() == "e" && t.Text != "")//Email
                            {
                                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                                Match match = regex.Match(t.Text);
                                if (match.Success) { }
                                else
                                {
                                    string cname = "lbl" + c.Name;
                                    lbl1.Name = cname;
                                    lbl1.Tag = "remove";
                                    lbl1.Text = "Invalid Email";
                                    lbl1.ForeColor = vColor;
                                    // lbl1.Font = new Font("Bookman Old Style", 9, FontStyle.Regular);
                                    F.Controls.Add(lbl1);

                                    lbl1.Location = new System.Drawing.Point(x, y);
                                }
                            }

                            if (t.Tag.ToString() == "n" && t.Text != "")
                            {
                                Regex regex = new Regex(@"^(\-?\d+)([0-9\.,]*)$");
                                Match match = regex.Match(t.Text);
                                if (match.Success) { }
                                else
                                {
                                    string cname = "nlbl" + c.Name;
                                    lbl1.Name = cname;
                                    lbl1.Tag = "remove";
                                    lbl1.Text = "Invalid Number";
                                    lbl1.ForeColor = vColor;
                                    lbl1.Font = new Font("Bookman Old Style", 9, FontStyle.Regular);
                                    F.Controls.Add(lbl1);

                                    lbl1.Location = new System.Drawing.Point(x, y);
                                }
                            }

                            if (t.Tag.ToString() == "d" && t.Text != "")//date
                            {
                                DateTime dt = new DateTime(1990, 1, 1).Date;
                                Regex regex = new Regex(@"^(0?[1-9]|[12][0-9]|3[01])[-/.](0?[1-9]|1[0-2])[-/.](\d{4}|\d{2})$");
                                Match match = regex.Match(t.Text);
                                DateTime.TryParse(t.Text, out dt);
                                if (match.Success && dt != new DateTime(0001, 1, 1).Date)
                                {
                                    int len = t.Text.Length;
                                    if (len != 10)
                                    {
                                        string cname = "dlbl" + c.Name;
                                        lbl1.Name = cname;
                                        lbl1.Tag = "remove";
                                        lbl1.Text = "Use dd/mm/yyyy";
                                        lbl1.ForeColor = vColor;
                                        // lbl1.Font = new Font("Bookman Old Style", 9, FontStyle.Regular);
                                        F.Controls.Add(lbl1);

                                        lbl1.Location = new System.Drawing.Point(x, y);
                                        count++;
                                    }
                                    else
                                    {
                                        string cname = "dlbl" + c.Name;
                                        lbl1.Name = cname;
                                        lbl1.Tag = "remove";
                                        lbl1.Text = "Invalid Date";
                                        lbl1.ForeColor = vColor;
                                        lbl1.Font = new Font("Bookman Old Style", 9, FontStyle.Regular);
                                        F.Controls.Add(lbl1);

                                        lbl1.Location = new System.Drawing.Point(x, y);
                                        count++;
                                    }
                                }
                            }
                        }

                        if (c is Guna.UI2.WinForms.Guna2ComboBox) // Dropdown
                        {
                            Guna.UI2.WinForms.Guna2ComboBox t = (Guna.UI2.WinForms.Guna2ComboBox)c;
                            if (t.AutoRoundedCorners == true)
                            {
                                x = int.Parse(c.Location.X.ToString()) + 10;
                                y = int.Parse(c.Location.Y.ToString()) + 5 + int.Parse(c.Height.ToString());
                            }
                            else
                            {
                                x = int.Parse(c.Location.X.ToString());
                                y = int.Parse(c.Location.Y.ToString()) + 5 + int.Parse(c.Height.ToString());
                            }

                            if (t.Text == "" || t.Text == null)
                            {
                                string cname = "lbl" + c.Name;
                                lbl1.Name = cname;
                                lbl1.Tag = "remove";
                                lbl1.Text = "Required";
                                lbl1.ForeColor = vColor;
                                // lbl1.Font = new Font("Bookman Old Style", 9, FontStyle.Regular);
                                F.Controls.Add(lbl1);

                                lbl1.Location = new System.Drawing.Point(x, y);
                                count++;
                            }
                        }
                    }
                }
            }

            if (count == 0)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
            return isValid;
        }



        public static void Enable_reset(Form p) // for resetting after save code
        {
            foreach (Control c in p.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2TextBox)
                {
                    Guna.UI2.WinForms.Guna2TextBox t = (Guna.UI2.WinForms.Guna2TextBox)c;
                    t.Text = "";
                }

                if (c is Guna.UI2.WinForms.Guna2ComboBox)
                {
                    Guna.UI2.WinForms.Guna2ComboBox cb = (Guna.UI2.WinForms.Guna2ComboBox)c;
                    cb.SelectedIndex = 0;
                    cb.SelectedIndex = -1;
                }

                if (c is Guna.UI2.WinForms.Guna2RadioButton)
                {
                    Guna.UI2.WinForms.Guna2RadioButton rb = (Guna.UI2.WinForms.Guna2RadioButton)c;
                    rb.Checked = false;
                }

                if (c is Guna.UI2.WinForms.Guna2CheckBox)
                {
                    Guna.UI2.WinForms.Guna2CheckBox chk = (Guna.UI2.WinForms.Guna2CheckBox)c;
                    chk.Checked = false;
                }

                if (c is Guna.UI2.WinForms.Guna2DateTimePicker)
                {
                    Guna.UI2.WinForms.Guna2DateTimePicker dp = (Guna.UI2.WinForms.Guna2DateTimePicker)c;
                    dp.Value = DateTime.Today;
                }

                if (c is ListBox)
                {
                    ListBox list = (ListBox)c;
                }

                if (c is NumericUpDown)
                {
                    NumericUpDown cb = (NumericUpDown)c;
                    cb.Value = 0;
                }

                if (c is MaskedTextBox)
                {
                    MaskedTextBox cb = (MaskedTextBox)c;
                    cb.Text = "";
                }
            }
        }


        public static void AutoLoadForEdit(Form form, string tableName, int id)
        {
            try
            {
                // Example SQL query to load data for the given ID
                string qry = $"SELECT * FROM {tableName} WHERE userID = @id";

                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    // Iterate over all controls in the form
                    foreach (Control c in form.Controls)
                    {
                        if (c is Guna.UI2.WinForms.Guna2TextBox t)
                        {
                            string colName = t.Name.Replace("txt", ""); // assuming control names are txt + column names
                            if (row.Table.Columns.Contains(colName))
                            {
                                t.Text = row[colName].ToString();
                            }
                        }
                        else if (c is Guna.UI2.WinForms.Guna2ComboBox cb)
                        {
                            string colName = cb.Name.Replace("cb", ""); // assuming control names are cb + column names
                            if (row.Table.Columns.Contains(colName))
                            {
                                cb.SelectedValue = row[colName].ToString();
                            }
                        }
                        // Add handling for other controls like CheckBox, RadioButton, etc. if necessary
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), MsgCaption);
            }
        }



        public static void AutoSQL(Form form, string tableName, enmType type, int editID)
        {
            try
            {
                string qry = string.Empty;
                Hashtable ht = new Hashtable();

                // Build SQL query based on the type of operation
                if (type == enmType.Insert)
                {
                    qry = $"INSERT INTO {tableName} (uName, uUser, uPass, uPhone, uEmail) VALUES (@uName, @uUser, @uPass, @uPhone, @uEmail)";
                }
                else if (type == enmType.Update && editID > 0)
                {
                    qry = $"UPDATE {tableName} SET uName = @uName, uUser = @uUser, uPass = @uPass, uPhone = @uPhone, uEmail = @uEmail WHERE userID = @userID";
                    ht.Add("@userID", editID); // Add the ID for update query
                }
                else if (type == enmType.Delete && editID > 0)
                {
                    qry = $"DELETE FROM {tableName} WHERE userID = @userID";
                    ht.Add("@userID", editID); // Add the ID for delete query
                }

                // Loop through form controls and gather values
                foreach (Control c in form.Controls)
                {
                    if (c is Guna.UI2.WinForms.Guna2TextBox txt)
                    {
                        string colName = txt.Name.Replace("txt", "");
                        ht.Add("@" + colName, txt.Text);
                    }
                    else if (c is Guna.UI2.WinForms.Guna2ComboBox cb)
                    {
                        string colName = cb.Name.Replace("cb", "");
                        ht.Add("@" + colName, cb.SelectedValue);
                    }
                }

                // Execute SQL query
                int result = SQL(qry, ht);

                // Show success message if rows were affected
                if (result > 0)
                {
                    //MessageBox.Show("xxxxxxxxxSaved successfully.", "Billing System", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }


        public enum enmType
        {
            Insert,
            Update,
            Delete
        }



    }
}
