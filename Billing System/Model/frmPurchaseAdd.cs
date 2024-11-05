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
    public partial class frmPurchaseAdd : SampleAdd
    {
        public frmPurchaseAdd()
        {
            InitializeComponent();
        }

        //For search product gridview
        private DataTable dataTable;

        private void frmPurchaseAdd_Load(object sender, EventArgs e)
        {
            //Add Supplier to combobox
            string qry = "select supID 'id', sName 'name' from tblSupplier";
            MainClass.Functions.CBFill(qry, PersonID);

            string qry1 = @"select proID, pName 'Product', pCost 'Cost' from tblProduct order by pName";
            dataTable = MainClass.Functions.GetTable_Purchases(qry1);    
            guna2DataGridView2.DataSource = dataTable;
            guna2DataGridView2.Columns[0].Visible = false; //Hide id column
            guna2DataGridView2.Columns[2].Width = 90; //Product name
            guna2DataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 112, 248);

            //For edit load data
            if (editID > 0)
            {
                string qry2 = @"select detailID, d.proID, pName, qty, Price, Amount from tblInvDetail d
                    inner join tblProduct p on p.proID = d.proID
                    where d.mainID = " + editID + "";
                MainClass.Functions.LoadForEdit2_Purchases(this, "tblInvMain", qry2, guna2DataGridView1, editID);
            }
        }

        private void GrandTotal()
        {
            Double tot = 0;
            Double gtot = 0;
            mTotal.Text = "00";
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                double.TryParse(Convert.ToString(row.Cells["Amount"].Value), out tot);
                gtot += tot;
            }
            mTotal.Text = gtot.ToString("No");
            double amt = 0;
            double dis = 0;

            double.TryParse(mTotal.Text, out amt);
            double.TryParse(Discount.Text, out dis);
            NetAmount.Text = (amt - dis).ToString("No");
        }


        private void guna2DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // this will calculate amount by multiple qty cell with price cell
            int row = guna2DataGridView1.CurrentCell.RowIndex;
            double price, qty = 0;
            double.TryParse(Convert.ToString(guna2DataGridView1.Rows[row].Cells[5].Value), out price);
            double.TryParse(Convert.ToString(guna2DataGridView1.Rows[row].Cells[4].Value), out qty);

            guna2DataGridView1.Rows[row].Cells[6].Value = qty * price;
        }

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // when click on search grid the add those row value to gridview 1

            if (guna2DataGridView1.CurrentCell.ColumnIndex == 3)
            {
                int row = guna2DataGridView1.CurrentCell.RowIndex;

                //insert value to gridview1
                guna2DataGridView1.Rows[row].Cells[2].Value = guna2DataGridView2.CurrentRow.Cells[0].Value; //pro id
                guna2DataGridView1.Rows[row].Cells[5].Value = guna2DataGridView2.CurrentRow.Cells[2].Value; //price
                guna2DataGridView1.CurrentCell.Value = guna2DataGridView2.CurrentRow.Cells[1].Value; //product name

                guna2DataGridView2.Visible = false;

                if (Convert.ToString(guna2DataGridView1.Rows[row].Cells[1].Value) ==String.Empty)
                {
                    guna2DataGridView1.Rows[row].Cells[1].Value = 0; //id if is null then add zero
                }

            }
            GrandTotal();
        }

        private void guna2DataGridView3_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // when click on cell the make visible search gridview
            guna2DataGridView2.Visible = true;

            if (guna2DataGridView1.CurrentCell.ColumnIndex == 3)
            {
                if (e.Control is TextBox)
                {
                    TextBox textBox = (TextBox)e.Control;
                    textBox.TextChanged -= textBox_TextChanged;
                    textBox.TextChanged += textBox_TextChanged;
                }
            }

            if (guna2DataGridView1.CurrentCell.ColumnIndex == 5)
            {
                int row = guna2DataGridView1.CurrentCell.RowIndex;

                double price, qty = 0;
                double.TryParse(Convert.ToString(guna2DataGridView1.Rows[row].Cells[5].Value), out price);
                double.TryParse(Convert.ToString(guna2DataGridView1.Rows[row].Cells[4].Value), out qty);

                guna2DataGridView1.Rows[row].Cells[6].Value = qty * price;
            }
            GrandTotal();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            // check if the column is product name the search grid appear
            int colIndex = guna2DataGridView1.CurrentCell.ColumnIndex;
            TextBox textBox = (TextBox)sender;
            string content = textBox.Text;

            if (colIndex ==3)
            {
                guna2DataGridView2.Visible = true;
            }

            //Filter gridview2

            DataView dataView = dataTable.DefaultView;
            dataView.RowFilter = string.Format("Product LIKE '%{0}%'", content);

            //Check current cell location and display grid under the cell
            Rectangle cellRect = guna2DataGridView1.GetCellDisplayRectangle(guna2DataGridView1.CurrentCell.ColumnIndex, guna2DataGridView1.CurrentCell.RowIndex, false);

            int centerX = cellRect.Left + 30;
            int centerY = cellRect.Top + 230;

            guna2DataGridView2.Location = new Point(centerX, centerY);
            guna2DataGridView2.CellClick += guna2DataGridView2_CellClick;
        }
    }
}
