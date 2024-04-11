using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crime_App
{
    public partial class register_prisoner_to_activity : Form
    {
        public register_prisoner_to_activity()
        {
            InitializeComponent();
            fillIdComboBox(prisonerId,"select p_id as id from prisoners where p_id not in(select prisonerid from prisoner_activity_register)");
            fillIdComboBox(activityID, "select activityid  as id from  PrisonerActivity");
        }
        public SQLiteDataReader Db_Read(string query)
        {
            SQLiteConnection connection = Db_Connection();
            connection.Open(); // Open the connection before executing the query
            SQLiteCommand selectCommand = new SQLiteCommand(query, connection);
            // Add the parameter
            SQLiteDataReader reader = selectCommand.ExecuteReader();
            return reader;
        }
        public SQLiteConnection Db_Connection()
        {
            string connectionString = "Data Source=fir_db.db;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            return connection;
        }
        public void fillIdComboBox(ComboBox c, string query)
        {
            List<int> distinctIDs = new List<int>();
            new_prisoner_form n = new new_prisoner_form();

            SQLiteDataReader reader = Db_Read(query);
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["id"]);
                distinctIDs.Add(id);

            }
            foreach (int id in distinctIDs)
            {
                c.Items.Add(id);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve selected prisoner and activity IDs
            int prisoner_id = int.Parse(prisonerId.SelectedItem.ToString());
            int activity_id = int.Parse(activityID.SelectedItem.ToString());

            // Check if the record already exists
            if (IsCellNumberExists(prisoner_id, activity_id))
            {
                MessageBox.Show("Record Already Exists");
                return;
            }

            // If the record doesn't already exist, insert it
            string connectionString = "Data Source=fir_db.db;Version=3;";

            // SQL insert query
            string sql = "INSERT INTO prisoner_activity_register (prisonerId, activityId) VALUES (@prisonerId, @activityId)";

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                // Add parameters to the command
                command.Parameters.AddWithValue("@prisonerId", prisoner_id);
                command.Parameters.AddWithValue("@activityId", activity_id);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record inserted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert record.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Function to check if a record with the given prisonerId and activityId already exists


        public bool IsCellNumberExists(int prisoner_id, int activity_id)
        {
            // Check if the cell number already exists in the database
            string query = "SELECT COUNT(*) FROM prisoner_activity_register WHERE prisonerid = @prisoner_id and activityId=@activity_id";
            using (SQLiteConnection connection = Db_Connection())
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@prisoner_id", prisoner_id);

                    command.Parameters.AddWithValue("@activity_id", activity_id);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void register_prisoner_to_activity_Load(object sender, EventArgs e)
        {

        }
    }
}
