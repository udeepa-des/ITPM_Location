using ITPM_Location.LocationClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITPM_Location
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        SQL c = new SQL();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chartStat_Click(object sender, EventArgs e)
        {

        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            DataTable lab = c.LabForChart();
            DataTable lec = c.LecHallForChart();
            int rows = c.GetNoOfRows();
            int labRows = c.GetNoOfRowsOfLab();
            int lecRows = c.GetNoOfRowsofLecHall();

            int i=0;
            int x=0;

            if (rows >= 1)
            {
                x = Convert.ToInt32(lec.Rows[lecRows - 1]["No"].ToString());
                chartStat.Series["Lecture Hall"].Points.AddXY("Location", x);

                i = Convert.ToInt32(lab.Rows[labRows - 1]["Numbers"].ToString());
                chartStat.Series["Laboratory"].Points.AddXY("Location", i);
            }
            else
            {
                MessageBox.Show("Empty");
            }
            
        }

    }
}
