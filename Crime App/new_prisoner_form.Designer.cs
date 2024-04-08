namespace Crime_App
{
    partial class new_prisoner_form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.selectPrisonId = new System.Windows.Forms.ComboBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.enterName = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.selectDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.selectGender = new System.Windows.Forms.ComboBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.selectAdmitDate = new System.Windows.Forms.DateTimePicker();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.punishDuration = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.selectMeetTime = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.selectMeetTime);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.punishDuration);
            this.panel1.Controls.Add(this.richTextBox7);
            this.panel1.Controls.Add(this.selectAdmitDate);
            this.panel1.Controls.Add(this.richTextBox6);
            this.panel1.Controls.Add(this.selectGender);
            this.panel1.Controls.Add(this.richTextBox5);
            this.panel1.Controls.Add(this.richTextBox4);
            this.panel1.Controls.Add(this.selectDateOfBirth);
            this.panel1.Controls.Add(this.richTextBox3);
            this.panel1.Controls.Add(this.enterName);
            this.panel1.Controls.Add(this.richTextBox2);
            this.panel1.Controls.Add(this.selectPrisonId);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 659);
            this.panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(249, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(132, 30);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Select Id";
            // 
            // selectPrisonId
            // 
            this.selectPrisonId.FormattingEnabled = true;
            this.selectPrisonId.Location = new System.Drawing.Point(389, 30);
            this.selectPrisonId.Name = "selectPrisonId";
            this.selectPrisonId.Size = new System.Drawing.Size(163, 21);
            this.selectPrisonId.TabIndex = 1;
            this.selectPrisonId.SelectedIndexChanged += new System.EventHandler(this.selectPrisonId_SelectedIndexChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(249, 84);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(132, 30);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "enter name";
            // 
            // enterName
            // 
            this.enterName.Location = new System.Drawing.Point(389, 84);
            this.enterName.Name = "enterName";
            this.enterName.Size = new System.Drawing.Size(132, 30);
            this.enterName.TabIndex = 3;
            this.enterName.Text = "enter name";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(250, 145);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(132, 30);
            this.richTextBox3.TabIndex = 4;
            this.richTextBox3.Text = "enterDateOfBirth";
            // 
            // selectDateOfBirth
            // 
            this.selectDateOfBirth.Location = new System.Drawing.Point(403, 155);
            this.selectDateOfBirth.Name = "selectDateOfBirth";
            this.selectDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.selectDateOfBirth.TabIndex = 5;
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(249, 188);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(132, 30);
            this.richTextBox4.TabIndex = 6;
            this.richTextBox4.Text = "selectMeetTime";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(249, 258);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(132, 30);
            this.richTextBox5.TabIndex = 8;
            this.richTextBox5.Text = "select gender";
            // 
            // selectGender
            // 
            this.selectGender.FormattingEnabled = true;
            this.selectGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.selectGender.Location = new System.Drawing.Point(403, 267);
            this.selectGender.Name = "selectGender";
            this.selectGender.Size = new System.Drawing.Size(163, 21);
            this.selectGender.TabIndex = 9;
            // 
            // richTextBox6
            // 
            this.richTextBox6.Location = new System.Drawing.Point(249, 325);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(132, 30);
            this.richTextBox6.TabIndex = 10;
            this.richTextBox6.Text = "select admit date";
            // 
            // selectAdmitDate
            // 
            this.selectAdmitDate.Location = new System.Drawing.Point(403, 335);
            this.selectAdmitDate.Name = "selectAdmitDate";
            this.selectAdmitDate.Size = new System.Drawing.Size(200, 20);
            this.selectAdmitDate.TabIndex = 11;
            // 
            // richTextBox7
            // 
            this.richTextBox7.Location = new System.Drawing.Point(250, 374);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(132, 30);
            this.richTextBox7.TabIndex = 12;
            this.richTextBox7.Text = "enter duration";
            // 
            // punishDuration
            // 
            this.punishDuration.Location = new System.Drawing.Point(403, 374);
            this.punishDuration.Name = "punishDuration";
            this.punishDuration.Size = new System.Drawing.Size(132, 30);
            this.punishDuration.TabIndex = 13;
            this.punishDuration.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(637, 74);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectMeetTime
            // 
            this.selectMeetTime.FormattingEnabled = true;
            this.selectMeetTime.Items.AddRange(new object[] {
            "00:00:00",
            "01:00:00",
            "02:00:00",
            "03:00:00",
            "04:00:00",
            "05:00:00",
            "06:00:00",
            "07:00:00",
            "08:00:00",
            "09:00:00",
            "10:00:00",
            "11:00:00",
            "12:00:00",
            "13:00:00",
            "14:00:00",
            "15:00:00",
            "16:00:00",
            "17:00:00",
            "18:00:00",
            "19:00:00",
            "20:00:00",
            "21:00:00",
            "22:00:00",
            "23:00:00"});
            this.selectMeetTime.Location = new System.Drawing.Point(389, 188);
            this.selectMeetTime.Name = "selectMeetTime";
            this.selectMeetTime.Size = new System.Drawing.Size(163, 21);
            this.selectMeetTime.TabIndex = 15;
            // 
            // new_prisoner_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 661);
            this.Controls.Add(this.panel1);
            this.Name = "new_prisoner_form";
            this.Text = "new_prisoner_form";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox selectGender;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.DateTimePicker selectDateOfBirth;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox enterName;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ComboBox selectPrisonId;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox punishDuration;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.DateTimePicker selectAdmitDate;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox selectMeetTime;
    }
}