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
    public partial class AddLocation : Form
    {
        string RoomType;

        public AddLocation()
        {
            InitializeComponent();
        }

        SQL c = new SQL();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RoomType = "Lecture Hall";
        }

        private void radioButtonLabRoomType_CheckedChanged(object sender, EventArgs e)
        {
            RoomType = "Laboratory";
        }

        private void textBoxRoomName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Get the values from the input fields
            c.BName = textBoxBuildingName.Text;
            c.RName = textBoxRoomName.Text;
            c.RType = RoomType;
            c.Capacity = textBoxCapacity.Text;
           

            //inserting data into db using SQL class file
            bool success = c.Insert(c);
            if(success == true)
            {
                //Successfully inserted
                MessageBox.Show("New Location Added.");
            }
            else
            {
                //Failed to Add Contact
                MessageBox.Show("Failed to add new Location. Try Again");
            }

            //to clear fields


        }

    }
}
