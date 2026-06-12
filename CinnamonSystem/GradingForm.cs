using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinnamonSystem
{
    public partial class GradingForm : Form
    {
        public GradingForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // empty
                if (cmbWorkers.SelectedIndex == -1 || txtDiameter.Text == "" || txtWeight.Text == "" || txtMoisture.Text == "")
                {
                    MessageBox.Show("Please fill in all fields including moisture percentage.");
                    return;
                }

                // values
                double diameter = Convert.ToDouble(txtDiameter.Text);
                double weight = Convert.ToDouble(txtWeight.Text);
                double moisture = Convert.ToDouble(txtMoisture.Text);
                double pricePerKg = 0;

                // grading
                if (diameter < 6)
                {
                    txtGrade.Text = "Alba (Premium)";
                    pricePerKg = 4500;
                }
                else if (diameter < 16)
                {
                    txtGrade.Text = "Continental";
                    pricePerKg = 3000;
                }
                else
                {
                    txtGrade.Text = "Low Grade";
                    pricePerKg = 1500;
                }

                // money
                double totalPayout = weight * pricePerKg;
                txtPayout.Text = totalPayout.ToString();

                // Mmoisture drying alert
                if (moisture > 12)
                {
                    MessageBox.Show("⚠️ MOISTURE ALERT: This batch has " + moisture + "% moisture. It needs more drying before it can be exported!", "Drying Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("✅ Moisture level is perfect (" + moisture + "%). Ready for packaging!", "Moisture Check Pass", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid numbers for diameter, weight, and moisture.");
            }
        }

        private void txtMoisture_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
