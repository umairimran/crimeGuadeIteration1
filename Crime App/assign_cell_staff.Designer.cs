namespace Crime_App
{
    partial class assign_cell_staff
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
            this.cellId = new System.Windows.Forms.ComboBox();
            this.staffId = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(92, 82);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(148, 42);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "select cellid";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(92, 166);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(148, 42);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "select staff id";
            // 
            // cellId
            // 
            this.cellId.FormattingEnabled = true;
            this.cellId.Location = new System.Drawing.Point(348, 94);
            this.cellId.Name = "cellId";
            this.cellId.Size = new System.Drawing.Size(121, 21);
            this.cellId.TabIndex = 2;
            // 
            // staffId
            // 
            this.staffId.FormattingEnabled = true;
            this.staffId.Location = new System.Drawing.Point(348, 181);
            this.staffId.Name = "staffId";
            this.staffId.Size = new System.Drawing.Size(121, 21);
            this.staffId.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // assign_cell_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.staffId);
            this.Controls.Add(this.cellId);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "assign_cell_staff";
            this.Text = "assign_cell_staff";
            this.Load += new System.EventHandler(this.assign_cell_staff_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ComboBox cellId;
        private System.Windows.Forms.ComboBox staffId;
        private System.Windows.Forms.Button button1;
    }
}