namespace Chapter08;

public class UsedBook : Book, IDiscountable
{
    public string Condition { get; set; }

    // Generate constructor after setting base class
    public UsedBook(
        string name,
        string desc,
        double price,
        int quantity,
        string author,
        string genre,
        string format,
        string condition
    )
        : base(name, desc, price, quantity, author, genre, format)
    {
        Condition = condition;
    }

    public override string ToString()
    {
        return base.ToString() + "Condition: " + Condition + Environment.NewLine;
    }

    public override string Describe()
    {
        string nl = Environment.NewLine;
        return Name + " by " + Author + nl
            + Desc + nl
            + Common.JoinWithPipe([Genre, Format, Condition, "$" + CurrentPrice.ToString()]) + nl;
    }

    // Apply discount to current price, not original price
    public void ApplyPercentDiscount(double percent)
    {
        // Handle possibility of percent being passed in as a number 1-100
        if (percent > 1)
        {
            percent /= 100.0;
        }
        double newPrice = CurrentPrice * (1 - percent);
        CurrentPrice = Math.Round(newPrice, 2); // round to nearest penny
        string text = CurrentPrice == OriginalPrice ? "Discount " : "Additional discount ";
        Console.WriteLine(
            text + "of " + (percent * 100) + "% has been applied to " + Name + Environment.NewLine
        );
    }

    // Apply discount to current price, not original price
    public void ApplyFlatDiscount(double amount)
    {
        CurrentPrice -= amount;
        string text = CurrentPrice == OriginalPrice ? "Discount " : "Additional discount ";
        Console.WriteLine(
            text + "of $" + amount + " has been applied to " + Name + Environment.NewLine
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
