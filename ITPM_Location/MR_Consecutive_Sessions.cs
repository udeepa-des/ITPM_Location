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

    public partial class MR_Consecutive_Sessions : Form
    {
        SQL c = new SQL();
        MR_Session s = new MR_Session();
        public MR_Consecutive_Sessions()
        {
            InitializeComponent();
        }

        private void MR_Consecutive_Sessions_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select_consecutive_sessions();
            dataGridView1CS.DataSource = dt;
            dataGridView1Con.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = c.Select_consecutive_sessions();
            dataGridView1CS.DataSource = dt;
        }

        public static string sendtext = "";
        public static bool success = false;
        private void buttonAdd_Room_Click(object sender, EventArgs e)
        {
            success = true;
            sendtext = textBoxHidden_CS.Text;
            MR_Session session = new MR_Session();
            session.Show();

        }

        private void dataGridView1CS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1CS_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBoxHidden_CS.Text = dataGridView1CS.Rows[rowIndex].Cells[0].Value.ToString();
           
        }

        private void dataGridView1Con_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1Con_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            textBoxHiddenCon.Text = dataGridView1Con.Rows[rowIndex].Cells[0].Value.ToString();
        }

        private void ConsecutivePage_Click(object sender, EventArgs e)
        {
            
        }

        private void Sessions_Click(object sender, EventArgs e)
        {

        }

        private void button1RefreshCon_Click(object sender, EventArgs e)
        {
            DataTable dt = c.Select_consecutive_sessions();
            dataGridView1Con.DataSource = dt;
        }


        public static string sendtextCon = "";
        public static bool successCon = false;
        private void button3AddRoomCon_Click(object sender, EventArgs e)
        {
            successCon = true;
            sendtextCon = textBoxHiddenCon.Text;
            MR_Add_Consecutive_Sessions sessionCon = new MR_Add_Consecutive_Sessions();
            sessionCon.Show();
        }
    }
}
