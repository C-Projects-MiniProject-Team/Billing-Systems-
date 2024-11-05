using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Billing_System.Model
{
    public partial class frmSaleAdd : SampleAdd
    {
        public frmSaleAdd()
        {
            InitializeComponent();
        }
        private DataTable dataTable;


        private void frmSaleAdd_Load(object sender, EventArgs e)
        {
            Console.WriteLine("frmSaleAdd_Load triggered."); // Debugging

            // Populate the customer ComboBox
            string qry = "SELECT cusID, cName FROM tblCustomer";
            MainClass.Functions.CBFill_Sales(qry, PersonID);

            // Load product data
            string qry1 = @"SELECT proID, pName, pPrice FROM tblProduct ORDER BY pName";
            dataTable = MainClass.Functions.GetTable_Sales(qry1);

            if (dataTable == null || dataTable.Rows.Count == 0)
            {
                MessageBox.Show("No product data available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Attach the EditingControlShowing event to guna2DataGridView1
            guna2DataGridView1.EditingControlShowing += guna2DataGridView1_EditingControlShowing;

            // Load existing sale data if editID is set
            if (editID > 0)
            {
                LoadMainSaleData(editID);
                LoadSaleDetails(editID);
            }
        }



        // Event to handle the selection of a product and auto-fill its price


        // Event to auto-fill price when a product is selected
        private void ProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null)
            {
                DataRowView selectedRow = comboBox.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    // Assuming price is in column index 2 of guna2DataGridView2
                    guna2DataGridView1.CurrentRow.Cells[2].Value = selectedRow["pPrice"];
                }
            }
        }



        // Method to load main sale data (header information)
        // Ensure mDate, mDueDate, pType, etc. exist on the form, or rename accordingly
        private void LoadMainSaleData(int mainID)
        {
            try
            {
                string mainQuery = $"SELECT * FROM tblInvMain WHERE mainID = {mainID}";
                DataTable mainTable = MainClass.Functions.GetTable_Sales(mainQuery);

                if (mainTable.Rows.Count > 0)
                {
                    DataRow row = mainTable.Rows[0];
                    PersonID.SelectedValue = row["PersonID"]; // Set the selected customer in ComboBox

                    // Update these lines if mDate, mDueDate, pType are not named correctly
                    mDate.Text = Convert.ToDateTime(row["mDate"]).ToString("MM/dd/yyyy");
                    mDueDate.Text = Convert.ToDateTime(row["mDueDate"]).ToString("MM/dd/yyyy");
                    pType.Text = row["pType"].ToString();
                    mTotal.Text = row["mTotal"].ToString();
                    Discount.Text = row["Discount"].ToString();
                    NetAmount.Text = row["NetAmount"].ToString();
                }
                else
                {
                    MessageBox.Show("No main sale data found for this ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading main sale data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Method to load sale details data into the DataGridView
        private void LoadSaleDetails(int mainID)
        {
            try
            {
                string detailQuery = @"SELECT p.pName as 'Product Name', d.qty , d.Price, d.Amount 
                               FROM tblInvDetail d
                               INNER JOIN tblProduct p ON p.proID = d.proID
                               WHERE d.mainID = " + mainID;
                DataTable detailTable = MainClass.Functions.GetTable_Sales(detailQuery);
                guna2DataGridView1.DataSource = detailTable;

                // Customize column display settings
                guna2DataGridView1.Columns["proName"].Visible = false; //ust width for better readability

                guna2DataGridView1.Columns["qty"].Visible = false;
                guna2DataGridView1.Columns["Price"].Visible = false;
                guna2DataGridView1.Columns["Amount"].Visible = false;

                guna2DataGridView1.AutoResizeColumns(); // Adjust columns to fit data
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sale details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void GrandTotal()
        {
            {
                Double tot = 0;
                Double gtot = 0;
                mTotal.Text = "00";
                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                {
                    double.TryParse(Convert.ToString(row.Cells["Amount"].Value), out tot);
                    gtot += tot;
                }
                mTotal.Text = gtot.ToString("N0");
                double amt = 0;
                double dis = 0;

                double.TryParse(mTotal.Text, out amt);
                double.TryParse(Discount.Text, out dis);
                NetAmount.Text = (amt - dis).ToString("N0");
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {


            MainClass.Functions.MaskD_Sales(mDueDate);
        }

        private void InvlidN_Click(object sender, EventArgs e)
        {

        }

        private void uName_TextChanged(object sender, EventArgs e)
        {
            if (!false)
            {
                MainClass.Functions.MaskD_Sales(mDate);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }



        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Columns[e.ColumnIndex].Name == "qty") // Check if editing the Quantity column
            {
                int row = e.RowIndex;
                double price = 0, qty = 0;

                // Ensure Price column is visible before accessing it
                guna2DataGridView1.Columns["price"].Visible = true;

                // Get the value of Price and Quantity
                double.TryParse(Convert.ToString(guna2DataGridView1.Rows[row].Cells["price"].Value), out price);
                double.TryParse(Convert.ToString(guna2DataGridView1.Rows[row].Cells["qty"].Value), out qty);

                // Calculate and set the Amount
                guna2DataGridView1.Rows[row].Cells["Amount"].Value = qty * price;

                // Optionally, update the grand total after each edit
                GrandTotal();

                // Optionally, re-hide Price column if necessary
                // guna2DataGridView1.Columns["Price"].Visible = false;
            }
        }





        // Insert selected product info into guna2DataGridView1 when a row in guna2DataGridView2 is clicked
        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "proName" && e.RowIndex >= 0)
            {
                int row = guna2DataGridView1.CurrentCell.RowIndex;

                guna2DataGridView1.Rows[row].Cells["proName"].Value = guna2DataGridView2.Rows[e.RowIndex].Cells["pName"].Value;
                guna2DataGridView1.Rows[row].Cells["Price"].Value = guna2DataGridView2.Rows[e.RowIndex].Cells["pPrice"].Value;

                guna2DataGridView2.Visible = false; // Hide after selection
                guna2DataGridView1.CurrentCell = guna2DataGridView1.Rows[row].Cells["Qty"]; // Move focus to Qty column
                Console.WriteLine("guna2DataGridView2 item selected and added to guna2DataGridView1."); // Debugging
            }
        }




        // Show suggestions in guna2DataGridView2 based on user input
        private void guna2DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // Check if the current cell is in the "Product Name" column
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "proName") // Ensure column name matches
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.TextChanged -= textBox_TextChanged; // Detach to prevent multiple attachments
                    textBox.TextChanged += textBox_TextChanged; // Attach event for filtering
                }
            }
        }





        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            int row = guna2DataGridView1.CurrentCell.RowIndex;
            double price = 0, qty = 0;

            double.TryParse(Convert.ToString(guna2DataGridView1.Rows[row].Cells[5].Value), out price);
            double.TryParse(Convert.ToString(((TextBox)sender).Text), out qty);

            guna2DataGridView1.Rows[row].Cells[6].Value = qty * price;
            GrandTotal();
        }


        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string enteredProductName = textBox.Text;

            // Check if there is any input and if dataTable has product data
            if (!string.IsNullOrEmpty(enteredProductName) && dataTable != null)
            {
                // Find the row with a matching product name
                DataRow[] matchingRows = dataTable.Select($"pName LIKE '{enteredProductName}%'");

                if (matchingRows.Length > 0)
                {
                    // Get the first matching row's price
                    string price = matchingRows[0]["pPrice"].ToString();

                    // Ensure Price column is visible before assigning the value
                    guna2DataGridView1.Columns["Price"].Visible = true;

                    // Save the price in the "Price" column of the current row in guna2DataGridView1
                    guna2DataGridView1.CurrentRow.Cells["Price"].Value = price;
                }
            }
            else
            {
                // Clear the Price if input is empty
                guna2DataGridView1.CurrentRow.Cells["Price"].Value = null;
            }
        }











        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            MainClass.Functions.SrNo_Sales(guna2DataGridView1);
        }
        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            double amt = 0;
            double dis = 0;

            double.TryParse(mTotal.Text, out amt);
            double.TryParse(Discount.Text, out dis);
            NetAmount.Text = (amt - dis).ToString("N0");

        }
        public override void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (editID == 0)
                {
                    // Call SQLAutoSale_SalesAsync for Insert operation
                    MainClass.Functions.SQLAutoSale_Sales(this, "tblInvMain", "tblInvDetail", guna2DataGridView1, editID, MainClass.Functions.enmType.Insert);

                    // If payment type is cash, add an entry to tblPayment
                    if (pType.Text.ToLower() == "cash")
                    {
                        // Asynchronously get the latest bill number
                        string billQuery = @"SELECT MAX(mainID) AS max FROM tblInvMain";
                        DataTable dt = MainClass.Functions.GetTable_Sales(billQuery);
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            string bill_no = dt.Rows[0]["max"].ToString();
                            mainID.Text = bill_no;

                            // Set description for receipt entry
                            description.Text = "Payment received against bill number " + bill_no;

                            // Asynchronously add entry to tblReceipt
                            MainClass.Functions.AutoSQL_Sales(this, "tblReceipt", MainClass.Functions.enmType.Insert, editID);
                        }
                    }
                }
                else
                {
                    // Call SQLAutoSale_SalesAsync for Update operation
                    MainClass.Functions.SQLAutoSale_Sales(this, "tblInvMain", "tblInvDetail", guna2DataGridView1, editID, MainClass.Functions.enmType.Update);
                }

                // Clear DataGridView and reset editID after operation
                guna2DataGridView1.Rows.Clear();
                editID = 0;
                MainClass.Functions.Reset_All_Sales(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in btnSave_Click: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)
        {
            MainClass.Functions.SQLAuto2_Sales(this, "tblInvMain", "tblInvDetail", guna2DataGridView1, editID, MainClass.Functions.enmType.Delete);
            guna2DataGridView1.Rows.Clear();
            editID = 0;
            MainClass.Functions.Reset_All_Sales(this);
        }

        private void mType_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}