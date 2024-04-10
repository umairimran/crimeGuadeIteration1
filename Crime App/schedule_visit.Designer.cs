namespace Crime_App
{
    partial class schedule_visit
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
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.purposeOfVisit = new System.Windows.Forms.RichTextBox();
            this.richTextBox11 = new System.Windows.Forms.RichTextBox();
            this.durationOfVisit = new System.Windows.Forms.RichTextBox();
            this.selectPrisonerId = new System.Windows.Forms.ComboBox();
            this.selectVisitorId = new System.Windows.Forms.ComboBox();
            this.entryDateTime = new System.Windows.Forms.DateTimePicker();
            this.exitDateTime = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.prisonerName = new System.Windows.Forms.RichTextBox();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.visitorName = new System.Windows.Forms.RichTextBox();
            this.richTextBox9 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(38, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(145, 39);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "select prisoner id";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(38, 281);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(145, 39);
            this.richTextBox3.TabIndex = 2;
            this.richTextBox3.Text = "enter data time exit time";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(38, 214);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(145, 39);
            this.richTextBox4.TabIndex = 3;
            this.richTextBox4.Text = "enter data time entry time";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(38, 159);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(145, 39);
            this.richTextBox5.TabIndex = 4;
            this.richTextBox5.Text = "purpose of visit";
            // 
            // richTextBox6
            // 
            this.richTextBox6.Location = new System.Drawing.Point(38, 98);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(145, 39);
            this.richTextBox6.TabIndex = 5;
            this.richTextBox6.Text = " select visitor id";
            // 
            // purposeOfVisit
            // 
            this.purposeOfVisit.Location = new System.Drawing.Point(201, 159);
            this.purposeOfVisit.Name = "purposeOfVisit";
            this.purposeOfVisit.Size = new System.Drawing.Size(145, 39);
            this.purposeOfVisit.TabIndex = 8;
            this.purposeOfVisit.Text = "";
            // 
            // richTextBox11
            // 
            this.richTextBox11.Location = new System.Drawing.Point(394, 37);
            this.richTextBox11.Name = "richTextBox11";
            this.richTextBox11.Size = new System.Drawing.Size(145, 39);
            this.richTextBox11.TabIndex = 10;
            this.richTextBox11.Text = "duration of visit in minutes";
            // 
            // durationOfVisit
            // 
            this.durationOfVisit.Location = new System.Drawing.Point(557, 37);
            this.durationOfVisit.Name = "durationOfVisit";
            this.durationOfVisit.Size = new System.Drawing.Size(145, 39);
            this.durationOfVisit.TabIndex = 11;
            this.durationOfVisit.Text = "";
            // 
            // selectPrisonerId
            // 
            this.selectPrisonerId.FormattingEnabled = true;
            this.selectPrisonerId.Location = new System.Drawing.Point(201, 37);
            this.selectPrisonerId.Name = "selectPrisonerId";
            this.selectPrisonerId.Size = new System.Drawing.Size(121, 21);
            this.selectPrisonerId.TabIndex = 14;
            this.selectPrisonerId.SelectedIndexChanged += new System.EventHandler(this.selectPrisonerId_SelectedIndexChanged);
            // 
            // selectVisitorId
            // 
            this.selectVisitorId.FormattingEnabled = true;
            this.selectVisitorId.Location = new System.Drawing.Point(201, 98);
            this.selectVisitorId.Name = "selectVisitorId";
            this.selectVisitorId.Size = new System.Drawing.Size(121, 21);
            this.selectVisitorId.TabIndex = 15;
            // 
            // entryDateTime
            // 
            this.entryDateTime.Location = new System.Drawing.Point(224, 214);
            this.entryDateTime.Name = "entryDateTime";
            this.entryDateTime.Size = new System.Drawing.Size(200, 20);
            this.entryDateTime.TabIndex = 16;
            // 
            // exitDateTime
            // 
            this.exitDateTime.Location = new System.Drawing.Point(215, 281);
            this.exitDateTime.Name = "exitDateTime";
            this.exitDateTime.Size = new System.Drawing.Size(200, 20);
            this.exitDateTime.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(557, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prisonerName
            // 
            this.prisonerName.Location = new System.Drawing.Point(623, 195);
            this.prisonerName.Name = "prisonerName";
            this.prisonerName.Size = new System.Drawing.Size(145, 39);
            this.prisonerName.TabIndex = 20;
            this.prisonerName.Text = "";
            // 
            // richTextBox7
            // 
            this.richTextBox7.Location = new System.Drawing.Point(460, 195);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(145, 39);
            this.richTextBox7.TabIndex = 19;
            this.richTextBox7.Text = "prisonerName";
            // 
            // visitorName
            // 
            this.visitorName.Location = new System.Drawing.Point(623, 253);
            this.visitorName.Name = "visitorName";
            this.visitorName.Size = new System.Drawing.Size(145, 39);
            this.visitorName.TabIndex = 22;
            this.visitorName.Text = "";
            // 
            // richTextBox9
            // 
            this.richTextBox9.Location = new System.Drawing.Point(460, 253);
            this.richTextBox9.Name = "richTextBox9";
            this.richTextBox9.Size = new System.Drawing.Size(145, 39);
            this.richTextBox9.TabIndex = 21;
            this.richTextBox9.Text = "visitor name";
            // 
            // schedule_visit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.visitorName);
            this.Controls.Add(this.richTextBox9);
            this.Controls.Add(this.prisonerName);
            this.Controls.Add(this.richTextBox7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitDateTime);
            this.Controls.Add(this.entryDateTime);
            this.Controls.Add(this.selectVisitorId);
            this.Controls.Add(this.selectPrisonerId);
            this.Controls.Add(this.durationOfVisit);
            this.Controls.Add(this.richTextBox11);
            this.Controls.Add(this.purposeOfVisit);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox1);
            this.Name = "schedule_visit";
            this.Text = "v";
            this.Load += new System.EventHandler(this.schedule_visit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox purposeOfVisit;
        private System.Windows.Forms.RichTextBox richTextBox11;
        private System.Windows.Forms.RichTextBox durationOfVisit;
        private System.Windows.Forms.ComboBox selectPrisonerId;
        private System.Windows.Forms.ComboBox selectVisitorId;
        private System.Windows.Forms.DateTimePicker entryDateTime;
        private System.Windows.Forms.DateTimePicker exitDateTime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox prisonerName;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.RichTextBox visitorName;
        private System.Windows.Forms.RichTextBox richTextBox9;
    }
}