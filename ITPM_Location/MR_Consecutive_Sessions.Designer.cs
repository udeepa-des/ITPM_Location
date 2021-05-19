
namespace ITPM_Location
{
    partial class MR_Consecutive_Sessions
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
            this.dataGridView1CS = new System.Windows.Forms.DataGridView();
            this.buttonAdd_Room = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxHidden_CS = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Sessions = new System.Windows.Forms.TabPage();
            this.ConsecutivePage = new System.Windows.Forms.TabPage();
            this.dataGridView1Con = new System.Windows.Forms.DataGridView();
            this.button1RefreshCon = new System.Windows.Forms.Button();
            this.textBoxHiddenCon = new System.Windows.Forms.TextBox();
            this.button3AddRoomCon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1CS)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Sessions.SuspendLayout();
            this.ConsecutivePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Con)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1CS
            // 
            this.dataGridView1CS.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1CS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1CS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1CS.Location = new System.Drawing.Point(30, 42);
            this.dataGridView1CS.Name = "dataGridView1CS";
            this.dataGridView1CS.RowHeadersWidth = 51;
            this.dataGridView1CS.RowTemplate.Height = 24;
            this.dataGridView1CS.Size = new System.Drawing.Size(993, 252);
            this.dataGridView1CS.TabIndex = 0;
            this.dataGridView1CS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1CS_CellContentClick);
            this.dataGridView1CS.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1CS_RowHeaderMouseClick);
            // 
            // buttonAdd_Room
            // 
            this.buttonAdd_Room.BackColor = System.Drawing.Color.Green;
            this.buttonAdd_Room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd_Room.ForeColor = System.Drawing.Color.White;
            this.buttonAdd_Room.Location = new System.Drawing.Point(206, 443);
            this.buttonAdd_Room.Name = "buttonAdd_Room";
            this.buttonAdd_Room.Size = new System.Drawing.Size(200, 60);
            this.buttonAdd_Room.TabIndex = 1;
            this.buttonAdd_Room.Text = "Add Room";
            this.buttonAdd_Room.UseVisualStyleBackColor = false;
            this.buttonAdd_Room.Click += new System.EventHandler(this.buttonAdd_Room_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(612, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxHidden_CS
            // 
            this.textBoxHidden_CS.Location = new System.Drawing.Point(30, 336);
            this.textBoxHidden_CS.Name = "textBoxHidden_CS";
            this.textBoxHidden_CS.Size = new System.Drawing.Size(100, 22);
            this.textBoxHidden_CS.TabIndex = 3;
            this.textBoxHidden_CS.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Sessions);
            this.tabControl1.Controls.Add(this.ConsecutivePage);
            this.tabControl1.Location = new System.Drawing.Point(12, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1062, 715);
            this.tabControl1.TabIndex = 4;
            // 
            // Sessions
            // 
            this.Sessions.Controls.Add(this.dataGridView1CS);
            this.Sessions.Controls.Add(this.button2);
            this.Sessions.Controls.Add(this.textBoxHidden_CS);
            this.Sessions.Controls.Add(this.buttonAdd_Room);
            this.Sessions.Location = new System.Drawing.Point(4, 25);
            this.Sessions.Name = "Sessions";
            this.Sessions.Padding = new System.Windows.Forms.Padding(3);
            this.Sessions.Size = new System.Drawing.Size(1054, 686);
            this.Sessions.TabIndex = 0;
            this.Sessions.Text = "Sessions";
            this.Sessions.UseVisualStyleBackColor = true;
            this.Sessions.Click += new System.EventHandler(this.Sessions_Click);
            // 
            // ConsecutivePage
            // 
            this.ConsecutivePage.Controls.Add(this.dataGridView1Con);
            this.ConsecutivePage.Controls.Add(this.button1RefreshCon);
            this.ConsecutivePage.Controls.Add(this.textBoxHiddenCon);
            this.ConsecutivePage.Controls.Add(this.button3AddRoomCon);
            this.ConsecutivePage.Location = new System.Drawing.Point(4, 25);
            this.ConsecutivePage.Name = "ConsecutivePage";
            this.ConsecutivePage.Padding = new System.Windows.Forms.Padding(3);
            this.ConsecutivePage.Size = new System.Drawing.Size(1054, 686);
            this.ConsecutivePage.TabIndex = 1;
            this.ConsecutivePage.Text = "Consecutive";
            this.ConsecutivePage.UseVisualStyleBackColor = true;
            this.ConsecutivePage.Click += new System.EventHandler(this.ConsecutivePage_Click);
            // 
            // dataGridView1Con
            // 
            this.dataGridView1Con.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1Con.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1Con.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Con.Location = new System.Drawing.Point(30, 42);
            this.dataGridView1Con.Name = "dataGridView1Con";
            this.dataGridView1Con.RowHeadersWidth = 51;
            this.dataGridView1Con.RowTemplate.Height = 24;
            this.dataGridView1Con.Size = new System.Drawing.Size(993, 252);
            this.dataGridView1Con.TabIndex = 4;
            this.dataGridView1Con.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1Con_CellContentClick);
            this.dataGridView1Con.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1Con_RowHeaderMouseClick);
            // 
            // button1RefreshCon
            // 
            this.button1RefreshCon.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1RefreshCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1RefreshCon.ForeColor = System.Drawing.Color.White;
            this.button1RefreshCon.Location = new System.Drawing.Point(612, 443);
            this.button1RefreshCon.Name = "button1RefreshCon";
            this.button1RefreshCon.Size = new System.Drawing.Size(200, 60);
            this.button1RefreshCon.TabIndex = 6;
            this.button1RefreshCon.Text = "Refresh";
            this.button1RefreshCon.UseVisualStyleBackColor = false;
            this.button1RefreshCon.Click += new System.EventHandler(this.button1RefreshCon_Click);
            // 
            // textBoxHiddenCon
            // 
            this.textBoxHiddenCon.Location = new System.Drawing.Point(28, 324);
            this.textBoxHiddenCon.Name = "textBoxHiddenCon";
            this.textBoxHiddenCon.Size = new System.Drawing.Size(100, 22);
            this.textBoxHiddenCon.TabIndex = 7;
            this.textBoxHiddenCon.Visible = false;
            // 
            // button3AddRoomCon
            // 
            this.button3AddRoomCon.BackColor = System.Drawing.Color.Green;
            this.button3AddRoomCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3AddRoomCon.ForeColor = System.Drawing.Color.White;
            this.button3AddRoomCon.Location = new System.Drawing.Point(206, 443);
            this.button3AddRoomCon.Name = "button3AddRoomCon";
            this.button3AddRoomCon.Size = new System.Drawing.Size(200, 60);
            this.button3AddRoomCon.TabIndex = 5;
            this.button3AddRoomCon.Text = "Add Room";
            this.button3AddRoomCon.UseVisualStyleBackColor = false;
            this.button3AddRoomCon.Click += new System.EventHandler(this.button3AddRoomCon_Click);
            // 
            // MR_Consecutive_Sessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 733);
            this.Controls.Add(this.tabControl1);
            this.Name = "MR_Consecutive_Sessions";
            this.Text = "Consecutive Sessions";
            this.Load += new System.EventHandler(this.MR_Consecutive_Sessions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1CS)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Sessions.ResumeLayout(false);
            this.Sessions.PerformLayout();
            this.ConsecutivePage.ResumeLayout(false);
            this.ConsecutivePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Con)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1CS;
        private System.Windows.Forms.Button buttonAdd_Room;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox textBoxHidden_CS;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Sessions;
        private System.Windows.Forms.TabPage ConsecutivePage;
        private System.Windows.Forms.DataGridView dataGridView1Con;
        private System.Windows.Forms.Button button1RefreshCon;
        public System.Windows.Forms.TextBox textBoxHiddenCon;
        private System.Windows.Forms.Button button3AddRoomCon;
    }
}