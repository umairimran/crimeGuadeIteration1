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
using System.Windows.Forms.VisualStyles;

namespace Crime_App
{
    public partial class view_prisoner_belongings : Form
    {
        public view_prisoner_belongings()
        {
            InitializeComponent();
            fillIdComboBox(selectPrisonerId, "select distinct prisonerId as id from prisonerBelongings");
        }
        public void fillIdComboBox(ComboBox c, string query)
        {
            List<int> distinctIDs = new List<int>();
            new_prisoner_form n = new new_prisoner_form();
            SQLiteConnection connection = Db_Connection();
            connection.Open(); // Open the connection before executing the query
            SQLiteCommand selectCommand = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = selectCommand.ExecuteReader();
           
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
        public SQLiteDataReader Db_Read(string query, int prisonerId)
        {
            SQLiteConnection connection = Db_Connection();
            connection.Open(); // Open the connection before executing the query

            SQLiteCommand selectCommand = new SQLiteCommand(query, connection);
            selectCommand.Parameters.AddWithValue("@prisonerId", prisonerId); // Use the correct parameter name

            SQLiteDataReader reader = selectCommand.ExecuteReader();
           
            // Return the reader, don't close the connection here to allow the caller to manage it
            return reader;
        }
        public SQLiteConnection Db_Connection()
        {
            string connectionString = "Data Source=fir_db.db;";
            SQLiteConnection connection = new SQLiteConnection(connectionString);
            return connection;
        }
        private void selectPrisonerId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int prisoner_Id = Convert.ToInt32(selectPrisonerId.SelectedItem);
            string prisoner_name = "";
            string item_name = "";
            string item_description = "";
            string item_condition = "";
            string storage_location = "";
            string date_acquired = "";
            string item_status = "";
            string item_notes = "";
            prisonerName.Clear();
            itemName.Clear();
            desctiption.Clear();
            condition.Clear();
            storageLocation.Clear();
            dateAcquired.Clear();
            status.Clear();
            notes.Clear();
            SQLiteDataReader reader = Db_Read("SELECT name FROM prisoners WHERE p_id = @prisonerId", prisoner_Id);

            // Check if there are rows returned
            if (reader.Read())
            {
                // Get the value of the "name" column from the first row
                string prisonerNameValue = reader["name"].ToString();

                // Append the prisoner name to the text box
                prisonerName.AppendText(prisonerNameValue);
            }

            SQLiteDataReader reader2 = Db_Read("SELECT itemName, description, condition, storageLocation, dateAcquired, status, notes FROM prisonerBelongings WHERE prisonerid = @prisonerId", prisoner_Id);

            if (reader2 != null && reader2.HasRows)
            {
                while (reader2.Read())
                {
                    // Retrieve data from the reader and assign it to variables
                     item_name = reader2["itemName"].ToString();
                     item_description = reader2["description"].ToString();
                     storage_location = reader2["storageLocation"].ToString();
                     date_acquired = reader2["dateAcquired"].ToString();
                     item_status = reader2["status"].ToString();
                     item_notes = reader2["notes"].ToString();
                    item_condition = reader2["condition"].ToString();
                    // Set the textbox text properties
                    itemName.Text = item_name;
                    desctiption.Text = item_description;
                    condition.Text = item_condition;
                    storageLocation.Text = storage_location;
                    dateAcquired.Text = date_acquired;
                    status.Text = item_status;
                    notes.Text = item_notes;
                }
            }




        }
    }
}
