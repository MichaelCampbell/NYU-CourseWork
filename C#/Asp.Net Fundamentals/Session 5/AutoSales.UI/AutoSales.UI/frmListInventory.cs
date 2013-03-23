using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
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

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"F:\";//@"C:\Users\NYUSCPS\Desktop\";
            saveFileDialog1.Title = "Save CSV File";
            //saveFileDialog1.CheckFileExists = false;
            //saveFileDialog1.CheckPathExists = false;
            saveFileDialog1.CreatePrompt = true;
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, true);
                foreach (AutoSales.Library.Vehicle v in frmMain.catalog)
                {
                    sw.WriteLine(v.Color + "," + v.Make + "," + v.Model + "," + v.Price + "," + v.Year);
                }
                sw.Dispose();
            }
        }

    }
}
