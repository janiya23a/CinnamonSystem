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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  check if the username and password are empty
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please enter both Username and Password.");
                return;
            }

            //  check for the admin credentials
            if (textBox1.Text == "admin" && textBox2.Text == "123")
            {
                MessageBox.Show("Login Successful!");

                dashboardform dashboard = new dashboardform();
                dashboard.Show();

                // hide login
                this.Hide();


            }
            else
            {
                MessageBox.Show("Wrong username or password. Try again.");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
