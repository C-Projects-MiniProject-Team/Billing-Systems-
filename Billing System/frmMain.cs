using Billing_System.View;
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
    public partial class frmMain : Sample
    {
        public static object Instance { get; internal set; }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addNewPanel.Visible = true;


        }

        private void addNewPanel_MouseEnter(object sender, EventArgs e)
        {
            addNewPanel.Visible = false;
        }

        private void userRole_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddControls(Form F)
        {
            CentralPannel.Controls.Clear();
            F.TopLevel = false;
            F.Dock = DockStyle.Fill;
            CentralPannel.Controls.Add(F);
            F.Show();

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            AddControls(new frmProduct());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            
            AddControls(new frmUser());
           
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            AddControls(new frmSales());
        }
    }
}
