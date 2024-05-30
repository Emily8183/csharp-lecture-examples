namespace Chapter11;

public abstract class Product
{
    private static int nextId = 1;
    public readonly int id;
    public string Name { get; set; }
    public double OriginalPrice { get; set; }
    public double CurrentPrice { get; set; }

    public Product(string name, double price)
    {
        id = nextId;
        nextId++;
        Name = name;
        OriginalPrice = price;
        CurrentPrice = price;
    }
}
