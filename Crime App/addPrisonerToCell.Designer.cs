﻿namespace Crime_App
{
    partial class addPrisonerToCell
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
            this.selectCellId = new System.Windows.Forms.ComboBox();
            this.selectPrisonerId = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(114, 77);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(249, 47);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "select Cell Id";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(114, 185);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(249, 47);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "select Prisoner id";
            // 
            // selectCellId
            // 
            this.selectCellId.FormattingEnabled = true;
            this.selectCellId.Location = new System.Drawing.Point(410, 77);
            this.selectCellId.Name = "selectCellId";
            this.selectCellId.Size = new System.Drawing.Size(121, 21);
            this.selectCellId.TabIndex = 2;
            this.selectCellId.SelectedIndexChanged += new System.EventHandler(this.selectCellId_SelectedIndexChanged);
            // 
            // selectPrisonerId
            // 
            this.selectPrisonerId.FormattingEnabled = true;
            this.selectPrisonerId.Location = new System.Drawing.Point(421, 195);
            this.selectPrisonerId.Name = "selectPrisonerId";
            this.selectPrisonerId.Size = new System.Drawing.Size(121, 21);
            this.selectPrisonerId.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(468, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addPrisonerToCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectPrisonerId);
            this.Controls.Add(this.selectCellId);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "addPrisonerToCell";
            this.Text = "addPrisonerToCell";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ComboBox selectCellId;
        private System.Windows.Forms.ComboBox selectPrisonerId;
        private System.Windows.Forms.Button button1;
    }
}