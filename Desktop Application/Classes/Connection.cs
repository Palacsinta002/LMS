namespace Desktop_Application.Classes
{
    using MySql.Data.MySqlClient;

    internal class Connection
    {
        //https://youtu.be/eJi02kg-S8g - Grid design

        private MySqlConnection _connection;
        private string _server;
        private string _database;
        private string _uid;
        private string _password;

        // Constructor - initialize database
        public Connection()
        {
            _server = "localhost";
            _database = "LMS";
            _uid = "lms";
            _password = "!LibraryMS25";

            // Connection string: Defines the login info for the database
            string connectionString = $"SERVER={_server};DATABASE={_database};UID={_uid};PASSWORD={_password};";

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
                MessageBox.Show(ex.Message);
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
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // Accepts a query and returns an object array list with the results
        internal List<object[]> Select(string query)
        {
            List<object[]> result = [];
            if (OpenConnection())
            {
                var cmd = new MySqlCommand(query, _connection);
                var dataReader = cmd.ExecuteReader();
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
                MySqlCommand cmd = new(query, _connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }
    }
}
