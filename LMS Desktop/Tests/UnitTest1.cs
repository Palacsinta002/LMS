namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            string query = $"SELECT Users.Password, Roles.Role FROM Users JOIN Roles ON Roles.id = Users.RoleID WHERE Username = '{_username}'";
            var result = HandleQueries.SelectFromString(query);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}