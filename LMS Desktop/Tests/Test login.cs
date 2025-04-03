using System.Text.RegularExpressions;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        [TestCase("Nigger", "fos")]
        [TestCase("Nigger", "fos")]
        [TestCase("Nigger", "fos")]
        [TestCase("Nigger", "fos")]
        [TestCase("Nigger", "fos")]
        [TestCase("Nigger", "fos")]
        [TestCase("Nigger", "fos")]
        [TestCase("Nigger", "fos")]
        [TestCase("Nigger", "fos")]
        [TestCase("Nigger", "fos")]
        [TestCase("Nigger", "fos")]
        [TestCase("Nigger", "fos")]
        public void TestInput(string username, string password)
        {
            if(string.IsNullOrEmpty(username))
            {
                Assert.Fail("Username is empty");
            }
            else if(Regex.IsMatch(username, @"^[^""\\]+$"))
            {
                Assert.Fail("Username contains not allowed characters");
            }

            if (string.IsNullOrEmpty(password))
            {
                Assert.Fail("Password is empty");
            }
            else if (Regex.IsMatch(password, @"^[^""\\]+$"))
            {
                Assert.Fail("Password contains not allowed characters");
            }
        }
    }
}