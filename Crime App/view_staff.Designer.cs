namespace Crime_App
{
    partial class view_staff
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
            this.staffGender = new System.Windows.Forms.ComboBox();
            this.staffPosition = new System.Windows.Forms.ComboBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.staffDepartment = new System.Windows.Forms.ComboBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.staffTrainingCertification = new System.Windows.Forms.ComboBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.staffAccessRights = new System.Windows.Forms.ComboBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(28, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(140, 39);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "select gender";
            // 
            // staffGender
            // 
            this.staffGender.FormattingEnabled = true;
            this.staffGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.staffGender.Location = new System.Drawing.Point(186, 28);
            this.staffGender.Name = "staffGender";
            this.staffGender.Size = new System.Drawing.Size(121, 21);
            this.staffGender.TabIndex = 1;
            // 
            // staffPosition
            // 
            this.staffPosition.FormattingEnabled = true;
            this.staffPosition.Location = new System.Drawing.Point(186, 85);
            this.staffPosition.Name = "staffPosition";
            this.staffPosition.Size = new System.Drawing.Size(121, 21);
            this.staffPosition.TabIndex = 3;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(28, 85);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(140, 39);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "select position";
            // 
            // staffDepartment
            // 
            this.staffDepartment.FormattingEnabled = true;
            this.staffDepartment.Location = new System.Drawing.Point(186, 145);
            this.staffDepartment.Name = "staffDepartment";
            this.staffDepartment.Size = new System.Drawing.Size(121, 21);
            this.staffDepartment.TabIndex = 5;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(28, 145);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(140, 39);
            this.richTextBox3.TabIndex = 4;
            this.richTextBox3.Text = "select department";
            // 
            // staffTrainingCertification
            // 
            this.staffTrainingCertification.FormattingEnabled = true;
            this.staffTrainingCertification.Location = new System.Drawing.Point(186, 212);
            this.staffTrainingCertification.Name = "staffTrainingCertification";
            this.staffTrainingCertification.Size = new System.Drawing.Size(121, 21);
            this.staffTrainingCertification.TabIndex = 7;
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(28, 212);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(140, 39);
            this.richTextBox4.TabIndex = 6;
            this.richTextBox4.Text = "select certification";
            // 
            // staffAccessRights
            // 
            this.staffAccessRights.FormattingEnabled = true;
            this.staffAccessRights.Location = new System.Drawing.Point(186, 273);
            this.staffAccessRights.Name = "staffAccessRights";
            this.staffAccessRights.Size = new System.Drawing.Size(121, 21);
            this.staffAccessRights.TabIndex = 9;
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(28, 273);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(140, 39);
            this.richTextBox5.TabIndex = 8;
            this.richTextBox5.Text = "staff access rights";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(364, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(247, 232);
            this.dataGridView1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // view_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.staffAccessRights);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.staffTrainingCertification);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.staffDepartment);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.staffPosition);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.staffGender);
            this.Controls.Add(this.richTextBox1);
            this.Name = "view_staff";
            this.Text = "view_staff";
            this.Load += new System.EventHandler(this.view_staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox staffGender;
        private System.Windows.Forms.ComboBox staffPosition;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ComboBox staffDepartment;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.ComboBox staffTrainingCertification;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.ComboBox staffAccessRights;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}