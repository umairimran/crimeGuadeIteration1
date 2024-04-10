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
    public partial class newCell : Form
    {
        public newCell()
        {
            InitializeComponent();
                       cellNumber.Clear();
            cellCapacity.Clear();
            discription.Clear();
            maintainanceNotes.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public SQLiteConnection Db_Connection()
        {
            string connectionString = "Data Source=fir_db.db;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            return connection;
        }
        private void button1_Click(object sender, EventArgs e)
        {


            int cell_number=int.Parse(cellNumber.Text);
            if (IsCellNumberExists(cell_number))
            {
                MessageBox.Show("Cell number already exists. Please enter a different cell number.");
                return;
            }


            int cell_capacity =int.Parse(cellCapacity.Text);
            string cell_description = discription.Text;
            string security_level = securityLevel.SelectedItem.ToString();
            string maintenance_notes = maintainanceNotes.Text;
            string inspection_date = startInspectionDate.Text;
            string next_inspection_date = nextInspectionDate.Text;
            int cell_occupancy = 0; // Default value for now
            string cell_cleanliness = cleanliness.Text;
            string cell_accessibility = accessibility.Text;
            string cell_status = "Available";
            if (!string.IsNullOrEmpty(cell_description) &&
                !string.IsNullOrEmpty(security_level) &&
                !string.IsNullOrEmpty(maintenance_notes) &&
                !string.IsNullOrEmpty(inspection_date) &&
                !string.IsNullOrEmpty(next_inspection_date) &&
                !string.IsNullOrEmpty(cell_cleanliness) &&
                !string.IsNullOrEmpty(cell_accessibility) &&
                int.TryParse(cellNumber.Text, out cell_number) &&
                int.TryParse(cellCapacity.Text, out cell_capacity))
            {
                // Proceed with the data as all conditions are met
                string query = @"INSERT INTO cell 
                     (cellNumber, capacity, occupancy, description, securityLevel, 
                     maintenanceNotes, lastInspectionDate, nextInspectionDate, cleanliness, accessibility,status)
                     VALUES 
                     (@cellNumber, @cellCapacity, @cellOccupancy, @cellDescription, @securityLevel, 
                     @maintenanceNotes, @lastInspectionDate, @nextInspectionDate, @cleanliness, @accessibility,@status)";

                using (SQLiteConnection connection = Db_Connection())
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@cellNumber", cell_number);
                        command.Parameters.AddWithValue("@cellCapacity", cell_capacity);
                        command.Parameters.AddWithValue("@cellOccupancy", cell_occupancy);
                        command.Parameters.AddWithValue("@cellDescription", cell_description);
                        command.Parameters.AddWithValue("@securityLevel", security_level);
                        command.Parameters.AddWithValue("@maintenanceNotes", maintenance_notes);
                        command.Parameters.AddWithValue("@lastInspectionDate", inspection_date);
                        command.Parameters.AddWithValue("@nextInspectionDate", next_inspection_date);
                        command.Parameters.AddWithValue("@cleanliness", cell_cleanliness);
                        command.Parameters.AddWithValue("@accessibility", cell_accessibility);
                        command.Parameters.AddWithValue("@status", cell_status);

                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                }

            }
            else
            {
                // Show message to enter data again
                MessageBox.Show("Please make sure all fields are filled correctly. Enter data again.");
                // Or any other action you want to take if the conditions fail
            }

            // Check if the cell number already exists

            // Prepare the INSERT query
           
            // Optionally display a success message or perform other actions
        }

        private bool IsCellNumberExists(int cellNumber)
        {
            // Check if the cell number already exists in the database
            string query = "SELECT COUNT(*) FROM cell WHERE cellNumber = @cellNumber";
            using (SQLiteConnection connection = Db_Connection())
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@cellNumber", cellNumber);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }


    }
}
