namespace Desktop_Application.Classes
{
    using MySql.Data.MySqlClient;

    internal class Connection
    {
        // https://www.codeproject.com/Articles/43438/Connect-Csharp-to-MySQL

        private MySqlConnection _connection;
        private string _server;
        private string _database;
        private string _uid;
        private string _password;

        // Constructor
        public Connection()
        {
            SetConnection();
        }

        // Initialize values
        private void SetConnection()
        {
            // Login info
            _server = "vagvolgyinas.synology.me";
            _database = "LMS";
            _uid = "mysql";
            _password = "!LibraryMS25";

            // Connection string: Defines the login info for the database
            string connectionString = $"SERVER={_server};DATABASE={_database};UID={_uid};PASSWORD={_password};";

            // Sets the connection string to the database
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
    }
}
