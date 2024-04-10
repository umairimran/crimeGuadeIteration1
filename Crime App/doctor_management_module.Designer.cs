namespace Crime_App
{
    partial class doctor_management_module
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
            this.viewReportOfSpecificPrisoner = new System.Windows.Forms.RichTextBox();
            this.viewReports = new System.Windows.Forms.RichTextBox();
            this.registerNewDoctor = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.viewReportOfSpecificPrisoner);
            this.panel1.Controls.Add(this.viewReports);
            this.panel1.Controls.Add(this.registerNewDoctor);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 659);
            this.panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(478, 206);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(266, 82);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "view doctor information";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // viewReportOfSpecificPrisoner
            // 
            this.viewReportOfSpecificPrisoner.Location = new System.Drawing.Point(140, 206);
            this.viewReportOfSpecificPrisoner.Name = "viewReportOfSpecificPrisoner";
            this.viewReportOfSpecificPrisoner.Size = new System.Drawing.Size(266, 82);
            this.viewReportOfSpecificPrisoner.TabIndex = 2;
            this.viewReportOfSpecificPrisoner.Text = "doctor can view report by selecting the naem and id of prisoner";
            this.viewReportOfSpecificPrisoner.TextChanged += new System.EventHandler(this.viewReportOfSpecificPrisoner_TextChanged);
            // 
            // viewReports
            // 
            this.viewReports.Location = new System.Drawing.Point(511, 40);
            this.viewReports.Name = "viewReports";
            this.viewReports.Size = new System.Drawing.Size(214, 82);
            this.viewReports.TabIndex = 1;
            this.viewReports.Text = "doctor can view the medical reports in form of database";
            this.viewReports.TextChanged += new System.EventHandler(this.viewReports_TextChanged);
            // 
            // registerNewDoctor
            // 
            this.registerNewDoctor.Location = new System.Drawing.Point(119, 40);
            this.registerNewDoctor.Name = "registerNewDoctor";
            this.registerNewDoctor.Size = new System.Drawing.Size(266, 82);
            this.registerNewDoctor.TabIndex = 0;
            this.registerNewDoctor.Text = "register new doctor from this page";
            this.registerNewDoctor.TextChanged += new System.EventHandler(this.registerNewDoctor_TextChanged);
            // 
            // doctor_management_module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 661);
            this.Controls.Add(this.panel1);
            this.Name = "doctor_management_module";
            this.Text = "doctor_form";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox registerNewDoctor;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox viewReportOfSpecificPrisoner;
        private System.Windows.Forms.RichTextBox viewReports;
    }
}