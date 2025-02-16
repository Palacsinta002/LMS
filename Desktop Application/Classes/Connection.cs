namespace Desktop_Application.Classes
{
    using MySql.Data.MySqlClient;

    internal class Connection
    {
        private readonly MySqlConnection _connection;

        // Constructor - initialize database
        public Connection()
        {
            string server = "vagvolgyinas.synology.me";
            string port = "3306";
            string database = "LMS";
            string uid = "lms";
            string password = "!LibraryMS25";

            // Connection string: Defines the login info for the database
            string connectionString = $"Server={server};Port={port};Database={database};User Id={uid};Password={password};";

            // Sets up the connection using connection string
            _connection = new MySqlConnection(connectionString);
        }

        // Opens connection with the defined database
        private bool OpenConnection()
        {
            try
            {
                _connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        // Closes connection with the defined database
        private bool CloseConnection()
        {
            try
            {
                _connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        // Accepts a query and returns an object array list with the results
        internal List<object[]> Select(string query)
        {
            List<object[]> result = [];
            if (OpenConnection())
            {
                using (MySqlCommand cmd = new(query, _connection))
                using (MySqlDataReader dataReader = cmd.ExecuteReader())
                    while (dataReader.Read())
                    {
                        object[] row = new object[dataReader.FieldCount];
                        dataReader.GetValues(row);
                        result.Add(row);
                    }
                CloseConnection();
            }
            return result;
        }

        // Accepts a query and runs it
        internal void RunSqlCommand(string query)
        {
            if (OpenConnection())
            {
                using (MySqlCommand cmd = new(query, _connection))
                    cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }
    }
}
