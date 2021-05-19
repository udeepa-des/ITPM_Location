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
    public partial class Nav : Form
    {
        public Nav()
        {
            InitializeComponent();
        }

        private void buttonSubjects_Click(object sender, EventArgs e)
        {
            MR_Subject sub = new MR_Subject();
            sub.Show();
        }

        private void buttonTag_Click(object sender, EventArgs e)
        {
            MR_Tag tag = new MR_Tag();
            tag.Show();
        }

        private void buttonLecturer_Click(object sender, EventArgs e)
        {
            MR_Lecturer lec = new MR_Lecturer();
            lec.Show();
        }

        private void buttonGroup_Click(object sender, EventArgs e)
        {
            MR_Group grp = new MR_Group();
            grp.Show();
        }

        private void buttonSession_Click(object sender, EventArgs e)
        {
            MR_Session session = new MR_Session();
            session.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            T_and_Sub ts = new T_and_Sub();
            ts.Show();
        }

        private void buttonConsecutive_Session_Click(object sender, EventArgs e)
        {
            MR_Consecutive_Sessions cs = new MR_Consecutive_Sessions();
            cs.Show();
        }
    }
}
