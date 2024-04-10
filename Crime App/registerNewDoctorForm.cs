using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crime_App
{
    public partial class registerNewDoctorForm : Form
    {
        public registerNewDoctorForm()
        {
            InitializeComponent();
            

        }

        private void registerNewDoctorForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string doctor_name = doctorName.Text;
            string doctor_specialization = selectDoctorSpecialization.SelectedItem.ToString();
            string doctor_gender = selectDoctorGender.SelectedItem.ToString();
            string doctor_dob = doctorDob.Text;
            string doctor_start_time = selectAvailabilityStart.Text; // Assuming these are TextBox controls
            string doctor_end_time = selectAvailabilityEnd.Text;
            string doctor_language = doctorLanguage.Text;

            string query = "INSERT INTO doctor " +
                           "(name, specialization, gender, dob, " +
                           "availability_start, availability_end, language) " +
                           "VALUES (@doctor_name, @doctor_specialization, " +
                           "@doctor_gender, @doctor_dob, @doctor_start_time, " +
                           "@doctor_end_time, @doctor_language)";

            string connectionString = "Data Source=fir_db.db;";


            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@doctor_name", doctor_name);
                    command.Parameters.AddWithValue("@doctor_specialization", doctor_specialization);
                    command.Parameters.AddWithValue("@doctor_gender", doctor_gender);
                    command.Parameters.AddWithValue("@doctor_dob", doctor_dob);
                    command.Parameters.AddWithValue("@doctor_start_time", doctor_start_time);
                    command.Parameters.AddWithValue("@doctor_end_time", doctor_end_time);
                    command.Parameters.AddWithValue("@doctor_language", doctor_language);

                    try
                    {
                       
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data inserted successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }





    }
}
