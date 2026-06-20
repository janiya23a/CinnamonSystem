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
    public partial class dashboardform : Form
    {
        public dashboardform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrading_Click(object sender, EventArgs e)
        {
            GradingForm grading = new GradingForm();
            grading.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuGrading_Click(object sender, EventArgs e)
        {

        }

        private void dashboardform_Load(object sender, EventArgs e)
        {

        }
    }
}
