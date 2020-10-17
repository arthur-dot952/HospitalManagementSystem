namespace Hospital_Management_System_1
{
    partial class Add_Appointment
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
            this.TextBoxPassport = new System.Windows.Forms.TextBox();
            this.TextBoxDoctorsName = new System.Windows.Forms.TextBox();
            this.ComboBoxAppointmentType = new System.Windows.Forms.ComboBox();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCaseType = new System.Windows.Forms.ComboBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPatientID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonADD = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxPassport
            // 
            this.TextBoxPassport.Location = new System.Drawing.Point(174, 271);
            this.TextBoxPassport.Name = "TextBoxPassport";
            this.TextBoxPassport.Size = new System.Drawing.Size(200, 20);
            this.TextBoxPassport.TabIndex = 17;
            this.TextBoxPassport.TextChanged += new System.EventHandler(this.TextBoxPassport_TextChanged);
            // 
            // TextBoxDoctorsName
            // 
            this.TextBoxDoctorsName.Location = new System.Drawing.Point(174, 233);
            this.TextBoxDoctorsName.Name = "TextBoxDoctorsName";
            this.TextBoxDoctorsName.Size = new System.Drawing.Size(200, 20);
            this.TextBoxDoctorsName.TabIndex = 16;
            this.TextBoxDoctorsName.TextChanged += new System.EventHandler(this.TextBoxDoctorsName_TextChanged);
            // 
            // ComboBoxAppointmentType
            // 
            this.ComboBoxAppointmentType.FormattingEnabled = true;
            this.ComboBoxAppointmentType.Items.AddRange(new object[] {
            "Face to Face",
            "On Phone"});
            this.ComboBoxAppointmentType.Location = new System.Drawing.Point(174, 194);
            this.ComboBoxAppointmentType.Name = "ComboBoxAppointmentType";
            this.ComboBoxAppointmentType.Size = new System.Drawing.Size(200, 21);
            this.ComboBoxAppointmentType.TabIndex = 12;
            this.ComboBoxAppointmentType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAppointmentType_SelectedIndexChanged);
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker1.Location = new System.Drawing.Point(174, 151);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker1.TabIndex = 11;
            this.DateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(24, 274);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(102, 18);
            this.Label6.TabIndex = 5;
            this.Label6.Text = "ID/Passport:";
            this.Label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(24, 236);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(123, 18);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "Doctors Name:";
            this.Label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(23, 198);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(147, 18);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Appointment Type:";
            this.Label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(24, 155);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(48, 18);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Date:";
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(23, 109);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(93, 18);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Case Type:";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(24, 76);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(94, 18);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Last Name:";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.GroupBox1.Controls.Add(this.comboBoxCaseType);
            this.GroupBox1.Controls.Add(this.textBoxFirstName);
            this.GroupBox1.Controls.Add(this.label8);
            this.GroupBox1.Controls.Add(this.textBoxPatientID);
            this.GroupBox1.Controls.Add(this.label7);
            this.GroupBox1.Controls.Add(this.textBoxLastName);
            this.GroupBox1.Controls.Add(this.TextBoxPassport);
            this.GroupBox1.Controls.Add(this.TextBoxDoctorsName);
            this.GroupBox1.Controls.Add(this.ComboBoxAppointmentType);
            this.GroupBox1.Controls.Add(this.DateTimePicker1);
            this.GroupBox1.Controls.Add(this.ButtonExit);
            this.GroupBox1.Controls.Add(this.ButtonADD);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(-2, 90);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(600, 358);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // comboBoxCaseType
            // 
            this.comboBoxCaseType.FormattingEnabled = true;
            this.comboBoxCaseType.Items.AddRange(new object[] {
            "Normal",
            "Serious",
            "Private",
            "Therapy",
            "Examination",
            "Follow Up"});
            this.comboBoxCaseType.Location = new System.Drawing.Point(174, 109);
            this.comboBoxCaseType.Name = "comboBoxCaseType";
            this.comboBoxCaseType.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCaseType.TabIndex = 24;
            this.comboBoxCaseType.SelectedIndexChanged += new System.EventHandler(this.comboBoxCaseType_SelectedIndexChanged);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(136, 43);
            this.textBoxFirstName.Multiline = true;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(238, 20);
            this.textBoxFirstName.TabIndex = 23;
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxFirstName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 18);
            this.label8.TabIndex = 22;
            this.label8.Text = "Fisrt Name:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxPatientID
            // 
            this.textBoxPatientID.Location = new System.Drawing.Point(136, 11);
            this.textBoxPatientID.Multiline = true;
            this.textBoxPatientID.Name = "textBoxPatientID";
            this.textBoxPatientID.Size = new System.Drawing.Size(238, 20);
            this.textBoxPatientID.TabIndex = 20;
            this.textBoxPatientID.TextChanged += new System.EventHandler(this.textBoxPatientID_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Patient ID:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(136, 74);
            this.textBoxLastName.Multiline = true;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(238, 20);
            this.textBoxLastName.TabIndex = 18;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonExit.Location = new System.Drawing.Point(322, 316);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(169, 36);
            this.ButtonExit.TabIndex = 7;
            this.ButtonExit.Text = "EXIT";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonADD
            // 
            this.ButtonADD.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ButtonADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonADD.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ButtonADD.Location = new System.Drawing.Point(107, 316);
            this.ButtonADD.Name = "ButtonADD";
            this.ButtonADD.Size = new System.Drawing.Size(188, 36);
            this.ButtonADD.TabIndex = 6;
            this.ButtonADD.Text = "ADD";
            this.ButtonADD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonADD.UseVisualStyleBackColor = false;
            this.ButtonADD.Click += new System.EventHandler(this.ButtonADD_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 93);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(137, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(363, 39);
            this.label9.TabIndex = 0;
            this.label9.Text = "ADD APPOINTMENT";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital_Management_System_1.Properties.Resources.kisspng_dr_ruparelia_s_sushrusha_ayurved_multispeciality_hospital_5ac48f9fc03097_5142765515228312637872;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 121;
            this.pictureBox1.TabStop = false;
            // 
            // Add_Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Appointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Appointment";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button ButtonExit;
        internal System.Windows.Forms.Button ButtonADD;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxPassport;
        private System.Windows.Forms.TextBox TextBoxDoctorsName;
        private System.Windows.Forms.ComboBox ComboBoxAppointmentType;
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxPatientID;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.ComboBox comboBoxCaseType;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}