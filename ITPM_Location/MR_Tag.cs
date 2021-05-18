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
    public partial class MR_Tag : Form
    {

        SQL c = new SQL();
        public MR_Tag()
        {
            InitializeComponent();
        }

        private void MR_Tag_Load(object sender, EventArgs e)
        {
            DataTable dt = c.comboBoxTag();
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1Tag.Items.Add(dr["Tag"].ToString());
            }

            DataTable dtr = c.comboBoxRoom();
            foreach (DataRow dr in dtr.Rows)
            {
                comboBox2Tag.Items.Add(dr["RoomName"].ToString());
            }
        }

        private void comboBox1Tag_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Step 1: DB connection
            string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            //Step 2: Writing sql query
            string sql = "SELECT DISTINCT Tag FROM Tag where Tag='" + comboBox1Tag.SelectedItem.ToString() + "'";
            //Creating cmd using sql and conn
            SqlCommand cmd = new SqlCommand(sql, conn);
            //Creating SQL DataAdapter using cmd
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox1Tag.AppendText("\t" + dr["Tag"].ToString() + "\t");
            }
        }

        private void comboBox2Tag_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Step 1: DB connection

            string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            //Step 2: Writing sql query
            string sql = "SELECT DISTINCT RoomName FROM Add_Location where RoomName='" + comboBox2Tag.SelectedItem.ToString() + "'";
            //Creating cmd using sql and conn
            SqlCommand cmd = new SqlCommand(sql, conn);
            //Creating SQL DataAdapter using cmd
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox1Tag.AppendText("\t" + dr["RoomName"].ToString() + "\t");
            }
        }

        private void buttonClearTag_Click(object sender, EventArgs e)
        {
            comboBox1Tag.SelectedIndex = 0;
            comboBox2Tag.SelectedIndex = 0;
            textBox1Tag.Text = "";
        }

        private void buttonSubmitTag_Click(object sender, EventArgs e)
        {
            //Get the values from the input fields
            c.LT_Tag = comboBox1Tag.Text;
            c.LT_RoomName = comboBox2Tag.Text;

            //inserting data into db using SQL class file
            bool success = c.InsertToLocation_Tag(c);
            if (success == true)
            {
                //Successfully inserted
                MessageBox.Show("New Room Added for the Tag.");

                //clear if success
                comboBox1Tag.SelectedIndex = 0;
                comboBox2Tag.SelectedIndex = 0;
                textBox1Tag.Text = "";
            }
            else
            {
                //Failed to Add Contact
                MessageBox.Show("Oops!..Failed to add a room for the Tag. Try Again");
            }
        }
    }
}
