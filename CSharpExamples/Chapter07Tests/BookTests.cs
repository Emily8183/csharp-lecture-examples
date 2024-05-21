namespace Chapter07Tests;

using Chapter07;

[TestClass]
public class BookTests
{
    Book book;

    [TestInitialize]
    public void SetUpTestData()
    {
        book = new("Call Us What We Carry", "A luminous collection from America's youngest presidential inaugural poet", 24.99, 12, "Amanda Gorman", "Poetry", "Hardcover");
    }

    [TestMethod]
    public void NameFieldIsInherited()
    {
        string message = "a new Book object is given a name through the Product class constructor";
        Assert.AreEqual("Call Us What We Carry", book.Name, message);
    }

    [TestMethod]
    public void PriceFieldIsInherited()
    {
        string message = "a new Book object is given a price through the Product class constructor";
        Assert.AreEqual(24.99, book.Price, message);
    }

    // Etc.
}