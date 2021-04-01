
namespace ITPM_Location
{
    partial class Statistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxStat = new System.Windows.Forms.GroupBox();
            this.textBoxSubjectBoxStat = new System.Windows.Forms.TextBox();
            this.textBoxLatestGroupBoxStat = new System.Windows.Forms.TextBox();
            this.textBoxLecturerBoxStat = new System.Windows.Forms.TextBox();
            this.lableSubjectBoxStat = new System.Windows.Forms.Label();
            this.lableLatestGroupBoxStat = new System.Windows.Forms.Label();
            this.lableLecturerBoxStat = new System.Windows.Forms.Label();
            this.labelRegisteredLecturersStat = new System.Windows.Forms.Label();
            this.labelRegisteredStudentsStat = new System.Windows.Forms.Label();
            this.labelRegisteredSubjectsStat = new System.Windows.Forms.Label();
            this.labelRegisteredRoomsStat = new System.Windows.Forms.Label();
            this.chartStat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StatRO_lecturers = new System.Windows.Forms.TextBox();
            this.StatRO_rooms = new System.Windows.Forms.TextBox();
            this.StatRO_subjects = new System.Windows.Forms.TextBox();
            this.StatRO_students = new System.Windows.Forms.TextBox();
            this.groupBoxStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxStat
            // 
            this.groupBoxStat.Controls.Add(this.textBoxSubjectBoxStat);
            this.groupBoxStat.Controls.Add(this.textBoxLatestGroupBoxStat);
            this.groupBoxStat.Controls.Add(this.textBoxLecturerBoxStat);
            this.groupBoxStat.Controls.Add(this.lableSubjectBoxStat);
            this.groupBoxStat.Controls.Add(this.lableLatestGroupBoxStat);
            this.groupBoxStat.Controls.Add(this.lableLecturerBoxStat);
            this.groupBoxStat.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStat.Location = new System.Drawing.Point(554, 303);
            this.groupBoxStat.Name = "groupBoxStat";
            this.groupBoxStat.Size = new System.Drawing.Size(520, 406);
            this.groupBoxStat.TabIndex = 2;
            this.groupBoxStat.TabStop = false;
            this.groupBoxStat.Text = "What\'s New";
            this.groupBoxStat.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxSubjectBoxStat
            // 
            this.textBoxSubjectBoxStat.Location = new System.Drawing.Point(183, 299);
            this.textBoxSubjectBoxStat.Name = "textBoxSubjectBoxStat";
            this.textBoxSubjectBoxStat.Size = new System.Drawing.Size(309, 28);
            this.textBoxSubjectBoxStat.TabIndex = 7;
            // 
            // textBoxLatestGroupBoxStat
            // 
            this.textBoxLatestGroupBoxStat.Location = new System.Drawing.Point(183, 196);
            this.textBoxLatestGroupBoxStat.Name = "textBoxLatestGroupBoxStat";
            this.textBoxLatestGroupBoxStat.Size = new System.Drawing.Size(309, 28);
            this.textBoxLatestGroupBoxStat.TabIndex = 6;
            // 
            // textBoxLecturerBoxStat
            // 
            this.textBoxLecturerBoxStat.Location = new System.Drawing.Point(183, 102);
            this.textBoxLecturerBoxStat.Name = "textBoxLecturerBoxStat";
            this.textBoxLecturerBoxStat.Size = new System.Drawing.Size(309, 28);
            this.textBoxLecturerBoxStat.TabIndex = 3;
            // 
            // lableSubjectBoxStat
            // 
            this.lableSubjectBoxStat.AutoSize = true;
            this.lableSubjectBoxStat.Font = new System.Drawing.Font("Montserrat", 10.2F);
            this.lableSubjectBoxStat.Location = new System.Drawing.Point(29, 305);
            this.lableSubjectBoxStat.Name = "lableSubjectBoxStat";
            this.lableSubjectBoxStat.Size = new System.Drawing.Size(134, 20);
            this.lableSubjectBoxStat.TabIndex = 5;
            this.lableSubjectBoxStat.Text = "Latest Subject";
            // 
            // lableLatestGroupBoxStat
            // 
            this.lableLatestGroupBoxStat.AutoSize = true;
            this.lableLatestGroupBoxStat.Font = new System.Drawing.Font("Montserrat", 10.2F);
            this.lableLatestGroupBoxStat.Location = new System.Drawing.Point(29, 202);
            this.lableLatestGroupBoxStat.Name = "lableLatestGroupBoxStat";
            this.lableLatestGroupBoxStat.Size = new System.Drawing.Size(121, 20);
            this.lableLatestGroupBoxStat.TabIndex = 4;
            this.lableLatestGroupBoxStat.Text = "Latest Group";
            // 
            // lableLecturerBoxStat
            // 
            this.lableLecturerBoxStat.AutoSize = true;
            this.lableLecturerBoxStat.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableLecturerBoxStat.Location = new System.Drawing.Point(29, 108);
            this.lableLecturerBoxStat.Name = "lableLecturerBoxStat";
            this.lableLecturerBoxStat.Size = new System.Drawing.Size(142, 20);
            this.lableLecturerBoxStat.TabIndex = 3;
            this.lableLecturerBoxStat.Text = "Latest Lecturer";
            // 
            // labelRegisteredLecturersStat
            // 
            this.labelRegisteredLecturersStat.AutoSize = true;
            this.labelRegisteredLecturersStat.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegisteredLecturersStat.Location = new System.Drawing.Point(44, 212);
            this.labelRegisteredLecturersStat.Name = "labelRegisteredLecturersStat";
            this.labelRegisteredLecturersStat.Size = new System.Drawing.Size(191, 20);
            this.labelRegisteredLecturersStat.TabIndex = 4;
            this.labelRegisteredLecturersStat.Text = "Registered Lecturers";
            // 
            // labelRegisteredStudentsStat
            // 
            this.labelRegisteredStudentsStat.AutoSize = true;
            this.labelRegisteredStudentsStat.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelRegisteredStudentsStat.Location = new System.Drawing.Point(313, 212);
            this.labelRegisteredStudentsStat.Name = "labelRegisteredStudentsStat";
            this.labelRegisteredStudentsStat.Size = new System.Drawing.Size(186, 20);
            this.labelRegisteredStudentsStat.TabIndex = 5;
            this.labelRegisteredStudentsStat.Text = "Registered Students";
            // 
            // labelRegisteredSubjectsStat
            // 
            this.labelRegisteredSubjectsStat.AutoSize = true;
            this.labelRegisteredSubjectsStat.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelRegisteredSubjectsStat.Location = new System.Drawing.Point(609, 212);
            this.labelRegisteredSubjectsStat.Name = "labelRegisteredSubjectsStat";
            this.labelRegisteredSubjectsStat.Size = new System.Drawing.Size(184, 20);
            this.labelRegisteredSubjectsStat.TabIndex = 6;
            this.labelRegisteredSubjectsStat.Text = "Registered Subjects";
            // 
            // labelRegisteredRoomsStat
            // 
            this.labelRegisteredRoomsStat.AutoSize = true;
            this.labelRegisteredRoomsStat.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelRegisteredRoomsStat.Location = new System.Drawing.Point(878, 212);
            this.labelRegisteredRoomsStat.Name = "labelRegisteredRoomsStat";
            this.labelRegisteredRoomsStat.Size = new System.Drawing.Size(168, 20);
            this.labelRegisteredRoomsStat.TabIndex = 7;
            this.labelRegisteredRoomsStat.Text = "Registered Rooms";
            // 
            // chartStat
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStat.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStat.Legends.Add(legend1);
            this.chartStat.Location = new System.Drawing.Point(12, 303);
            this.chartStat.Name = "chartStat";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartStat.Series.Add(series1);
            this.chartStat.Size = new System.Drawing.Size(520, 406);
            this.chartStat.TabIndex = 0;
            this.chartStat.Text = "chart1";
            // 
            // StatRO_lecturers
            // 
            this.StatRO_lecturers.Location = new System.Drawing.Point(95, 97);
            this.StatRO_lecturers.Name = "StatRO_lecturers";
            this.StatRO_lecturers.ReadOnly = true;
            this.StatRO_lecturers.Size = new System.Drawing.Size(100, 22);
            this.StatRO_lecturers.TabIndex = 8;
            this.StatRO_lecturers.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // StatRO_rooms
            // 
            this.StatRO_rooms.Location = new System.Drawing.Point(910, 97);
            this.StatRO_rooms.Name = "StatRO_rooms";
            this.StatRO_rooms.ReadOnly = true;
            this.StatRO_rooms.Size = new System.Drawing.Size(100, 22);
            this.StatRO_rooms.TabIndex = 9;
            // 
            // StatRO_subjects
            // 
            this.StatRO_subjects.Location = new System.Drawing.Point(652, 97);
            this.StatRO_subjects.Name = "StatRO_subjects";
            this.StatRO_subjects.ReadOnly = true;
            this.StatRO_subjects.Size = new System.Drawing.Size(100, 22);
            this.StatRO_subjects.TabIndex = 11;
            // 
            // StatRO_students
            // 
            this.StatRO_students.Location = new System.Drawing.Point(358, 97);
            this.StatRO_students.Name = "StatRO_students";
            this.StatRO_students.ReadOnly = true;
            this.StatRO_students.Size = new System.Drawing.Size(100, 22);
            this.StatRO_students.TabIndex = 12;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 733);
            this.Controls.Add(this.StatRO_students);
            this.Controls.Add(this.StatRO_subjects);
            this.Controls.Add(this.StatRO_rooms);
            this.Controls.Add(this.StatRO_lecturers);
            this.Controls.Add(this.labelRegisteredRoomsStat);
            this.Controls.Add(this.labelRegisteredSubjectsStat);
            this.Controls.Add(this.labelRegisteredStudentsStat);
            this.Controls.Add(this.labelRegisteredLecturersStat);
            this.Controls.Add(this.groupBoxStat);
            this.Controls.Add(this.chartStat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Statistics";
            this.Text = "Form1";
            this.groupBoxStat.ResumeLayout(false);
            this.groupBoxStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxStat;
        private System.Windows.Forms.TextBox textBoxSubjectBoxStat;
        private System.Windows.Forms.TextBox textBoxLatestGroupBoxStat;
        private System.Windows.Forms.TextBox textBoxLecturerBoxStat;
        private System.Windows.Forms.Label lableSubjectBoxStat;
        private System.Windows.Forms.Label lableLatestGroupBoxStat;
        private System.Windows.Forms.Label lableLecturerBoxStat;
        private System.Windows.Forms.Label labelRegisteredLecturersStat;
        private System.Windows.Forms.Label labelRegisteredStudentsStat;
        private System.Windows.Forms.Label labelRegisteredSubjectsStat;
        private System.Windows.Forms.Label labelRegisteredRoomsStat;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStat;
        private System.Windows.Forms.TextBox StatRO_lecturers;
        private System.Windows.Forms.TextBox StatRO_rooms;
        private System.Windows.Forms.TextBox StatRO_subjects;
        private System.Windows.Forms.TextBox StatRO_students;
    }
}