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
    public partial class doctor_management_module : Form
    {
        public doctor_management_module()
        {
            InitializeComponent();
        }

        private void registerNewDoctor_TextChanged(object sender, EventArgs e)
        {
            registerNewDoctorForm d = new registerNewDoctorForm();
            d.Show();
        }

        private void viewReportOfSpecificPrisoner_TextChanged(object sender, EventArgs e)
        {
            view_medical_report_form v = new view_medical_report_form();
            v.Show();
        }

        private void viewReports_TextChanged(object sender, EventArgs e)
        {
            doctor_reports_database_view v = new doctor_reports_database_view();
            v.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            view_doctor_information d = new view_doctor_information();
            d.Show();

        }
    }
}
