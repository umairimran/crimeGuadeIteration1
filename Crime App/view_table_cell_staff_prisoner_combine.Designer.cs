namespace Crime_App
{
    partial class view_table_cell_staff_prisoner_combine
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
            this.selectCellid = new System.Windows.Forms.ComboBox();
            this.selectPrisonerId = new System.Windows.Forms.ComboBox();
            this.selectStaffId = new System.Windows.Forms.ComboBox();
            this.selectCellId2 = new System.Windows.Forms.ComboBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.staff_cell_table = new System.Windows.Forms.DataGridView();
            this.prisoner_cell_table = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.staff_cell_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisoner_cell_table)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(56, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(118, 34);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "select cell id";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(203, 46);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(118, 34);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "select prisoner id";
            // 
            // selectCellid
            // 
            this.selectCellid.FormattingEnabled = true;
            this.selectCellid.Location = new System.Drawing.Point(56, 86);
            this.selectCellid.Name = "selectCellid";
            this.selectCellid.Size = new System.Drawing.Size(121, 21);
            this.selectCellid.TabIndex = 2;
            // 
            // selectPrisonerId
            // 
            this.selectPrisonerId.FormattingEnabled = true;
            this.selectPrisonerId.Location = new System.Drawing.Point(203, 86);
            this.selectPrisonerId.Name = "selectPrisonerId";
            this.selectPrisonerId.Size = new System.Drawing.Size(121, 21);
            this.selectPrisonerId.TabIndex = 3;
            this.selectPrisonerId.SelectedIndexChanged += new System.EventHandler(this.selectPrisonerId_SelectedIndexChanged);
            // 
            // selectStaffId
            // 
            this.selectStaffId.FormattingEnabled = true;
            this.selectStaffId.Location = new System.Drawing.Point(203, 198);
            this.selectStaffId.Name = "selectStaffId";
            this.selectStaffId.Size = new System.Drawing.Size(121, 21);
            this.selectStaffId.TabIndex = 7;
            // 
            // selectCellId2
            // 
            this.selectCellId2.FormattingEnabled = true;
            this.selectCellId2.Location = new System.Drawing.Point(56, 198);
            this.selectCellId2.Name = "selectCellId2";
            this.selectCellId2.Size = new System.Drawing.Size(121, 21);
            this.selectCellId2.TabIndex = 6;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(203, 158);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(118, 34);
            this.richTextBox3.TabIndex = 5;
            this.richTextBox3.Text = "selecct staaff id";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(56, 158);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(118, 34);
            this.richTextBox4.TabIndex = 4;
            this.richTextBox4.Text = "select cell id";
            // 
            // staff_cell_table
            // 
            this.staff_cell_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staff_cell_table.Location = new System.Drawing.Point(22, 225);
            this.staff_cell_table.Name = "staff_cell_table";
            this.staff_cell_table.Size = new System.Drawing.Size(240, 150);
            this.staff_cell_table.TabIndex = 8;
            // 
            // prisoner_cell_table
            // 
            this.prisoner_cell_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prisoner_cell_table.Location = new System.Drawing.Point(410, 42);
            this.prisoner_cell_table.Name = "prisoner_cell_table";
            this.prisoner_cell_table.Size = new System.Drawing.Size(240, 150);
            this.prisoner_cell_table.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 59);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // view_table_cell_staff_prisoner_combine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prisoner_cell_table);
            this.Controls.Add(this.staff_cell_table);
            this.Controls.Add(this.selectStaffId);
            this.Controls.Add(this.selectCellId2);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.selectPrisonerId);
            this.Controls.Add(this.selectCellid);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "view_table_cell_staff_prisoner_combine";
            this.Text = "view_table_cell_staff_prisoner_combine";
            this.Load += new System.EventHandler(this.view_table_cell_staff_prisoner_combine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staff_cell_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prisoner_cell_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ComboBox selectCellid;
        private System.Windows.Forms.ComboBox selectPrisonerId;
        private System.Windows.Forms.ComboBox selectStaffId;
        private System.Windows.Forms.ComboBox selectCellId2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.DataGridView staff_cell_table;
        private System.Windows.Forms.DataGridView prisoner_cell_table;
        private System.Windows.Forms.Button button1;
    }
}