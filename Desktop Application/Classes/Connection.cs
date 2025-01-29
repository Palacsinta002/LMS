namespace Desktop_Application.Classes
{
    using MySql.Data.MySqlClient;
    using System.Text.RegularExpressions;

    internal class Connection
    {
        //https://youtu.be/eJi02kg-S8g
        // https://www.codeproject.com/Articles/43438/Connect-Csharp-to-MySQL
        // https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli // sql lekérdezéses cucli

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
        internal void SetConnection()
        {
            // Login info
            _server = "localhost";
            _database = "LMS";
            _uid = "lms";
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

        //internal List<string>[] SelectOutOfDate(string query)
        //{
        //    string[] columns = ExtractColumns(query);

        //    List<string>[] result = new List<string>[columns.Length];
        //    for (int i = 0; i < columns.Length; i++)
        //    {
        //        result[i] = new List<string>();
        //    }
        //    if (OpenConnection())
        //    {
        //        using (var cmd = new MySqlCommand(query, _connection))
        //        using (var dataReader = cmd.ExecuteReader())
        //        {
        //            while (dataReader.Read())
        //            {
        //                for (int i = 0; i < columns.Length; i++)
        //                {
        //                    result[i].Add(dataReader[columns[i]]?.ToString() ?? string.Empty);
        //                }
        //            }
        //        }
        //        CloseConnection();
        //    }
        //    return result;
        //}

        //private string[] ExtractColumns(string query)
        //{
        //    var match = Regex.Match(query, @"SELECT (.+?) FROM", RegexOptions.IgnoreCase);
        //    if (!match.Success)
        //    {
        //        MessageBox.Show("Unable to extract columns from query.");
        //        throw new InvalidOperationException("Unable to extract columns from query.");
        //    }
        //    return match.Groups[1].Value
        //    .Split(',')
        //    .Select(col =>
        //    {
        //        col = col.Trim();
        //        if (col.Contains(" AS ", StringComparison.OrdinalIgnoreCase))
        //        {
        //            // Handle alias
        //            return col.Split([" AS "], StringSplitOptions.None)[1].Trim();
        //        }
        //        return col.Split(' ').Last(); // Fallback for functions or spaces
        //    })
        //    .ToArray();
        //}
    }
}
