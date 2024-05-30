namespace Chapter11;

public class Apparel : Product, IDiscountable
{
    public Apparel(string name, double price)
        : base(name, price) { }

    public void Discount(double percent)
    {
        string nl = Environment.NewLine;
        if (percent > 1)
            percent /= 100.0;
        CurrentPrice -= Math.Round(OriginalPrice * percent, 2);
        Console.WriteLine(nl + Name + " was originally $" + OriginalPrice + " and has now been discounted to $" + CurrentPrice + "." + nl);
    }
}
