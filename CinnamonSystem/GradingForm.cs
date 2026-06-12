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
                // emply check
                if (cmbWorkers.SelectedIndex == -1 || txtDiameter.Text == "" || txtWeight.Text == "")
                {
                    MessageBox.Show("Please fill in all fields and select a worker.");
                    return;
                }

                // values
                double diameter = Convert.ToDouble(txtDiameter.Text);
                double weight = Convert.ToDouble(txtWeight.Text);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid numbers for diameter and weight.");
            }
        }
    }
}
