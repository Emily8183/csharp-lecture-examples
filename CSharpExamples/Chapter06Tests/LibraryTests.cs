using Chapter06;

namespace Chapter06Tests;

[TestClass]
public class LibraryTests
{
    // Declare (but do not initialize) test objects
    Book book1;
    Book book2;
    Library library;

    // Initialize test objects before each test
    [TestInitialize]
    public void SetUpTestData()
    {
        // ARRANGE
        book1 = new("Hidden Figures", "Margot Lee Shetterly", 271);
        book2 = new("Code Girls", "Liza Mundy");
        library = new();
    }

    // Test that a new library object contains an empty list of books
    [TestMethod]
    public void NewLibraryHasEmptyBookList()
    {
        // ASSERT Part 1
        string notNullMessage = "A new library should contain a list of books";
        Assert.IsNotNull(library.books, notNullMessage); // good idea to check before using .Count
        // ASSERT Part 2
        string emptyMessage = "A new library's book list should be empty";
        int expected = 0;
        int actual = library.books.Count;
        Assert.AreEqual(expected, actual, emptyMessage);
    }

    // Test that the .AddBook() method is working
    [TestMethod]
    public void CanAddBooksToList()
    {
        // ACT
        library.AddBook(book1);
        // ASSERT Part 1
        string containsMessage = "Book list should contain a book that was added";
        Assert.IsTrue(library.books.Contains(book1), containsMessage);
        // ASSERT Part 2
        string countMessage = "Book list count increases when book is added.";
        Assert.AreEqual(1, library.books.Count, countMessage);
    }

    // Test that FindBook() returns the index of an existing book
    [TestMethod]
    public void FindBookReturnsIndex()
    {
        // ACT
        library.AddBook(book1);
        // ASSERT
        string message = "FindBook() returns index of book that has been added";
        Assert.AreEqual(library.FindBook(book1.Title, book1.Author), 0, message);
    }

    // Test that FindBook() returns -1 if book is not found
    [TestMethod]
    public void FindBookReturnsNeg1()
    {
        // ACT
        library.AddBook(book1);
        // ASSERT
        string message = "FindBook() returns -1 if book is not found";
        Assert.AreEqual(library.FindBook(book2.Title, book2.Author), -1, message);
    }

    // Test that overridden Equals() compares on title and author only
    [TestMethod]
    public void LibraryEqualityBasedOnTitleAndAuthor()
    {
        // ARRANGE (additional data)
        Book book1Dupe = new("Hidden Figures", "Margot Lee Shetterly", 271);
        Book book2Dupe = new("Code Girls", "Liza Mundy");
        Library libraryDupe = new();
        // ACT
        library.AddBook(book1);
        library.AddBook(book2);
        libraryDupe.AddBook(book1Dupe);
        libraryDupe.AddBook(book2Dupe);
        // ASSERT
        string message = "Custom Equals() method compares libraries on title and author only";
        bool condition = Equals(library, libraryDupe);
        Assert.IsTrue(condition, message);
    }
}
