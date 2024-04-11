namespace Crime_App
{
    partial class register_prisoner_to_activity
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
            this.prisonerId = new System.Windows.Forms.ComboBox();
            this.activityID = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(48, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(150, 42);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "select prisoner id";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(48, 145);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(150, 42);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "select activity id";
            // 
            // prisonerId
            // 
            this.prisonerId.FormattingEnabled = true;
            this.prisonerId.Location = new System.Drawing.Point(233, 60);
            this.prisonerId.Name = "prisonerId";
            this.prisonerId.Size = new System.Drawing.Size(121, 21);
            this.prisonerId.TabIndex = 2;
            // 
            // activityID
            // 
            this.activityID.FormattingEnabled = true;
            this.activityID.Location = new System.Drawing.Point(233, 155);
            this.activityID.Name = "activityID";
            this.activityID.Size = new System.Drawing.Size(121, 21);
            this.activityID.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // register_prisoner_to_activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.activityID);
            this.Controls.Add(this.prisonerId);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "register_prisoner_to_activity";
            this.Text = "register_prisoner_to_activity";
            this.Load += new System.EventHandler(this.register_prisoner_to_activity_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ComboBox prisonerId;
        private System.Windows.Forms.ComboBox activityID;
        private System.Windows.Forms.Button button1;
    }
}