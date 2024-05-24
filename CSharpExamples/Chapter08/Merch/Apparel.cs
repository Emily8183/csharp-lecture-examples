namespace Chapter08;

public class Apparel : Merchandise
{
    public readonly List<string> sizes = [];
    public readonly List<string> colors = [];

    public Apparel(
        string name,
        string desc,
        double price,
        int quantity,
        string category,
        string theme,
        string[] sizeArr,
        string[] colorArr
    )
        : base(name, desc, price, quantity, category, theme)
    {
        sizes.AddRange(sizeArr);
        colors.AddRange(colorArr);
    }

    public override string ToString()
    {
        string nl = Environment.NewLine;
        return base.ToString()
            + "Sizes: " + Common.JoinWithComma(sizes) + nl
            + "Colors: " + Common.JoinWithComma(colors) + nl;
    }

    public override string Describe()
    {
        string nl = Environment.NewLine;
        return Name + nl
            + Desc + nl
            + "Available Sizes: " + Common.JoinWithComma(sizes) + nl
            + "Available Colors: " + Common.JoinWithComma(colors) + nl
            + Common.JoinWithPipe([Category, Theme, "$" + CurrentPrice.ToString()]) + nl;
    }
}
