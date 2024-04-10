namespace Crime_App
{
    partial class registerNewDoctorForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.selectS = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.doctorName = new System.Windows.Forms.RichTextBox();
            this.selectDoctorSpecialization = new System.Windows.Forms.ComboBox();
            this.selectDoctorGender = new System.Windows.Forms.ComboBox();
            this.doctorDob = new System.Windows.Forms.DateTimePicker();
            this.selectAvailabilityStart = new System.Windows.Forms.ComboBox();
            this.selectAvailabilityEnd = new System.Windows.Forms.ComboBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.doctorLanguage = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(39, 44);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(142, 39);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "enter doctor namce";
            // 
            // selectS
            // 
            this.selectS.Location = new System.Drawing.Point(39, 109);
            this.selectS.Name = "selectS";
            this.selectS.Size = new System.Drawing.Size(142, 40);
            this.selectS.TabIndex = 1;
            this.selectS.Text = "select doctor specialization";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(39, 170);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(142, 35);
            this.richTextBox3.TabIndex = 2;
            this.richTextBox3.Text = "select gender";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(39, 223);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(142, 36);
            this.richTextBox4.TabIndex = 3;
            this.richTextBox4.Text = "select date of birth";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(39, 278);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(142, 40);
            this.richTextBox5.TabIndex = 4;
            this.richTextBox5.Text = "select availability start";
            // 
            // doctorName
            // 
            this.doctorName.Location = new System.Drawing.Point(200, 44);
            this.doctorName.Name = "doctorName";
            this.doctorName.Size = new System.Drawing.Size(145, 39);
            this.doctorName.TabIndex = 5;
            this.doctorName.Text = "";
            // 
            // selectDoctorSpecialization
            // 
            this.selectDoctorSpecialization.FormattingEnabled = true;
            this.selectDoctorSpecialization.Items.AddRange(new object[] {
            "Cardiology",
            "Pediatrics",
            "Orthopedics",
            "Dermatology",
            "Ophthalmology",
            "Psychiatry",
            "Neurology",
            "Gynecology",
            "Urology",
            "Endocrinology",
            "Oncology",
            "Rheumatology",
            "Gastroenterology",
            "Pulmonology",
            "Nephrology",
            "Hematology",
            "Allergy and Immunology",
            "Infectious Diseases",
            "Emergency Medicine",
            "Geriatrics"});
            this.selectDoctorSpecialization.Location = new System.Drawing.Point(200, 109);
            this.selectDoctorSpecialization.Name = "selectDoctorSpecialization";
            this.selectDoctorSpecialization.Size = new System.Drawing.Size(121, 21);
            this.selectDoctorSpecialization.TabIndex = 6;
            // 
            // selectDoctorGender
            // 
            this.selectDoctorGender.FormattingEnabled = true;
            this.selectDoctorGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.selectDoctorGender.Location = new System.Drawing.Point(200, 170);
            this.selectDoctorGender.Name = "selectDoctorGender";
            this.selectDoctorGender.Size = new System.Drawing.Size(121, 21);
            this.selectDoctorGender.TabIndex = 7;
            // 
            // doctorDob
            // 
            this.doctorDob.Location = new System.Drawing.Point(200, 223);
            this.doctorDob.Name = "doctorDob";
            this.doctorDob.Size = new System.Drawing.Size(200, 20);
            this.doctorDob.TabIndex = 8;
            // 
            // selectAvailabilityStart
            // 
            this.selectAvailabilityStart.FormattingEnabled = true;
            this.selectAvailabilityStart.Items.AddRange(new object[] {
            "08:00:00",
            "09:00:00",
            "10:00:00",
            "11:00:00",
            "12:00:00",
            "13:00:00",
            "14:00:00",
            "15:00:00",
            "08:30:00",
            "09:30:00",
            "10:30:00",
            "11:30:00",
            "12:30:00",
            "13:30:00",
            "14:30:00",
            "15:30:00"});
            this.selectAvailabilityStart.Location = new System.Drawing.Point(200, 278);
            this.selectAvailabilityStart.Name = "selectAvailabilityStart";
            this.selectAvailabilityStart.Size = new System.Drawing.Size(121, 21);
            this.selectAvailabilityStart.TabIndex = 9;
            // 
            // selectAvailabilityEnd
            // 
            this.selectAvailabilityEnd.FormattingEnabled = true;
            this.selectAvailabilityEnd.Items.AddRange(new object[] {
            "16:00:00",
            "17:00:00",
            "18:00:00",
            "19:00:00",
            "20:00:00",
            "21:00:00",
            "22:00:00",
            "23:00:00",
            "16:30:00",
            "17:30:00",
            "18:30:00",
            "19:30:00",
            "20:30:00",
            "21:30:00",
            "22:30:00",
            "23:30:00"});
            this.selectAvailabilityEnd.Location = new System.Drawing.Point(203, 324);
            this.selectAvailabilityEnd.Name = "selectAvailabilityEnd";
            this.selectAvailabilityEnd.Size = new System.Drawing.Size(121, 21);
            this.selectAvailabilityEnd.TabIndex = 10;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(39, 324);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(142, 40);
            this.richTextBox2.TabIndex = 11;
            this.richTextBox2.Text = "select availiility end";
            // 
            // richTextBox6
            // 
            this.richTextBox6.Location = new System.Drawing.Point(28, 370);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(142, 40);
            this.richTextBox6.TabIndex = 12;
            this.richTextBox6.Text = "enter language";
            // 
            // doctorLanguage
            // 
            this.doctorLanguage.Location = new System.Drawing.Point(203, 379);
            this.doctorLanguage.Name = "doctorLanguage";
            this.doctorLanguage.Size = new System.Drawing.Size(142, 40);
            this.doctorLanguage.TabIndex = 13;
            this.doctorLanguage.Text = "enter language";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // registerNewDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.doctorLanguage);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.selectAvailabilityEnd);
            this.Controls.Add(this.selectAvailabilityStart);
            this.Controls.Add(this.doctorDob);
            this.Controls.Add(this.selectDoctorGender);
            this.Controls.Add(this.selectDoctorSpecialization);
            this.Controls.Add(this.doctorName);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.selectS);
            this.Controls.Add(this.richTextBox1);
            this.Name = "registerNewDoctorForm";
            this.Text = "registerNewDoctorForm";
            this.Load += new System.EventHandler(this.registerNewDoctorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox selectS;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox doctorName;
        private System.Windows.Forms.ComboBox selectDoctorSpecialization;
        private System.Windows.Forms.ComboBox selectDoctorGender;
        private System.Windows.Forms.DateTimePicker doctorDob;
        private System.Windows.Forms.ComboBox selectAvailabilityStart;
        private System.Windows.Forms.ComboBox selectAvailabilityEnd;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox doctorLanguage;
        private System.Windows.Forms.Button button1;
    }
}