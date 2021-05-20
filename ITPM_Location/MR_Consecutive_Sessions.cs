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

            DataGridViewCheckBoxColumn chckbox = new DataGridViewCheckBoxColumn();
            chckbox.HeaderText = "";
            chckbox.Width = 30;
            chckbox.Name = "SelectSession";
            dataGridView1CS.Columns.Insert(0, chckbox);

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
            textBoxHidden_CS.Text = dataGridView1CS.Rows[rowIndex].Cells[1].Value.ToString();
           
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

        private void button1_Click(object sender, EventArgs e)
        {
            string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            SqlConnection conn = new SqlConnection(myconnstring);

            foreach (DataGridViewRow dr in dataGridView1Con.Rows)
            {
                bool selected = Convert.ToBoolean(dr.Cells["SelectCon"].Value);
                if (selected)
                {
                   textBoxHiddenCon.AppendText("Tag: " + dr.Cells[4].Value.ToString() + "  " + "Subject Code: " + dr.Cells[7].Value.ToString() + "\r\n");

                    /*string sql = "INSERT INTO session_test(Lecturer_Name1, Lecturer_Name2, Tag, Group_ID, Subject_Name, Subject_code, No_Of_Students, Duration) VALUES (@LecName1, @LecName2, @tag, @gID, @sName, @sCode, @NoStudents, @duration)";

                    //Creating SQL commandusing sql and conn
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    //Create Parameter to add data
                    cmd.Parameters.AddWithValue("@LecName1", dr.Cells[2].Value);
                    cmd.Parameters.AddWithValue("@LecName2", dr.Cells[3].Value);
                    cmd.Parameters.AddWithValue("@tag", dr.Cells[4].Value);
                    cmd.Parameters.AddWithValue("@gID", dr.Cells[5].Value);
                    cmd.Parameters.AddWithValue("@sName", dr.Cells[6].Value);
                    cmd.Parameters.AddWithValue("@sCode", dr.Cells[7].Value);
                    cmd.Parameters.AddWithValue("@NoStudents", dr.Cells[8].Value);
                    cmd.Parameters.AddWithValue("@duration", dr.Cells[8].Value);

                    //Open the connection
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    */
                }
                    
            }
        }
    }
}
