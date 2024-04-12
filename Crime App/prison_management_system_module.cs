using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crime_App
{
    public partial class prison_management_system_module : Form
    {
        public prison_management_system_module()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;
        }

        private void prisoner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {
            cell_management c = new cell_management();
            c.Show();
        }

        private void activityDepartment_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {
        

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {
            inventory_department_module v = new inventory_department_module();
            v.Show();

        }

        private void prison_management_system_module_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard d = new Dashboard();
            d.Show();
;        }

        private void button1_Click(object sender, EventArgs e)
        {
            prisoner_form p = new prisoner_form();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            staff_management_module s = new staff_management_module();
            s.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personalBelongingsManagementPortal p = new personalBelongingsManagementPortal();
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            doctor_management_module d = new doctor_management_module();
            d.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            visitor_form v = new visitor_form();

            v.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            activity_module v = new activity_module();
            v.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cell_management c = new cell_management();
            c.Show();
        }

        private void staff_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox4_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
