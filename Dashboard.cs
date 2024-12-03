using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(String user)
        {
            InitializeComponent();
            if (user == "Guest")
            {
                btnAddItems.Hide();              
                btnUpdate.Hide();
                btnRemove.Hide();
                btnReport.Hide();
            }
            else if (user == "Admin")
            {
                btnAddItems.Show();
                btnUpdate.Show();
                btnRemove.Show();
                btnReport.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            uC_AddItems1.Visible = true;
            uC_AddItems1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddItems1.Visible = false;
            uC_PlaceOrder1.Visible = false;
            uC_UpdateItems1.Visible = false;
            uC_RemoveItem1.Visible = false;
            uC_Customer1.Visible = false;
            ucReport1.Visible = false;
        }

        private void uC_AddItems1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
           // uC_Welcome1.SendToBack();
            guna2Transition1.ShowSync(uC_PlaceOrder1);
            uC_PlaceOrder1.Visible = true;
            uC_PlaceOrder1.BringToFront();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            uC_UpdateItems1.Visible = true;
            uC_UpdateItems1.BringToFront();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            uC_RemoveItem1.Visible = true;
            uC_RemoveItem1.BringToFront();
        }

        private void uC_AddItems2_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_Welcome2.SendToBack();
            guna2Transition1.ShowSync(uC_Customer1);
            uC_Customer1.Visible = true;
            uC_Customer1.BringToFront();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ucReport1.Visible = true;
            ucReport1.BringToFront();
            //btnReport.Visible = true;
            //btnReport.BringToFront();
        }
    }
}
