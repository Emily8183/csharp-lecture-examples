namespace Chapter08Tests;

using Chapter08;

[TestClass]
public class UsedBookTests
{
    // Declare a used book with the type IDiscountable
    IDiscountable horton;

    [TestInitialize]
    public void SetUpTestData()
    {
        // Instantiate the used book
        horton = new UsedBook(
            "Horton Hears a Who",
            "Learn about kindness with Horton",
            12.00,
            4,
            "Dr. Seuss",
            "children's fiction",
            "hardcover",
            "very good"
        );
    }

    [TestMethod]
    public void CanReceivePercentDiscount()
    {
        horton.ApplyPercentDiscount(0.5);
        string message =
            "a new UsedBook object can be given a percent discount through the IDiscountable interface";
        Assert.AreEqual(6, ((UsedBook)horton).CurrentPrice, 0.0, message);
    }

    [TestMethod]
    public void CanReceiveFlatDiscount()
    {
        horton.ApplyFlatDiscount(2);
        string message =
            "a new UsedBook object can be given a flat discount through the IDiscountable interface";
        Assert.AreEqual(10, ((UsedBook)horton).CurrentPrice, 0.0, message);
    }

    [TestMethod]
    public void CanReceiveMultipleDiscounts()
    {
        horton.ApplyFlatDiscount(2);
        horton.ApplyPercentDiscount(0.50);
        string message =
            "a new UsedBook object can be given multiple discounts through the IDiscountable interface";
        Assert.AreEqual(5, ((UsedBook)horton).CurrentPrice, 0.0, message);
    }

    [TestMethod]
    public void CanRemoveDiscount()
    {
        horton.ApplyFlatDiscount(2);
        horton.RemoveDiscount();
        string message =
            "a new UsedBook object can have its discount removed through the IDiscountable interface";
        Assert.AreEqual(12, ((UsedBook)horton).CurrentPrice, 0.0, message);
    }
}
