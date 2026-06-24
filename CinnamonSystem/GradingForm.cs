using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
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
                //  check empty
                if (cmbWorkers.SelectedIndex == -1 || txtDiameter.Text == "" || txtWeight.Text == "" || txtMoisture.Text == "")
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // values
                string worker = cmbWorkers.SelectedItem.ToString();
                double diameter = Convert.ToDouble(txtDiameter.Text);
                double weight = Convert.ToDouble(txtWeight.Text);
                double moisture = Convert.ToDouble(txtMoisture.Text);
                double pricePerKg = 0;

                //  grading
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

                double totalPayout = weight * pricePerKg;
                txtPayout.Text = totalPayout.ToString();

                //  conect xamp
                string connString = "server=localhost;database=cinnamon_db;uid=root;pwd=;";
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    string query = "INSERT INTO grading_records (worker_name, diameter, weight, moisture, grade, payout) VALUES (@worker, @dia, @wt, @moist, @grade, @pay)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@worker", worker);
                        cmd.Parameters.AddWithValue("@dia", diameter);
                        cmd.Parameters.AddWithValue("@wt", weight);
                        cmd.Parameters.AddWithValue("@moist", moisture);
                        cmd.Parameters.AddWithValue("@grade", txtGrade.Text);
                        cmd.Parameters.AddWithValue("@pay", totalPayout);

                        cmd.ExecuteNonQuery();
                    }
                }

                //  moisture alert
                if (moisture > 12)
                {
                    MessageBox.Show("⚠️ MOISTURE ALERT: Saved to database, but batch needs more drying!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("✅ Record saved successfully to XAMPP database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtMoisture_TextChanged(object sender, EventArgs e)
        {

        }

        private void GradingForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

            private void button2_Click(object sender, EventArgs e)
        {
           
            cmbWorkers.SelectedIndex = -1;

            // cleat all textbx
            txtDiameter.Text = "";
            txtWeight.Text = "";
            txtMoisture.Text = "";

            // clear all ouput cal
            txtGrade.Text = "";
            txtPayout.Text = "";

            // cursor center
            cmbWorkers.Focus();
        }
    }
    
}
