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
    public partial class frmListInventory : Form
    {
        public frmListInventory()
        {
            InitializeComponent();
            dgInventory.DataSource = frmMain.catalog;
        }

        private void dgInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListInventory_Load(object sender, EventArgs e)
        {

        }

    }
}
