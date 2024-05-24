namespace Chapter08;

public abstract class Merchandise : Product, IDiscountable
{
    public string Category { get; set; }
    public string Theme { get; set; }

    public Merchandise(
        string name,
        string desc,
        double price,
        int quantity,
        string category,
        string theme
    )
        : base(name, desc, price, quantity)
    {
        Category = category;
        Theme = theme;
    }

    public override string ToString()
    {
        string nl = Environment.NewLine;
        return base.ToString() + "Category: " + Category + nl + "Theme: " + Theme + nl;
    }

    // Apply discount to original price only
    public void ApplyPercentDiscount(double percent)
    {
        // Handle possibility of percent being passed in as a number 1-100
        if (percent > 1)
        {
            percent /= 100.0;
        }
        double newPrice = OriginalPrice * (1 - percent);
        CurrentPrice = Math.Round(newPrice, 2); // round to nearest penny
        Console.WriteLine(
            "Discount of " + (percent * 100) + "% has been applied to " + Name + Environment.NewLine
        );
    }

    // Apply discount to original price only
    public void ApplyFlatDiscount(double amount)
    {
        CurrentPrice = OriginalPrice - amount;
        Console.WriteLine(
            "Discount of $" + amount + " has been applied to " + Name + Environment.NewLine
        );
    }

    public void RemoveDiscount()
    {
        CurrentPrice = OriginalPrice;
        Console.WriteLine(
            Name + " has been reset to its original price of $"
                + OriginalPrice + Environment.NewLine
        );
    }
}
