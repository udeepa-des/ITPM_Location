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
using System.Data.SqlClient;
using System.Configuration;

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

            //adding check boxes to consecutive sessions

            DataGridViewCheckBoxColumn chckboxCon = new DataGridViewCheckBoxColumn();
            chckboxCon.HeaderText = "";
            chckboxCon.Width = 30;
            chckboxCon.Name = "SelectCon";
            dataGridView1Con.Columns.Insert(0, chckboxCon);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = c.Select_consecutive_sessions();
            dataGridView1CS.DataSource = dt;
            textBoxHidden_CS.Text = "";
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
            textBoxHidden_CS.Text = "ID: " + dataGridView1Con.Rows[rowIndex].Cells[1].Value.ToString() + ",\r\n" +  "Tag: " + dataGridView1Con.Rows[rowIndex].Cells[4].Value.ToString() + ",\r\n" + "Subject Code: " + dataGridView1Con.Rows[rowIndex].Cells[7].Value.ToString();

        }

        private void dataGridView1Con_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1Con_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
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
            textBoxHiddenCon.Text = "";
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridView1Con.Rows)
            {
                bool selected = Convert.ToBoolean(dr.Cells["SelectCon"].Value);
                if (selected)
                {
                   textBoxHiddenCon.AppendText("Tag: " + dr.Cells[4].Value.ToString() + ",  " + "Subject Code: " + dr.Cells[7].Value.ToString() + " |\r\n");
                                        
                }
                    
            }
        }

        private void button3session_Click(object sender, EventArgs e)
        {

        }
    }
}
