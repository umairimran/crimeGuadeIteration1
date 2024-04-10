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
    public partial class visitor_form : Form
    {
        public visitor_form()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            visitor_register_form v = new visitor_register_form();
            v.Show();
;        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            view_medical_report_form x = new view_medical_report_form();
            x.Show();
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            create_new_belonging c= new create_new_belonging();
            c.Show();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            schedule_visit s = new schedule_visit()
;   s.Show();
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
            view_visitors_history v = new view_visitors_history();
            v.Show();
        }
    }
}
