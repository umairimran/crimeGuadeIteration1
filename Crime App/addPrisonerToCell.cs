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
    public partial class addPrisonerToCell : Form
    {
        public addPrisonerToCell()
        {
            InitializeComponent();
            fillIdComboBox(selectCellId, "SELECT cellid as id FROM cell WHERE occupancy <  (SELECT capacity FROM cell) ");
            fillIdComboBox(selectPrisonerId, "select p_id as id from prisoners   where id not in (select prisonerid from prisoners_cell) ");

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

            SQLiteDataReader reader = n.Db_Read(query);
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
        private void selectCellId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool IsCellNumberExists(int cellNumber,int prisoner_Id)
        {
            // Check if the cell number already exists in the database
            string query = "SELECT COUNT(*) FROM prisoners_cell WHERE cellid = @cellNumber and prisonerid=@prisonerId";
            using (SQLiteConnection connection = Db_Connection())
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@cellNumber", cellNumber);

                    command.Parameters.AddWithValue("@prisonerId", prisoner_Id);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cell_number = int.Parse(selectCellId.SelectedItem.ToString());
            int prisoner_id = int.Parse(selectPrisonerId.SelectedItem.ToString());

            if (IsCellNumberExists(cell_number,prisoner_id))
            {
                MessageBox.Show("Cell number already exists. Please enter a different cell number.");
                return;
            }





            string query = @"insert into prisoners_cell (cellId,prisonerId) values(@cell_number,@prisoner_id)";
            string connectionString = "Data Source=fir_db.db;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {

                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@cell_number", cell_number);
                    command.Parameters.AddWithValue("@prisoner_id", prisoner_id);


                    command.ExecuteNonQuery();
                }
                query = "UPDATE cell SET occupancy = occupancy + 1 WHERE cellid = @cell_id";
                using (SQLiteCommand command2 = new SQLiteCommand(query, connection))
                {
                    command2.Parameters.AddWithValue("@cell_id", cell_number);
                    command2.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Prisoner Assigned successfully and occupancy updated successfullly!!");
        }
    }
}
