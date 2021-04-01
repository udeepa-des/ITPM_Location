﻿
namespace ITPM_Location
{
    partial class ManageLocations
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
            this.labelManageLocations = new System.Windows.Forms.Label();
            this.labelBuildingNameManageLocations = new System.Windows.Forms.Label();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.labelRoomName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonMLupdate = new System.Windows.Forms.Button();
            this.buttonMLdelete = new System.Windows.Forms.Button();
            this.buttonMLclear = new System.Windows.Forms.Button();
            this.ML_RoomType_LecHall = new System.Windows.Forms.RadioButton();
            this.ML_RoomType_lab = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelManageLocations
            // 
            this.labelManageLocations.AutoSize = true;
            this.labelManageLocations.Font = new System.Drawing.Font("Montserrat", 19.8F, System.Drawing.FontStyle.Bold);
            this.labelManageLocations.Location = new System.Drawing.Point(371, 20);
            this.labelManageLocations.Name = "labelManageLocations";
            this.labelManageLocations.Size = new System.Drawing.Size(323, 40);
            this.labelManageLocations.TabIndex = 0;
            this.labelManageLocations.Text = "Manage Locations";
            // 
            // labelBuildingNameManageLocations
            // 
            this.labelBuildingNameManageLocations.AutoSize = true;
            this.labelBuildingNameManageLocations.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelBuildingNameManageLocations.Location = new System.Drawing.Point(110, 476);
            this.labelBuildingNameManageLocations.Name = "labelBuildingNameManageLocations";
            this.labelBuildingNameManageLocations.Size = new System.Drawing.Size(157, 24);
            this.labelBuildingNameManageLocations.TabIndex = 1;
            this.labelBuildingNameManageLocations.Text = "Building Name";
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelCapacity.Location = new System.Drawing.Point(110, 667);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(98, 24);
            this.labelCapacity.TabIndex = 6;
            this.labelCapacity.Text = "Capacity";
            // 
            // labelRoomType
            // 
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelRoomType.Location = new System.Drawing.Point(110, 606);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(123, 24);
            this.labelRoomType.TabIndex = 7;
            this.labelRoomType.Text = "Room Type";
            // 
            // labelRoomName
            // 
            this.labelRoomName.AutoSize = true;
            this.labelRoomName.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelRoomName.Location = new System.Drawing.Point(110, 541);
            this.labelRoomName.Name = "labelRoomName";
            this.labelRoomName.Size = new System.Drawing.Size(137, 24);
            this.labelRoomName.TabIndex = 8;
            this.labelRoomName.Text = "Room Name";
            this.labelRoomName.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(337, 473);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(598, 22);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(337, 665);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(598, 22);
            this.textBox2.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(337, 538);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(598, 22);
            this.textBox4.TabIndex = 12;
            // 
            // buttonMLupdate
            // 
            this.buttonMLupdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonMLupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMLupdate.Font = new System.Drawing.Font("Montserrat", 10.8F);
            this.buttonMLupdate.ForeColor = System.Drawing.Color.White;
            this.buttonMLupdate.Location = new System.Drawing.Point(834, 89);
            this.buttonMLupdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMLupdate.Name = "buttonMLupdate";
            this.buttonMLupdate.Size = new System.Drawing.Size(163, 38);
            this.buttonMLupdate.TabIndex = 13;
            this.buttonMLupdate.Text = "Update";
            this.buttonMLupdate.UseVisualStyleBackColor = false;
            // 
            // buttonMLdelete
            // 
            this.buttonMLdelete.BackColor = System.Drawing.Color.Crimson;
            this.buttonMLdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMLdelete.Font = new System.Drawing.Font("Montserrat", 10.8F);
            this.buttonMLdelete.ForeColor = System.Drawing.Color.White;
            this.buttonMLdelete.Location = new System.Drawing.Point(834, 236);
            this.buttonMLdelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMLdelete.Name = "buttonMLdelete";
            this.buttonMLdelete.Size = new System.Drawing.Size(163, 38);
            this.buttonMLdelete.TabIndex = 14;
            this.buttonMLdelete.Text = "Delete";
            this.buttonMLdelete.UseVisualStyleBackColor = false;
            // 
            // buttonMLclear
            // 
            this.buttonMLclear.BackColor = System.Drawing.Color.Transparent;
            this.buttonMLclear.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonMLclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMLclear.Font = new System.Drawing.Font("Montserrat", 10.8F);
            this.buttonMLclear.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonMLclear.Location = new System.Drawing.Point(834, 379);
            this.buttonMLclear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMLclear.Name = "buttonMLclear";
            this.buttonMLclear.Size = new System.Drawing.Size(163, 38);
            this.buttonMLclear.TabIndex = 15;
            this.buttonMLclear.Text = "Clear";
            this.buttonMLclear.UseVisualStyleBackColor = false;
            // 
            // ML_RoomType_LecHall
            // 
            this.ML_RoomType_LecHall.AutoSize = true;
            this.ML_RoomType_LecHall.Location = new System.Drawing.Point(337, 608);
            this.ML_RoomType_LecHall.Name = "ML_RoomType_LecHall";
            this.ML_RoomType_LecHall.Size = new System.Drawing.Size(105, 21);
            this.ML_RoomType_LecHall.TabIndex = 17;
            this.ML_RoomType_LecHall.TabStop = true;
            this.ML_RoomType_LecHall.Text = "Lecture Hall";
            this.ML_RoomType_LecHall.UseVisualStyleBackColor = true;
            this.ML_RoomType_LecHall.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ML_RoomType_lab
            // 
            this.ML_RoomType_lab.AutoSize = true;
            this.ML_RoomType_lab.Location = new System.Drawing.Point(651, 608);
            this.ML_RoomType_lab.Name = "ML_RoomType_lab";
            this.ML_RoomType_lab.Size = new System.Drawing.Size(98, 21);
            this.ML_RoomType_lab.TabIndex = 18;
            this.ML_RoomType_lab.TabStop = true;
            this.ML_RoomType_lab.Text = "Laboratory";
            this.ML_RoomType_lab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 328);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // ManageLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 733);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ML_RoomType_lab);
            this.Controls.Add(this.ML_RoomType_LecHall);
            this.Controls.Add(this.buttonMLclear);
            this.Controls.Add(this.buttonMLdelete);
            this.Controls.Add(this.buttonMLupdate);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelRoomName);
            this.Controls.Add(this.labelRoomType);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.labelBuildingNameManageLocations);
            this.Controls.Add(this.labelManageLocations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageLocations";
            this.Text = "ManageLocations";
            this.Load += new System.EventHandler(this.ManageLocations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelManageLocations;
        private System.Windows.Forms.Label labelBuildingNameManageLocations;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.Label labelRoomName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button buttonMLupdate;
        private System.Windows.Forms.Button buttonMLdelete;
        private System.Windows.Forms.Button buttonMLclear;
        private System.Windows.Forms.RadioButton ML_RoomType_LecHall;
        private System.Windows.Forms.RadioButton ML_RoomType_lab;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}