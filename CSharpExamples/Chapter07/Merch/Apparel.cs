using System.Xml;

namespace Chapter07;

public class Apparel : Merchandise
{

    public readonly List<string> sizes = [];
    public readonly List<string> colors = [];

    public Apparel(string name, string desc, double price, int quantity, string category, string theme, string[] sizeArr, string[] colorArr) : base(name, desc, price, quantity, category, theme)
    {
        sizes.AddRange(sizeArr);
        colors.AddRange(colorArr);
    }

    public override string ToString()
    {
        string nl = Environment.NewLine;
        return base.ToString() +
            "Sizes: " + Common.JoinList(sizes) + nl +
            "Colors: " + Common.JoinList(colors) + nl;
    }

    public override string Describe()
    {
        string nl = Environment.NewLine;
        return Name + nl +
            Desc + nl +
            "Available Sizes: " + Common.JoinList(sizes) + nl +
            "Available Colors: " + Common.JoinList(colors) + nl +
            Category + Common.PIPE + Theme + Common.PIPE + Price + nl;
    }
}
