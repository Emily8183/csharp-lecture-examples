namespace Chapter07;

public class Drinkware : Merchandise
{
    public string Material { get; set; }
    public double Ounces { get; set; }

    public Drinkware(string name, string desc, double price, int quantity, string category, string theme, string material, double ounces) : base(name, desc, price, quantity, category, theme)
    {
        Material = material;
        Ounces = ounces;
    }

    public override string ToString()
    {
        string nl = Environment.NewLine;
        return base.ToString() +
            "Material: " + Material + nl +
            "Volume: " + Ounces + " ounces" + nl;
    }

    public override string Describe()
    {
        string nl = Environment.NewLine;
        return Ounces + "-oz. " + Material + " " + Name + nl +
            Desc + nl +
            Common.JoinWithPipe([Category, Theme, Price.ToString()]) + nl;
    }
}
