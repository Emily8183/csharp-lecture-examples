namespace Chapter07;

// TODO: Refactor class to inherit from Product
public class Book
{
    private static int nextId = 1;

    public readonly int id; // initialized in constructor

    public string Name { get; set; }
    public string Desc { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public string Format { get; set; }

    public Book(string name, string desc, double price, int quantity, string author, string genre, string format)
    {
        id = nextId;
        Name = name;
        Desc = desc;
        Price = price;
        Quantity = quantity;
        Author = author;
        Genre = genre;
        Format = format;
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
            "Price $: " + Price + nl +
            "Quantity: " + Quantity + nl +
            "Author: " + Author + nl +
            "Genre: " + Genre + nl +
            "Format: " + Format + nl;
    }

    // TODO: Implement Describe() as required by Product
}
