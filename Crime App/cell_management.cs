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
    public partial class cell_management : Form
    {
        public cell_management()
        {
            InitializeComponent();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            newCell n = new newCell();
            n.Show();

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
            addPrisonerToCell c= new addPrisonerToCell();
            c.Show();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            viewParticularCell v = new viewParticularCell();
            v.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            assign_cell_staff s = new assign_cell_staff();
            s.Show();
;
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
            view_table_cell_staff_prisoner_combine c = new view_table_cell_staff_prisoner_combine();
            c.Show();


        }
    }
}
