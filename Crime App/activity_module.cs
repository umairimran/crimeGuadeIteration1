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
    public partial class activity_module : Form
    {
        public activity_module()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            create_new_activity a = new create_new_activity();
            a.Show();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            register_prisoner_to_activity a = new register_prisoner_to_activity();
            a.Show();
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            view_activity_in_data_view v = new view_activity_in_data_view();
            v.Show();
        }
    }
}
