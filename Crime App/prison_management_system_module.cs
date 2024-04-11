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
        }

        private void prisoner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            prisoner_form p = new prisoner_form();
            p.Show();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            visitor_form v = new visitor_form();
        
            v.Show();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            doctor_management_module d = new doctor_management_module();
            d.Show();
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
            personalBelongingsManagementPortal p = new personalBelongingsManagementPortal();
            p.Show();
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
            activity_module m = new activity_module();
            m.Show();

        }
    }
}
