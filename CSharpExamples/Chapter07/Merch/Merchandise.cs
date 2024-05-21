namespace Chapter07;

// TODO: Refactor class to inherit from Product
// TODO: Make class abstract for extending to Drinkware, Apparel
public class Merchandise
{
    private static int nextId = 1;

    public readonly int id; // initialized in constructor

    public string Name { get; set; }
    public string Desc { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public string Category { get; set; }
    public string Theme { get; set; }

    public Merchandise(string name, string desc, double price, int quantity, string category, string theme)
    {
        id = nextId;
        Name = name;
        Desc = desc;
        Price = price;
        Quantity = quantity;
        Category = category;
        Theme = theme;
        nextId++;
    }

    public void IncreaseQuantity(int amount) 
    {
        Quantity += amount;
    }

    public void DecreaseQuantity(int amount) 
    {
        Quantity -= amount;
    }

    public override string ToString() {
        string nl = Environment.NewLine;
        return "PRODUCT INFORMATION:" + nl +
            "ID: " + id + nl +
            "Item: " + Name + nl +
            "Description: " + Desc + nl +
            "Price: " + Price + nl +
            "Quantity: " + Quantity + nl +
            "Category: " + Category + nl +
            "Theme: " + Theme + nl;
    }

}
