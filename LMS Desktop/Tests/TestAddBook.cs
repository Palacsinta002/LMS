using System.Text.RegularExpressions;

namespace Tests
{
    internal class TestAddBook
    {
        [Test]
        [TestCase("")]
        [TestCase("\"No title\"")]
        [TestCase("Good title")]
        public void TestTitle(string title)
        {
            if (title == string.Empty)
            {
                Assert.Fail("Title is required");
            }
            else if (!Regex.IsMatch(title, @"^[^""\\]+$"))
            {
                Assert.Fail("Title contains not allowed characters");
            }
            Assert.Pass();
        }

        [Test]
        [TestCase("")]
        [TestCase("200")]
        [TestCase("15323")]
        [TestCase("fdsagdsa")]
        [TestCase("20rrfdsa05")]
        [TestCase("2005")]
        public void TestPubYear(string pubYear)
        {
            if (!Regex.IsMatch(pubYear, "^[0-9]{4}$"))
            {
                Assert.Fail("Publication year is not a 4 digit number");
            }
            Assert.Pass();
        }

        [Test]
        [TestCase("")]
        [TestCase("J. K. Rowling")]
        public void TestAuthor(string author) {
            if (author == string.Empty)
            {
                Assert.Fail("Author is empty");
            }
            Assert.Pass();
        }

        [Test]
        [TestCase("")]
        [TestCase("Action")]
        public void TestCategory(string category)
        {
            if (category == string.Empty)
            {
                Assert.Fail("Category is empty");
            }
            Assert.Pass();
        }

        [Test]
        [TestCase("")]
        [TestCase("Agave")]
        public void TestPublisher(string publisher)
        {
            if (publisher == string.Empty)
            {
                Assert.Fail("Publisher is empty");
            }
            Assert.Pass();
        }

        [Test]
        [TestCase("")]
        [TestCase("fdsafdsa")]
        [TestCase("fdsf5432432")]
        [TestCase("4356432")]
        [TestCase("1234567890123")]
        public void TestIsbn(string isbn)
        {
            if (!Regex.IsMatch(isbn, "^[0-9]{13}$"))
            {
                Assert.Fail("ISBN is not a 13 digit number");
            }
            Assert.Pass();
        }
    }
}
