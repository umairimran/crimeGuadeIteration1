using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Google.Protobuf.WellKnownTypes;
using System.Diagnostics.Eventing.Reader;

namespace Crime_App
{
    public partial class new_prisoner_form : Form
    {
        public new_prisoner_form()
        {
            InitializeComponent();
            fillIdComboBox();
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired position
            this.Location = new Point(20, 30);
            FormBorderStyle = FormBorderStyle.None;


        }

        public  SQLiteConnection Db_Connection()
        {
           string  connectionString = "Data Source=fir_db.db;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            return connection;
        }

        public SQLiteDataReader Db_Read(string query)
        {
            SQLiteConnection connection = Db_Connection();
            connection.Open(); // Open the connection before executing the query
            SQLiteCommand selectCommand = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = selectCommand.ExecuteReader();
            return reader;
        }
        private void selectPrisonId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void fillIdComboBox() {
            List<int> distinctIDs = new List<int>();
            SQLiteDataReader reader = Db_Read("select criminalId   as id from criminals where criminalId not in (Select  p_id as id from prisoners)");
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                distinctIDs.Add(id);

            }
            foreach (int id in distinctIDs)
            {
                selectPrisonId.Items.Add(id);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string prisoner_id;
            string prisoner_name;
            string prisoner_dob;
            string prisoner_meetTime;
            string prisoner_gender;
            string prisoner_admitDate;
            string prisoner_duration;

            prisoner_id = selectPrisonId.Text;
            prisoner_name = enterName.Text;
            prisoner_dob = selectDateOfBirth.Text;
            prisoner_meetTime = selectMeetTime.Text;
            prisoner_gender = selectGender.Text;
            prisoner_admitDate = selectAdmitDate.Text;
            prisoner_duration = punishDuration.Text;

            // Check if any of the fields are empty
            if (string.IsNullOrEmpty(prisoner_id) ||
                string.IsNullOrEmpty(prisoner_name) ||
                string.IsNullOrEmpty(prisoner_dob) ||
                string.IsNullOrEmpty(prisoner_meetTime) ||
                string.IsNullOrEmpty(prisoner_gender) ||
                string.IsNullOrEmpty(prisoner_admitDate) ||
                string.IsNullOrEmpty(prisoner_duration))
            {
                MessageBox.Show("Please fill in all fields.");
                return; // Exit the button function
            }

            // Proceed with the insertion query
            string query = "INSERT INTO prisoners (p_id, name, dob, gender, meetTime, admitDate, prisonDuration) VALUES (@pid, @name, @dob, @gender, @meetTime, @admitDate, @prisonDuration)";
            using (SQLiteConnection connection = new SQLiteConnection(Db_Connection()))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@pid", prisoner_id);
                    command.Parameters.AddWithValue("@name", prisoner_name);
                    command.Parameters.AddWithValue("@dob", prisoner_dob);
                    command.Parameters.AddWithValue("@gender", prisoner_gender);
                    command.Parameters.AddWithValue("@meetTime", prisoner_meetTime);
                    command.Parameters.AddWithValue("@admitDate", prisoner_admitDate);
                    command.Parameters.AddWithValue("@prisonDuration", prisoner_duration);
                    command.ExecuteNonQuery();
                }
            }

            // Show success message
            MessageBox.Show("Prisoner information inserted successfully.");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void new_prisoner_form_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            prisoner_form p = new prisoner_form();
            p.Show()
;        }

        private void punishDuration_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
