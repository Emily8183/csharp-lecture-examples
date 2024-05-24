namespace Chapter08;

public abstract class Product
{
    private static int nextId = 1;

    public readonly int id; // initialized in constructor

    public string Name { get; set; }
    public string Desc { get; set; }
    public double OriginalPrice { get; set; }
    public double CurrentPrice { get; set; }
    public int Quantity { get; set; }

    public Product(string name, string desc, double price, int quantity)
    {
        id = nextId;
        Name = name;
        Desc = desc;
        OriginalPrice = price;
        CurrentPrice = price;
        Quantity = quantity;
        nextId++;
    }

    public void IncreaseQuantity(int amount)
    {
        Quantity += amount;
        Console.WriteLine(
            amount + " added to inventory for product " + id + " - " + Name + Environment.NewLine
        );
    }

    public void DecreaseQuantity(int amount)
    {
        Quantity -= amount;
        Console.WriteLine(
            amount
                + " removed from inventory for product " + id + " - "
                + Name + Environment.NewLine
        );
    }

    public override string ToString()
    {
        string nl = Environment.NewLine;
        return "PRODUCT INFORMATION:" + nl
            + "ID: " + id + nl
            + "Item: " + Name + nl
            + "Description: " + Desc + nl
            + "OriginalPrice: $" + OriginalPrice + nl
            + "CurrentPrice: $" + CurrentPrice + nl
            + "Quantity: " + Quantity + nl;
    }

    public abstract string Describe();
}
