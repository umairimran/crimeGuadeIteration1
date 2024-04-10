namespace Crime_App
{
    partial class doctor_reports_database_view
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
            this.selectDoctorId = new System.Windows.Forms.ComboBox();
            this.selectPrisonerId = new System.Windows.Forms.ComboBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(81, 36);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(128, 39);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "select doctor id";
            // 
            // selectDoctorId
            // 
            this.selectDoctorId.FormattingEnabled = true;
            this.selectDoctorId.Location = new System.Drawing.Point(81, 90);
            this.selectDoctorId.Name = "selectDoctorId";
            this.selectDoctorId.Size = new System.Drawing.Size(121, 21);
            this.selectDoctorId.TabIndex = 1;
            this.selectDoctorId.SelectedIndexChanged += new System.EventHandler(this.selectDoctorId_SelectedIndexChanged);
            // 
            // selectPrisonerId
            // 
            this.selectPrisonerId.FormattingEnabled = true;
            this.selectPrisonerId.Location = new System.Drawing.Point(313, 81);
            this.selectPrisonerId.Name = "selectPrisonerId";
            this.selectPrisonerId.Size = new System.Drawing.Size(121, 21);
            this.selectPrisonerId.TabIndex = 3;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(313, 36);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(128, 39);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "select prisoner id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(167, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(299, 193);
            this.dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 61);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // doctor_reports_database_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.selectPrisonerId);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.selectDoctorId);
            this.Controls.Add(this.richTextBox1);
            this.Name = "doctor_reports_database_view";
            this.Text = "doctor_reports_database_view";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox selectDoctorId;
        private System.Windows.Forms.ComboBox selectPrisonerId;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}