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

    // TODO: Test that a Book object is given a name through inheritance
    
    // TODO: Test that a Book object is given a price through inheritance

    // Etc.
}