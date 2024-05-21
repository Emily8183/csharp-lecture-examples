namespace Chapter07;

public abstract class Merchandise : Product
{

    public string Category { get; set; }
    public string Theme { get; set; }

    public Merchandise(string name, string desc, double price, int quantity, string category, string theme) : base(name, desc, price, quantity)
    {
        Category = category;
        Theme = theme;
    }

    public override string ToString()
    {
        string nl = Environment.NewLine;
        return base.ToString() +
            "Category: " + Category + nl +
            "Theme: " + Theme + nl;
    }
}
