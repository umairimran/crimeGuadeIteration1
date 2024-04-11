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
    public partial class view_activity_in_data_view : Form
    {
        public view_activity_in_data_view()
        {
            InitializeComponent();
            fillIdComboBox(activityId, "select activityId as id  from prisoner_activity_register");
            fillIdComboBox2(activityName, " select distinct activityName  as id from Activity");
            fillIdComboBox(activityDuration, "select distinct duration  as id from activity ");
            fillIdComboBox(prisonerId, "select prisonerid as id from prisoner_activity_register");
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

        public void fillIdComboBox2(ComboBox c, string query)
        {
            List<string> distinctIDs = new List<string>();
            new_prisoner_form n = new new_prisoner_form();

            SQLiteDataReader reader = n.Db_Read(query);
            while (reader.Read())
            {
                string id = (reader["id"].ToString());
                distinctIDs.Add(id);

            }
            foreach (string id in distinctIDs)
            {
                c.Items.Add(id);
            }
        }


        private void view_activity_in_data_view_Load(object sender, EventArgs e)
        {

        }

        private void activityName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=fir_db.db;Version=3;";

            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();
                try
                {
                    string district = prisonerId.SelectedItem?.ToString();
                    string division = activityId.SelectedItem?.ToString();
                    string crimeType = activityDuration.SelectedItem?.ToString();
                    string weapon = activityName.SelectedItem?.ToString();

                    // Start building the WHERE clause of the SQL query
                    string whereClause = "WHERE 1=1 "; // Start with a true condition to allow easy appending
                    string whereClause2 = "WHere 1=1 ";
                    // Add conditions for each selected value, excluding nulls (not selected)
                    if (!string.IsNullOrEmpty(district))
                        whereClause2 += $" AND prisonerid = '{district}'";

                    if (!string.IsNullOrEmpty(division))
                        whereClause2 += $" AND activityId = '{division}'";

                    if (!string.IsNullOrEmpty(crimeType))
                        whereClause += $" AND duration = '{crimeType}'";

                    if (!string.IsNullOrEmpty(weapon))
                        whereClause += $" AND activityname = '{weapon}'";


                    // Final SQL query
                    string query = "SELECT * FROM activity " + whereClause;
                    string query2 = "select * from prisoner_activity_register " + whereClause2;
                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable table = new DataTable();


                            table.Columns.Add("activityname", typeof(string));
                            table.Columns.Add("duration", typeof(string));

                            while (reader.Read())
                            {
                                string activityName = reader["activityName"].ToString();
                                string duration = reader["duration"].ToString();

                                table.Rows.Add(activityName, duration);
                            }

                            dataGridView1.DataSource = table;
                        }


                    }
                    using (SQLiteCommand cmd = new SQLiteCommand(query2, con))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {

                            DataTable table2 = new DataTable();
                            table2.Columns.Add("prisonerId", typeof(int));
                            table2.Columns.Add("activityid", typeof(int));


                            while (reader.Read())
                            {
                                int prisonerId = reader.GetInt32(reader.GetOrdinal("prisonerId"));
                                int activityId = reader.GetInt32(reader.GetOrdinal("activityid"));

                                table2.Rows.Add(prisonerId, activityId);
                            }

                            dataGridView2.DataSource = table2;
                        }


                    }



                }
                catch (Exception ex)
                {
                    // Log or display the exception
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
