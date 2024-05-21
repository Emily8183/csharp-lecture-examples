namespace Chapter07;

public abstract class Product
{
    public static int NextId { get; set; } = 1;

    public readonly int id; // initialized in constructor

    public string Name { get; set; }
    public string Desc { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, string desc, double price, int quantity) 
    {
        id = NextId;
        Name = name;
        Desc = desc;
        Price = price;
        Quantity = quantity;
        NextId++;
    }

    public void IncreaseQuantity(int amount) 
    {
        Quantity += amount;
    }

    public void DecreaseQuantity(int amount) 
    {
        Quantity -= amount;
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
