using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoSales.UI
{
    public partial class frmMain : Form
    {
        public static List<AutoSales.Library.Vehicle> catalog = new List<AutoSales.Library.Vehicle>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToCatalogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddVehicle frm = new frmAddVehicle();
            frm.MdiParent = this; //"this" indicates the current class frmMain
            frm.Show();
        }

        private void listInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListInventory frm = new frmListInventory();
            frm.MdiParent = this;
            frm.Show();
        }

    }
}
