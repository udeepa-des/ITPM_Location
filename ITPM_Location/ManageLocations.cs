using ITPM_Location.LocationClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ITPM_Location
{
    public partial class ManageLocations : Form
    {
        public ManageLocations()
        {
            InitializeComponent();
        }

        SQL c = new SQL();

        private void ManageLocations_Load(object sender, EventArgs e)
        {
            //load data on dataGridView
            DataTable dt = c.Select();
            dataGridView1.DataSource = dt;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //load data on dataGridView
            DataTable dt = c.Select();
            dataGridView1.DataSource = dt;

        }

    }
}
