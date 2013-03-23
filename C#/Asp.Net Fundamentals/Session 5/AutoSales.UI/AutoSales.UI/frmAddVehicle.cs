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
    public partial class frmAddVehicle : Form
    {
        public frmAddVehicle()
        {
            InitializeComponent();
        }

        private void frmAddVehicle_Load(object sender, EventArgs e)
        {
            numericYear.Maximum = (decimal)DateTime.Today.Year;
            numericYear.Minimum = 1960;
            numericYear.Value = (decimal)DateTime.Today.Year - 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnColorPicker_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                textColor.Text = colorDialog1.Color.ToKnownColor().ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutoSales.Library.Vehicle v = new Library.Vehicle();
            v.Make = textMake.Text;
            v.Model = textModel.Text;
            v.Year = (uint)numericYear.Value;
            v.Price = Convert.ToDecimal(masktxtPrice.Text);

            try //convert the user-supplied color to the enum value
            {
                Type t = typeof(AutoSales.Library.ColorEnum);
                object obj = Enum.Parse(t, textColor.Text);
                v.Color = (AutoSales.Library.ColorEnum)obj;
            }
            catch
            {
                v.Color = AutoSales.Library.ColorEnum.Other;
            }

            frmMain.catalog.Add(v);
            this.Close();
        }

        private void textMake_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
