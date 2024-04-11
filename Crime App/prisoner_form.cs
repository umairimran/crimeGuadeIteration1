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
    public partial class prisoner_form : Form
    {
        public prisoner_form()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            new_prisoner_form n = new new_prisoner_form();
            n.Show();
        }

        private void viewMedicalReport_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            view_medical_report_form f = new view_medical_report_form();
            f.Show();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            view_prisoner_belongings p = new view_prisoner_belongings();
            p.Show();
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            register_prisoner_to_activity r = new register_prisoner_to_activity();
            r.Show();
        }

        private void orderMeal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {
            create_medical_report c = new create_medical_report();
            c.Show();
        }
    }
}
