using Chapter06;

namespace Chapter06Tests
{
    [TestClass]
    public class BookTests
    {
        // Declare (but do not initialize) test objects
        Book book1;
        Book book2;

        // Initialize test objects before each test
        [TestInitialize]
        public void SetUpTestData()
        {
            // ARRANGE
            book1 = new("Hidden Figures", "Margot Lee Shetterly", 271);
            book2 = new("Code Girls", "Liza Mundy");
        }

        // Test that Book constructor sets title correctly
        [TestMethod]
        public void FirstConstructorSetsTitle()
        {
            // ASSERT
            string message = "Book constructor sets title";
            Assert.AreEqual("Hidden Figures", book1.Title, message);
        }

        // Test that Book constructor sets title correctly
        [TestMethod]
        public void FirstConstructorSetsAuthor()
        {
            // ASSERT
            string message = "Book constructor sets author";
            Assert.AreEqual("Margot Lee Shetterly", book1.Author, message);
        }

        // Test that Book constructor sets numPages correctly
        [TestMethod]
        public void FirstConstructorSetsNumPages()
        {
            // ASSERT
            string message = "Book constructor sets numPages";
            Assert.AreEqual(271, book1.NumPages, message);
        }

        // Test that second Book constructor sets NumPages to default value
        [TestMethod]
        public void SecondConstructorSetsNumPages()
        {
            // ASSERT
            string message = "Second book constructor sets numPages to a default value";
            Assert.AreEqual(0, book2.NumPages, message);
        }

        // Test that a book id is generated correctly
        // This one requires a little more forethought on setting it up!
        [TestMethod]
        public void BookIdGenerated()
        {
            // ACT
            int nextId = Book.NextIdNum; // access static value of class
            Book book3 = new Book("The Secret Life of Bletchley Park", "Sinclair McKay", 322);
            // ASSERT
            string message = "a book ID is correctly generated using NextIdNum";
            Assert.AreEqual("SM-THE-" + nextId, book3.bookId, message);
        }

        // Test that title and author are concatenated properly
        [TestMethod]
        public void TitleAndAuthorConcatenated()
        {
            // ASSERT
            string message = "GetTitleAndAuthor() correctly concatenates title and author";
            Assert.AreEqual("Code Girls by Liza Mundy", book2.GetTitleAndAuthor(), message);
        }

        // Test that checking out a book sets available to false
        [TestMethod]
        public void CheckingOutBookMakesItUnavailable()
        {
            // ACT
            book1.CheckOut();
            // ASSERT
            string message = "Available is set to false when book is checked out";
            Assert.IsFalse(book1.Available, message);
        }

        // Test that checking a book back in sets available to true
        [TestMethod]
        public void CheckingBookInMakesItAvailable()
        {
            // ACT
            book2.CheckOut();
            book2.CheckIn();
            // ASSERT
            string message = "Available is set to true when book is checked in";
            Assert.IsTrue(book2.Available, message);
        }
    }
}
