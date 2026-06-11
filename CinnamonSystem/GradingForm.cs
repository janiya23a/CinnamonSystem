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
                // diameter
                double diameter = Convert.ToDouble(txtDiameter.Text);

                // grade
                if (diameter < 6)
                {
                    txtGrade.Text = "Alba (Premium)";
                }
                else if (diameter < 16)
                {
                    txtGrade.Text = "Continental";
                }
                else
                {
                    txtGrade.Text = "Low Grade / Ordinary";
                }
            }
            catch (Exception ex)
            {
                // erros
                MessageBox.Show("Please enter a valid number for the diameter.");
            }
        }
    }
}
