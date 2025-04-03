using System.Text.RegularExpressions;

namespace Tests
{
    public class Tests
    {
        [Test]
        [TestCase("", "halo")]
        [TestCase("\"halo\"", "halo")]
        [TestCase("halo", "")]
        [TestCase("halo", "\"halo\"")]
        [TestCase("halo", "halo")]
        public void TestInput(string username, string password)
        {
            if(string.IsNullOrEmpty(username))
            {
                Assert.Fail("Username is empty");
            }
            else if(Regex.IsMatch(username, @"^[""\\]+$"))
            {
                Assert.Fail("Username contains not allowed characters");
            }

            if (string.IsNullOrEmpty(password))
            {
                Assert.Fail("Password is empty");
            }
            else if (Regex.IsMatch(password, @"^[""\\]+$"))
            {
                Assert.Fail("Password contains not allowed characters");
            }
            Assert.Pass();
        }

        [Test]
        [TestCase("Admin")]
        [TestCase("Librarian")]
        [TestCase("Member")]
        public void TestRole(string role)
        {
            bool isAdmin = role == "Admin";
            if(role == "Member"){
                Assert.Fail("Member cant log in");
            }
            else if(isAdmin)
            {
                Assert.Pass("The user is admin");
            }
            else
            {
                Assert.Pass("The user is not admin");
            }
        }
    }
}