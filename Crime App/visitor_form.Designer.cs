namespace Crime_App
{
    partial class visitor_form
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
            this.viewMedicalReport = new System.Windows.Forms.Panel();
            this.scheduleVisit = new System.Windows.Forms.Panel();
            this.registerVisitor = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.visitorProvideThings = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.viewMedicalReport.SuspendLayout();
            this.scheduleVisit.SuspendLayout();
            this.registerVisitor.SuspendLayout();
            this.visitorProvideThings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.visitorProvideThings);
            this.panel1.Controls.Add(this.viewMedicalReport);
            this.panel1.Controls.Add(this.scheduleVisit);
            this.panel1.Controls.Add(this.registerVisitor);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 659);
            this.panel1.TabIndex = 0;
            // 
            // viewMedicalReport
            // 
            this.viewMedicalReport.BackColor = System.Drawing.Color.Crimson;
            this.viewMedicalReport.Controls.Add(this.richTextBox3);
            this.viewMedicalReport.Location = new System.Drawing.Point(333, 68);
            this.viewMedicalReport.Name = "viewMedicalReport";
            this.viewMedicalReport.Size = new System.Drawing.Size(256, 105);
            this.viewMedicalReport.TabIndex = 2;
            // 
            // scheduleVisit
            // 
            this.scheduleVisit.BackColor = System.Drawing.Color.Crimson;
            this.scheduleVisit.Controls.Add(this.richTextBox2);
            this.scheduleVisit.Location = new System.Drawing.Point(71, 179);
            this.scheduleVisit.Name = "scheduleVisit";
            this.scheduleVisit.Size = new System.Drawing.Size(256, 105);
            this.scheduleVisit.TabIndex = 1;
            // 
            // registerVisitor
            // 
            this.registerVisitor.BackColor = System.Drawing.Color.Crimson;
            this.registerVisitor.Controls.Add(this.button1);
            this.registerVisitor.Location = new System.Drawing.Point(71, 68);
            this.registerVisitor.Name = "registerVisitor";
            this.registerVisitor.Size = new System.Drawing.Size(256, 105);
            this.registerVisitor.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // visitorProvideThings
            // 
            this.visitorProvideThings.BackColor = System.Drawing.Color.Crimson;
            this.visitorProvideThings.Controls.Add(this.richTextBox1);
            this.visitorProvideThings.Location = new System.Drawing.Point(333, 179);
            this.visitorProvideThings.Name = "visitorProvideThings";
            this.visitorProvideThings.Size = new System.Drawing.Size(256, 105);
            this.visitorProvideThings.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(35, 17);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(148, 61);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "visitor can submit the thinkgs for prisoner and that will be recorded in bellongi" +
    "ngs";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(27, 17);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(148, 61);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "visitor can schedule a visit based on the timings  of the prosiner and then it wi" +
    "ll be entered in the scheduled table and after some time the table of session do" +
    "ne will alsobe updated";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(54, 22);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(148, 61);
            this.richTextBox3.TabIndex = 1;
            this.richTextBox3.Text = "visitor can view the medical report of the prisoner";
            // 
            // visitor_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 661);
            this.Controls.Add(this.panel1);
            this.Name = "visitor_form";
            this.Text = "visitor_form";
            this.panel1.ResumeLayout(false);
            this.viewMedicalReport.ResumeLayout(false);
            this.scheduleVisit.ResumeLayout(false);
            this.registerVisitor.ResumeLayout(false);
            this.visitorProvideThings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel viewMedicalReport;
        private System.Windows.Forms.Panel scheduleVisit;
        private System.Windows.Forms.Panel registerVisitor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel visitorProvideThings;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}