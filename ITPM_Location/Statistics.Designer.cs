
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.statChartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBoxStat_rRooms = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.richTextBoxStat_rSubjects = new System.Windows.Forms.RichTextBox();
            this.richTextBoxStat_rLecturers = new System.Windows.Forms.RichTextBox();
            this.richTextBoxStat_rStudents = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxStat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statChartBindingSource)).BeginInit();
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
            this.textBoxSubjectBoxStat.ReadOnly = true;
            this.textBoxSubjectBoxStat.Size = new System.Drawing.Size(309, 28);
            this.textBoxSubjectBoxStat.TabIndex = 7;
            // 
            // textBoxLatestGroupBoxStat
            // 
            this.textBoxLatestGroupBoxStat.Location = new System.Drawing.Point(183, 196);
            this.textBoxLatestGroupBoxStat.Name = "textBoxLatestGroupBoxStat";
            this.textBoxLatestGroupBoxStat.ReadOnly = true;
            this.textBoxLatestGroupBoxStat.Size = new System.Drawing.Size(309, 28);
            this.textBoxLatestGroupBoxStat.TabIndex = 6;
            // 
            // textBoxLecturerBoxStat
            // 
            this.textBoxLecturerBoxStat.Location = new System.Drawing.Point(183, 102);
            this.textBoxLecturerBoxStat.Name = "textBoxLecturerBoxStat";
            this.textBoxLecturerBoxStat.ReadOnly = true;
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
            this.labelRegisteredLecturersStat.Location = new System.Drawing.Point(42, 257);
            this.labelRegisteredLecturersStat.Name = "labelRegisteredLecturersStat";
            this.labelRegisteredLecturersStat.Size = new System.Drawing.Size(191, 20);
            this.labelRegisteredLecturersStat.TabIndex = 4;
            this.labelRegisteredLecturersStat.Text = "Registered Lecturers";
            // 
            // labelRegisteredStudentsStat
            // 
            this.labelRegisteredStudentsStat.AutoSize = true;
            this.labelRegisteredStudentsStat.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelRegisteredStudentsStat.Location = new System.Drawing.Point(311, 257);
            this.labelRegisteredStudentsStat.Name = "labelRegisteredStudentsStat";
            this.labelRegisteredStudentsStat.Size = new System.Drawing.Size(186, 20);
            this.labelRegisteredStudentsStat.TabIndex = 5;
            this.labelRegisteredStudentsStat.Text = "Registered Students";
            // 
            // labelRegisteredSubjectsStat
            // 
            this.labelRegisteredSubjectsStat.AutoSize = true;
            this.labelRegisteredSubjectsStat.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelRegisteredSubjectsStat.Location = new System.Drawing.Point(607, 257);
            this.labelRegisteredSubjectsStat.Name = "labelRegisteredSubjectsStat";
            this.labelRegisteredSubjectsStat.Size = new System.Drawing.Size(184, 20);
            this.labelRegisteredSubjectsStat.TabIndex = 6;
            this.labelRegisteredSubjectsStat.Text = "Registered Subjects";
            // 
            // labelRegisteredRoomsStat
            // 
            this.labelRegisteredRoomsStat.AutoSize = true;
            this.labelRegisteredRoomsStat.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelRegisteredRoomsStat.Location = new System.Drawing.Point(876, 257);
            this.labelRegisteredRoomsStat.Name = "labelRegisteredRoomsStat";
            this.labelRegisteredRoomsStat.Size = new System.Drawing.Size(168, 20);
            this.labelRegisteredRoomsStat.TabIndex = 7;
            this.labelRegisteredRoomsStat.Text = "Registered Rooms";
            // 
            // chartStat
            // 
            chartArea6.Name = "ChartArea1";
            this.chartStat.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartStat.Legends.Add(legend6);
            this.chartStat.Location = new System.Drawing.Point(12, 303);
            this.chartStat.Name = "chartStat";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series11.Legend = "Legend1";
            series11.Name = "Lecture Hall";
            series11.XValueMember = "Labs";
            series11.YValueMembers = "LecHalls";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series12.Legend = "Legend1";
            series12.Name = "Laboratory";
            this.chartStat.Series.Add(series11);
            this.chartStat.Series.Add(series12);
            this.chartStat.Size = new System.Drawing.Size(536, 406);
            this.chartStat.TabIndex = 0;
            this.chartStat.Text = "chart1";
            this.chartStat.Click += new System.EventHandler(this.chartStat_Click);
            // 
            // richTextBoxStat_rRooms
            // 
            this.richTextBoxStat_rRooms.Font = new System.Drawing.Font("Montserrat", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxStat_rRooms.Location = new System.Drawing.Point(902, 105);
            this.richTextBoxStat_rRooms.Name = "richTextBoxStat_rRooms";
            this.richTextBoxStat_rRooms.ReadOnly = true;
            this.richTextBoxStat_rRooms.Size = new System.Drawing.Size(110, 104);
            this.richTextBoxStat_rRooms.TabIndex = 13;
            this.richTextBoxStat_rRooms.Text = "";
            this.richTextBoxStat_rRooms.TextChanged += new System.EventHandler(this.richTextBoxStat_rRooms_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // richTextBoxStat_rSubjects
            // 
            this.richTextBoxStat_rSubjects.Font = new System.Drawing.Font("Montserrat", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxStat_rSubjects.Location = new System.Drawing.Point(641, 105);
            this.richTextBoxStat_rSubjects.Name = "richTextBoxStat_rSubjects";
            this.richTextBoxStat_rSubjects.ReadOnly = true;
            this.richTextBoxStat_rSubjects.Size = new System.Drawing.Size(110, 104);
            this.richTextBoxStat_rSubjects.TabIndex = 15;
            this.richTextBoxStat_rSubjects.Text = "";
            // 
            // richTextBoxStat_rLecturers
            // 
            this.richTextBoxStat_rLecturers.Font = new System.Drawing.Font("Montserrat", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxStat_rLecturers.Location = new System.Drawing.Point(87, 105);
            this.richTextBoxStat_rLecturers.Name = "richTextBoxStat_rLecturers";
            this.richTextBoxStat_rLecturers.ReadOnly = true;
            this.richTextBoxStat_rLecturers.Size = new System.Drawing.Size(110, 104);
            this.richTextBoxStat_rLecturers.TabIndex = 16;
            this.richTextBoxStat_rLecturers.Text = "";
            // 
            // richTextBoxStat_rStudents
            // 
            this.richTextBoxStat_rStudents.Font = new System.Drawing.Font("Montserrat", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxStat_rStudents.Location = new System.Drawing.Point(350, 105);
            this.richTextBoxStat_rStudents.Name = "richTextBoxStat_rStudents";
            this.richTextBoxStat_rStudents.ReadOnly = true;
            this.richTextBoxStat_rStudents.Size = new System.Drawing.Size(110, 104);
            this.richTextBoxStat_rStudents.TabIndex = 17;
            this.richTextBoxStat_rStudents.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 19.8F);
            this.label1.Location = new System.Drawing.Point(465, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 40);
            this.label1.TabIndex = 18;
            this.label1.Text = "Statistics";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 733);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxStat_rStudents);
            this.Controls.Add(this.richTextBoxStat_rLecturers);
            this.Controls.Add(this.richTextBoxStat_rSubjects);
            this.Controls.Add(this.richTextBoxStat_rRooms);
            this.Controls.Add(this.chartStat);
            this.Controls.Add(this.labelRegisteredRoomsStat);
            this.Controls.Add(this.labelRegisteredSubjectsStat);
            this.Controls.Add(this.labelRegisteredStudentsStat);
            this.Controls.Add(this.labelRegisteredLecturersStat);
            this.Controls.Add(this.groupBoxStat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.groupBoxStat.ResumeLayout(false);
            this.groupBoxStat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statChartBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource statChartBindingSource;
        private System.Windows.Forms.RichTextBox richTextBoxStat_rRooms;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox richTextBoxStat_rSubjects;
        private System.Windows.Forms.RichTextBox richTextBoxStat_rLecturers;
        private System.Windows.Forms.RichTextBox richTextBoxStat_rStudents;
        private System.Windows.Forms.Label label1;
    }
}