
namespace ITPM_Location
{
    partial class AddLocation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelBuildingName = new System.Windows.Forms.Label();
            this.labelBuildindName1 = new System.Windows.Forms.Label();
            this.textBoxBuildingName = new System.Windows.Forms.TextBox();
            this.textBoxRoomName = new System.Windows.Forms.TextBox();
            this.labelRoomName = new System.Windows.Forms.Label();
            this.textBoxCapacity = new System.Windows.Forms.TextBox();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.radioButtonLecRoomType = new System.Windows.Forms.RadioButton();
            this.radioButtonLabRoomType = new System.Windows.Forms.RadioButton();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelExampleRoomNameAL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBuildingName
            // 
            this.labelBuildingName.AutoSize = true;
            this.labelBuildingName.Font = new System.Drawing.Font("Montserrat", 19.8F);
            this.labelBuildingName.Location = new System.Drawing.Point(415, 35);
            this.labelBuildingName.Name = "labelBuildingName";
            this.labelBuildingName.Size = new System.Drawing.Size(256, 40);
            this.labelBuildingName.TabIndex = 0;
            this.labelBuildingName.Text = "Add Locations";
            this.labelBuildingName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelBuildindName1
            // 
            this.labelBuildindName1.AutoSize = true;
            this.labelBuildindName1.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelBuildindName1.Location = new System.Drawing.Point(155, 136);
            this.labelBuildindName1.Name = "labelBuildindName1";
            this.labelBuildindName1.Size = new System.Drawing.Size(157, 24);
            this.labelBuildindName1.TabIndex = 1;
            this.labelBuildindName1.Text = "Building Name";
            this.labelBuildindName1.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxBuildingName
            // 
            this.textBoxBuildingName.Location = new System.Drawing.Point(359, 134);
            this.textBoxBuildingName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBuildingName.Name = "textBoxBuildingName";
            this.textBoxBuildingName.Size = new System.Drawing.Size(475, 22);
            this.textBoxBuildingName.TabIndex = 2;
            // 
            // textBoxRoomName
            // 
            this.textBoxRoomName.ForeColor = System.Drawing.Color.Black;
            this.textBoxRoomName.Location = new System.Drawing.Point(359, 253);
            this.textBoxRoomName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRoomName.Name = "textBoxRoomName";
            this.textBoxRoomName.Size = new System.Drawing.Size(475, 22);
            this.textBoxRoomName.TabIndex = 4;
            this.textBoxRoomName.TextChanged += new System.EventHandler(this.textBoxRoomName_TextChanged);
            // 
            // labelRoomName
            // 
            this.labelRoomName.AutoSize = true;
            this.labelRoomName.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelRoomName.Location = new System.Drawing.Point(155, 253);
            this.labelRoomName.Name = "labelRoomName";
            this.labelRoomName.Size = new System.Drawing.Size(137, 24);
            this.labelRoomName.TabIndex = 3;
            this.labelRoomName.Text = "Room Name";
            // 
            // textBoxCapacity
            // 
            this.textBoxCapacity.Location = new System.Drawing.Point(359, 486);
            this.textBoxCapacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCapacity.Name = "textBoxCapacity";
            this.textBoxCapacity.Size = new System.Drawing.Size(475, 22);
            this.textBoxCapacity.TabIndex = 6;
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelCapacity.Location = new System.Drawing.Point(155, 483);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(98, 24);
            this.labelCapacity.TabIndex = 5;
            this.labelCapacity.Text = "Capacity";
            this.labelCapacity.Click += new System.EventHandler(this.label3_Click);
            // 
            // radioButtonLecRoomType
            // 
            this.radioButtonLecRoomType.AutoSize = true;
            this.radioButtonLecRoomType.Location = new System.Drawing.Point(359, 367);
            this.radioButtonLecRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonLecRoomType.Name = "radioButtonLecRoomType";
            this.radioButtonLecRoomType.Size = new System.Drawing.Size(105, 21);
            this.radioButtonLecRoomType.TabIndex = 7;
            this.radioButtonLecRoomType.TabStop = true;
            this.radioButtonLecRoomType.Text = "Lecture Hall";
            this.radioButtonLecRoomType.UseVisualStyleBackColor = true;
            this.radioButtonLecRoomType.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonLabRoomType
            // 
            this.radioButtonLabRoomType.AutoSize = true;
            this.radioButtonLabRoomType.Location = new System.Drawing.Point(594, 367);
            this.radioButtonLabRoomType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonLabRoomType.Name = "radioButtonLabRoomType";
            this.radioButtonLabRoomType.Size = new System.Drawing.Size(98, 21);
            this.radioButtonLabRoomType.TabIndex = 8;
            this.radioButtonLabRoomType.TabStop = true;
            this.radioButtonLabRoomType.Text = "Laboratory";
            this.radioButtonLabRoomType.UseVisualStyleBackColor = true;
            this.radioButtonLabRoomType.CheckedChanged += new System.EventHandler(this.radioButtonLabRoomType_CheckedChanged);
            // 
            // labelRoomType
            // 
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelRoomType.Location = new System.Drawing.Point(154, 367);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(123, 24);
            this.labelRoomType.TabIndex = 9;
            this.labelRoomType.Text = "Room Type";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Montserrat", 10.8F);
            this.buttonClear.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonClear.Location = new System.Drawing.Point(359, 607);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(163, 38);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Montserrat", 10.8F);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(671, 607);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(163, 38);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelExampleRoomNameAL
            // 
            this.labelExampleRoomNameAL.AutoSize = true;
            this.labelExampleRoomNameAL.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExampleRoomNameAL.Location = new System.Drawing.Point(359, 281);
            this.labelExampleRoomNameAL.Name = "labelExampleRoomNameAL";
            this.labelExampleRoomNameAL.Size = new System.Drawing.Size(487, 18);
            this.labelExampleRoomNameAL.TabIndex = 12;
            this.labelExampleRoomNameAL.Text = "Building(A), Floor number(4), Hall number(01)                         Eg: A401";
            this.labelExampleRoomNameAL.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // AddLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 733);
            this.Controls.Add(this.labelExampleRoomNameAL);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelRoomType);
            this.Controls.Add(this.radioButtonLabRoomType);
            this.Controls.Add(this.radioButtonLecRoomType);
            this.Controls.Add(this.textBoxCapacity);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.textBoxRoomName);
            this.Controls.Add(this.labelRoomName);
            this.Controls.Add(this.textBoxBuildingName);
            this.Controls.Add(this.labelBuildindName1);
            this.Controls.Add(this.labelBuildingName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddLocation";
            this.Text = "Add Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBuildingName;
        private System.Windows.Forms.Label labelBuildindName1;
        private System.Windows.Forms.Label labelRoomName;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelExampleRoomNameAL;
        private System.Windows.Forms.RadioButton radioButtonLecRoomType;
        private System.Windows.Forms.RadioButton radioButtonLabRoomType;
        private System.Windows.Forms.TextBox textBoxBuildingName;
        private System.Windows.Forms.TextBox textBoxRoomName;
        private System.Windows.Forms.TextBox textBoxCapacity;
    }
}

