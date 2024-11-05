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

        //Creat Connection ------
        public static string MsgCaption = "Billing System"; // Add this if needed
        public static string conString = "Data Source=DESKTOP-TAHIKVG\\SQLEXPRESS09;Initial Catalog=BillingSystem;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(conString);


        public static DataTable GetDataTable(string query)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching data: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }

            return dt;
        }


        public static object GetFieldValue(string query)
        {
            object value = null;

            using (SqlConnection con = new SqlConnection(conString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        value = cmd.ExecuteScalar(); // ExecuteScalar returns a single value
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching field value: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }

            return value;
        }




        public static void CBFillCombo(string qry, ComboBox cb)
        {
            try
            {
                cb.Items.Clear(); // Clear existing items before loading new data

                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    cb.DisplayMember = "RoleName";  // Column name for the role name
                    cb.ValueMember = "RoleID";      // Column name for the role ID
                    cb.DataSource = dt;
                }

                cb.SelectedIndex = -1; // Avoid auto-selecting the first item
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in CBFillCombo: " + ex.Message);
            }
        }











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

        // Method to fetch data from the database
        public static DataTable GetData(string qry)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);  // Fill the DataTable with data
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);  // Show error message
                return null;
            }
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


        //Clear...............................
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
                    cb.SelectedIndex = -1;
                }
                else if (type == typeof(CheckBox))
                {
                    ((CheckBox)c).Checked = false;
                }
                else if (type == typeof(PictureBox)) // Clear PictureBox image
                {
                    PictureBox pb = (PictureBox)c;
                    pb.Image = null; // Or reset to a default image
                }
                // Add any other control types as needed
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





        private static Color vColor = Color.FromArgb(245, 29, 70); // Error color

        // Validation function for form controls
        public static bool Validatation(Form F)
        {
            bool isValid = true;
            int count = 0; // Counter to track number of invalid fields
            int x, y;

            // Remove old validation labels
            var dynamicLabels = F.Controls.OfType<Label>()
                                          .Where(c => c.Tag != null && c.Tag.ToString() == "remove")
                                          .ToList();
            foreach (var lbl in dynamicLabels)
            {
                F.Controls.Remove(lbl);
            }

            // Iterate over each control in the form
            foreach (Control c in F.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2Button)
                {
                    // Skip validation for buttons
                }
                else
                {
                    if (c.Tag == null || c.Tag.ToString() == string.Empty)
                    {
                        // Skip controls without tags
                    }
                    else
                    {
                        Label lbl1 = new Label();
                        lbl1.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                        lbl1.AutoSize = true;

                        // Validation for Guna2TextBox controls
                        if (c is Guna.UI2.WinForms.Guna2TextBox t)
                        {
                            if (t.AutoRoundedCorners)
                            {
                                x = int.Parse(c.Location.X.ToString()) + 10;
                                y = int.Parse(c.Location.Y.ToString()) + 5 + int.Parse(c.Height.ToString());
                            }
                            else
                            {
                                x = int.Parse(c.Location.X.ToString());
                                y = int.Parse(c.Location.Y.ToString()) + 5 + int.Parse(c.Height.ToString());
                            }

                            // Check if textbox is empty
                            if (t.Text == "")
                            {
                                string cname = "lbl" + c.Name;
                                lbl1.Name = cname;
                                lbl1.Tag = "remove";
                                lbl1.Text = "Required";
                                lbl1.ForeColor = vColor;
                                F.Controls.Add(lbl1);
                                lbl1.Location = new System.Drawing.Point(x, y);
                                count++;
                            }

                            // Email validation
                            if (t.Tag.ToString() == "e" && t.Text != "")
                            {
                                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                                Match match = regex.Match(t.Text);
                                if (!match.Success)
                                {
                                    string cname = "lbl" + c.Name;
                                    lbl1.Name = cname;
                                    lbl1.Tag = "remove";
                                    lbl1.Text = "Invalid Email";
                                    lbl1.ForeColor = vColor;
                                    F.Controls.Add(lbl1);
                                    lbl1.Location = new System.Drawing.Point(x, y);
                                }
                            }

                            // Number validation
                            if (t.Tag.ToString() == "n" && t.Text != "")
                            {
                                Regex regex = new Regex(@"^(\-?\d+)([0-9\.,]*)$");
                                Match match = regex.Match(t.Text);
                                if (!match.Success)
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

                            // Date validation
                            if (t.Tag.ToString() == "d" && t.Text != "")
                            {
                                DateTime dt;
                                Regex regex = new Regex(@"^(0?[1-9]|[12][0-9]|3[01])[-/.](0?[1-9]|1[0-2])[-/.](\d{4}|\d{2})$");
                                Match match = regex.Match(t.Text);
                                DateTime.TryParse(t.Text, out dt);
                                if (!match.Success || dt == DateTime.MinValue)
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

                        // Validation for ComboBox (e.g., Role selection)
                        if (c is Guna.UI2.WinForms.Guna2ComboBox comboBox)
                        {
                            if (comboBox.AutoRoundedCorners)
                            {
                                x = int.Parse(c.Location.X.ToString()) + 10;
                                y = int.Parse(c.Location.Y.ToString()) + 5 + int.Parse(c.Height.ToString());
                            }
                            else
                            {
                                x = int.Parse(c.Location.X.ToString());
                                y = int.Parse(c.Location.Y.ToString()) + 5 + int.Parse(c.Height.ToString());
                            }

                            // Check if no role is selected (SelectedIndex = -1 means no selection)
                            if (comboBox.SelectedIndex == -1)
                            {
                                string cname = "lbl" + c.Name;
                                lbl1.Name = cname;
                                lbl1.Tag = "remove";
                                lbl1.Text = "Required";
                                lbl1.ForeColor = vColor;
                                F.Controls.Add(lbl1);
                                lbl1.Location = new System.Drawing.Point(x, y);
                                count++;
                            }
                        }
                    }
                }
            }

            // If any validation failed, return false
            if (count > 0)
            {
                isValid = false;
            }

            return isValid; // Return whether the form is valid or not
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
                string idColumn = "";

                // Dynamically choose the correct ID column based on the table name
                if (tableName == "tblUser")
                {
                    idColumn = "userID";
                }
                else if (tableName == "tblProduct")
                {
                    idColumn = "proID";
                }

                // Ensure the ID column is defined
                if (string.IsNullOrEmpty(idColumn))
                {
                    MessageBox.Show("Invalid table name provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Use the correct ID column for the query
                string qry = $"SELECT * FROM {tableName} WHERE {idColumn} = @id";

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
                        // For Guna2TextBox controls
                        if (c is Guna.UI2.WinForms.Guna2TextBox t)
                        {
                            string colName = t.Name.Replace("txt", ""); // Assuming control names are txt + column names
                            if (row.Table.Columns.Contains(colName))
                            {
                                t.Text = row[colName].ToString();
                            }
                        }

                        // For PictureBox controls to load the user image
                        else if (c is PictureBox pb)
                        {
                            if (pb.Name == "picuterBoxUser" && tableName == "tblUser" && row["uImage"] != DBNull.Value)
                            {
                                byte[] imageBytes = (byte[])row["uImage"];
                                pb.Image = ByteArrayToImage(imageBytes); // Convert byte array back to image
                            }
                            else if (pb.Name == "pImage" && tableName == "tblProduct" && row["pImage"] != DBNull.Value)
                            {
                                byte[] imageBytes = (byte[])row["pImage"];
                                pb.Image = ByteArrayToImage(imageBytes); // Convert byte array back to image
                            }
                            else
                            {
                                pb.Image = null; // If no image, set PictureBox to null or a default image
                            }
                        }
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

                // Determine the query based on the table and the operation type
                switch (tableName)
                {
                    case "tblProduct":
                        if (type == enmType.Insert)
                        {
                            qry = $"INSERT INTO {tableName} (pName, pPrice, pCost, pImage) VALUES (@pName, @pPrice, @pCost, @pImage)";
                        }
                        else if (type == enmType.Update && editID > 0)
                        {
                            qry = $"UPDATE {tableName} SET pName = @pName, pPrice = @pPrice, pCost = @pCost, pImage = @pImage WHERE proID = @proID";
                            ht.Add("@proID", editID);
                        }
                        else if (type == enmType.Delete && editID > 0)
                        {
                            qry = $"DELETE FROM {tableName} WHERE proID = @proID";
                            ht.Add("@proID", editID);
                        }
                        break;

                    case "tblUser":
                        if (type == enmType.Insert)
                        {
                            qry = $"INSERT INTO {tableName} (uName, uRole, uPass, uPhone, uEmail, uImage) VALUES (@uName, @uRole, @uPass, @uPhone, @uEmail, @uImage)";
                        }
                        else if (type == enmType.Update && editID > 0)
                        {
                            qry = $"UPDATE {tableName} SET uName = @uName, uRole = @uRole, uPass = @uPass, uPhone = @uPhone, uEmail = @uEmail, uImage = @uImage WHERE userID = @userID";
                            ht.Add("@userID", editID);
                        }
                        else if (type == enmType.Delete && editID > 0)
                        {
                            qry = $"DELETE FROM {tableName} WHERE userID = @userID";
                            ht.Add("@userID", editID);
                        }
                        break;

                    default:
                        MessageBox.Show("Invalid table name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                // Loop through form controls and gather values dynamically
                foreach (Control c in form.Controls)
                {
                    if (c is Guna2TextBox txt)
                    {
                        string colName = txt.Name.Replace("txt", "");

                        // **Encrypt password field before saving to database**
                        if (colName == "uPass")
                        {
                            ht.Add("@" + colName, SecurityFunctions.EncryptPassword(txt.Text));
                        }
                        else
                        {
                            ht.Add("@" + colName, txt.Text);
                        }
                    }
                    else if (c is Guna2ComboBox cb && cb.Name == "uRole")
                    {
                        if (cb.SelectedValue == null)
                        {
                            return;
                        }
                        else
                        {
                            ht.Add("@uRole", cb.SelectedValue);  // Add the role to the SQL parameters
                        }
                    }
                    else if (c is PictureBox pb)
                    {
                        if (pb.Name == "picuterBoxUser") // For user images
                        {
                            if (pb.Image != null)
                            {
                                ht.Add("@uImage", ImageToByteArray(pb.Image));
                            }
                            else
                            {
                                ht.Add("@uImage", DBNull.Value);  // If no image, add DBNull
                            }
                        }
                        else if (pb.Name == "pImage") // For product images
                        {
                            if (pb.Image != null)
                            {
                                ht.Add("@pImage", ImageToByteArray(pb.Image));
                            }
                            else
                            {
                                ht.Add("@pImage", DBNull.Value);  // If no image, add DBNull
                            }
                        }
                    }
                }

                // Execute SQL query
                int result = SQL(qry, ht);

                // Optional: Show success message if rows were affected
                if (result > 0)
                {
                    MessageBox.Show("Operation completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }





        public static byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new System.IO.MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }







        public enum enmType
        {
            Insert,
            Update,
            Delete
        }


        public static void BrowsePicture(PictureBox pictureBox)
        {
            // Create a new OpenFileDialog for browsing the picture
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp", // Specify the file types you want to allow
                Title = "Select a Picture"
            };

            // Show the dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the selected image into the PictureBox
                    pictureBox.Image = Image.FromFile(openFileDialog.FileName);

                    // Optionally, adjust the size mode to fit the image nicely
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Adjusts the image size to fit within the PictureBox

                    // Display success message for debugging
                    MessageBox.Show("Image successfully loaded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Handle and display error if any issues occur while loading the image
                    MessageBox.Show("An error occurred while loading the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }





        //frm Customer-----------------------------------------------------------------










    }
}
