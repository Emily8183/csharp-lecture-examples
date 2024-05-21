namespace Chapter07;

public abstract class Product
{
    private static int nextId = 1;

    public readonly int id; // initialized in constructor

    public string Name { get; set; }
    public string Desc { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, string desc, double price, int quantity) 
    {
        id = nextId;
        Name = name;
        Desc = desc;
        Price = price;
        Quantity = quantity;
        nextId++;
    }

    public void IncreaseQuantity(int amount) 
    {
        Quantity += amount;
        Console.WriteLine(
            amount + " added to inventory for product " + 
            id + " - " + Name + Environment.NewLine
            );
    }

    public void DecreaseQuantity(int amount) 
    {
        Quantity -= amount;
        Console.WriteLine(
            amount + " removed from inventory for product " + 
            id + " - " + Name + Environment.NewLine
            );
    }

    public override string ToString() 
    {
        string nl = Environment.NewLine;
        return "PRODUCT INFORMATION:" + nl +
            "ID: " + id + nl +
            "Item: " + Name + nl +
            "Description: " + Desc + nl +
            "Price: " + Price + nl +
            "Quantity: " + Quantity + nl;
    }

    public abstract string Describe();
}
