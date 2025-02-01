namespace Desktop_Application.Classes
{
    using MySql.Data.MySqlClient;

    internal class Connection
    {
        //https://youtu.be/eJi02kg-S8g - Grid design
        // https://www.codeproject.com/Articles/43438/Connect-Csharp-to-MySQL

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

        internal List<object[]> Select(string query)
        {
            List<object[]> result = [];
            if (OpenConnection())
            {
                using var cmd = new MySqlCommand(query, _connection);
                using var dataReader = cmd.ExecuteReader();
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

        internal void Delete(string query)
        {
            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, _connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }
    }
}
