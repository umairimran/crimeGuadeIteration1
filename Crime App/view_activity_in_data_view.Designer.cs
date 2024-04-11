namespace Crime_App
{
    partial class view_activity_in_data_view
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
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.activityName = new System.Windows.Forms.ComboBox();
            this.activityDuration = new System.Windows.Forms.ComboBox();
            this.prisonerId = new System.Windows.Forms.ComboBox();
            this.activityId = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(53, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(163, 39);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "selet Activity Name";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(460, 101);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(163, 39);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "select activity id";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(460, 44);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(163, 39);
            this.richTextBox5.TabIndex = 4;
            this.richTextBox5.Text = "select prisoner id";
            // 
            // richTextBox6
            // 
            this.richTextBox6.Location = new System.Drawing.Point(53, 122);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(163, 39);
            this.richTextBox6.TabIndex = 5;
            this.richTextBox6.Text = "sekect duration";
            // 
            // activityName
            // 
            this.activityName.FormattingEnabled = true;
            this.activityName.Items.AddRange(new object[] {
            ""});
            this.activityName.Location = new System.Drawing.Point(232, 78);
            this.activityName.Name = "activityName";
            this.activityName.Size = new System.Drawing.Size(121, 21);
            this.activityName.TabIndex = 6;
            this.activityName.SelectedIndexChanged += new System.EventHandler(this.activityName_SelectedIndexChanged);
            // 
            // activityDuration
            // 
            this.activityDuration.FormattingEnabled = true;
            this.activityDuration.Items.AddRange(new object[] {
            ""});
            this.activityDuration.Location = new System.Drawing.Point(232, 140);
            this.activityDuration.Name = "activityDuration";
            this.activityDuration.Size = new System.Drawing.Size(121, 21);
            this.activityDuration.TabIndex = 7;
            // 
            // prisonerId
            // 
            this.prisonerId.FormattingEnabled = true;
            this.prisonerId.Items.AddRange(new object[] {
            ""});
            this.prisonerId.Location = new System.Drawing.Point(646, 60);
            this.prisonerId.Name = "prisonerId";
            this.prisonerId.Size = new System.Drawing.Size(121, 21);
            this.prisonerId.TabIndex = 8;
            // 
            // activityId
            // 
            this.activityId.FormattingEnabled = true;
            this.activityId.Items.AddRange(new object[] {
            ""});
            this.activityId.Location = new System.Drawing.Point(655, 101);
            this.activityId.Name = "activityId";
            this.activityId.Size = new System.Drawing.Size(121, 21);
            this.activityId.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(358, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(460, 190);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 12;
            // 
            // view_activity_in_data_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.activityId);
            this.Controls.Add(this.prisonerId);
            this.Controls.Add(this.activityDuration);
            this.Controls.Add(this.activityName);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "view_activity_in_data_view";
            this.Text = "view_activity_in_data_view";
            this.Load += new System.EventHandler(this.view_activity_in_data_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.ComboBox activityName;
        private System.Windows.Forms.ComboBox activityDuration;
        private System.Windows.Forms.ComboBox prisonerId;
        private System.Windows.Forms.ComboBox activityId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}