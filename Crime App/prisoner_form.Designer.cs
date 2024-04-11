namespace Crime_App
{
    partial class prisoner_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prisoner_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.getToDoctor = new System.Windows.Forms.Panel();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.buyFromInventory = new System.Windows.Forms.Panel();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.orderMeal = new System.Windows.Forms.Panel();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.registerInActivity = new System.Windows.Forms.Panel();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.viewBelongings = new System.Windows.Forms.Panel();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.viewMedicalReport = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.newPrisoner = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.getToDoctor.SuspendLayout();
            this.buyFromInventory.SuspendLayout();
            this.orderMeal.SuspendLayout();
            this.registerInActivity.SuspendLayout();
            this.viewBelongings.SuspendLayout();
            this.viewMedicalReport.SuspendLayout();
            this.newPrisoner.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.getToDoctor);
            this.panel1.Controls.Add(this.buyFromInventory);
            this.panel1.Controls.Add(this.orderMeal);
            this.panel1.Controls.Add(this.registerInActivity);
            this.panel1.Controls.Add(this.viewBelongings);
            this.panel1.Controls.Add(this.viewMedicalReport);
            this.panel1.Controls.Add(this.newPrisoner);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1323, 659);
            this.panel1.TabIndex = 0;
            // 
            // getToDoctor
            // 
            this.getToDoctor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.getToDoctor.Controls.Add(this.richTextBox6);
            this.getToDoctor.Location = new System.Drawing.Point(37, 238);
            this.getToDoctor.Name = "getToDoctor";
            this.getToDoctor.Size = new System.Drawing.Size(200, 100);
            this.getToDoctor.TabIndex = 4;
            // 
            // richTextBox6
            // 
            this.richTextBox6.Location = new System.Drawing.Point(28, 3);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(142, 94);
            this.richTextBox6.TabIndex = 0;
            this.richTextBox6.Text = resources.GetString("richTextBox6.Text");
            this.richTextBox6.TextChanged += new System.EventHandler(this.richTextBox6_TextChanged);
            // 
            // buyFromInventory
            // 
            this.buyFromInventory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buyFromInventory.Controls.Add(this.richTextBox7);
            this.buyFromInventory.Location = new System.Drawing.Point(37, 132);
            this.buyFromInventory.Name = "buyFromInventory";
            this.buyFromInventory.Size = new System.Drawing.Size(200, 100);
            this.buyFromInventory.TabIndex = 3;
            // 
            // richTextBox7
            // 
            this.richTextBox7.Location = new System.Drawing.Point(43, 20);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(100, 48);
            this.richTextBox7.TabIndex = 0;
            this.richTextBox7.Text = "buy from inventory";
            // 
            // orderMeal
            // 
            this.orderMeal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.orderMeal.Controls.Add(this.richTextBox5);
            this.orderMeal.Location = new System.Drawing.Point(463, 132);
            this.orderMeal.Name = "orderMeal";
            this.orderMeal.Size = new System.Drawing.Size(200, 100);
            this.orderMeal.TabIndex = 2;
            this.orderMeal.Paint += new System.Windows.Forms.PaintEventHandler(this.orderMeal_Paint);
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(23, 19);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(134, 40);
            this.richTextBox5.TabIndex = 0;
            this.richTextBox5.Text = "order meal";
            // 
            // registerInActivity
            // 
            this.registerInActivity.BackColor = System.Drawing.SystemColors.ControlLight;
            this.registerInActivity.Controls.Add(this.richTextBox4);
            this.registerInActivity.Location = new System.Drawing.Point(254, 132);
            this.registerInActivity.Name = "registerInActivity";
            this.registerInActivity.Size = new System.Drawing.Size(200, 100);
            this.registerInActivity.TabIndex = 2;
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(27, 19);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(113, 49);
            this.richTextBox4.TabIndex = 0;
            this.richTextBox4.Text = "register in activity";
            this.richTextBox4.TextChanged += new System.EventHandler(this.richTextBox4_TextChanged);
            // 
            // viewBelongings
            // 
            this.viewBelongings.BackColor = System.Drawing.SystemColors.ControlLight;
            this.viewBelongings.Controls.Add(this.richTextBox3);
            this.viewBelongings.Location = new System.Drawing.Point(463, 26);
            this.viewBelongings.Name = "viewBelongings";
            this.viewBelongings.Size = new System.Drawing.Size(200, 100);
            this.viewBelongings.TabIndex = 2;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(23, 21);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(125, 35);
            this.richTextBox3.TabIndex = 0;
            this.richTextBox3.Text = "view bellongings";
            this.richTextBox3.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // viewMedicalReport
            // 
            this.viewMedicalReport.BackColor = System.Drawing.SystemColors.ControlLight;
            this.viewMedicalReport.Controls.Add(this.richTextBox2);
            this.viewMedicalReport.Location = new System.Drawing.Point(243, 26);
            this.viewMedicalReport.Name = "viewMedicalReport";
            this.viewMedicalReport.Size = new System.Drawing.Size(200, 100);
            this.viewMedicalReport.TabIndex = 1;
            this.viewMedicalReport.Paint += new System.Windows.Forms.PaintEventHandler(this.viewMedicalReport_Paint);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(38, 16);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(129, 40);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "view medical report";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // newPrisoner
            // 
            this.newPrisoner.BackColor = System.Drawing.SystemColors.ControlLight;
            this.newPrisoner.Controls.Add(this.richTextBox1);
            this.newPrisoner.Location = new System.Drawing.Point(37, 26);
            this.newPrisoner.Name = "newPrisoner";
            this.newPrisoner.Size = new System.Drawing.Size(200, 100);
            this.newPrisoner.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(18, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(152, 40);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "add new prisoner";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // prisoner_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 661);
            this.Controls.Add(this.panel1);
            this.Name = "prisoner_form";
            this.Text = "prisoner_form";
            this.panel1.ResumeLayout(false);
            this.getToDoctor.ResumeLayout(false);
            this.buyFromInventory.ResumeLayout(false);
            this.orderMeal.ResumeLayout(false);
            this.registerInActivity.ResumeLayout(false);
            this.viewBelongings.ResumeLayout(false);
            this.viewMedicalReport.ResumeLayout(false);
            this.newPrisoner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel registerInActivity;
        private System.Windows.Forms.Panel viewBelongings;
        private System.Windows.Forms.Panel viewMedicalReport;
        private System.Windows.Forms.Panel newPrisoner;
        private System.Windows.Forms.Panel getToDoctor;
        private System.Windows.Forms.Panel buyFromInventory;
        private System.Windows.Forms.Panel orderMeal;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox7;
    }
}