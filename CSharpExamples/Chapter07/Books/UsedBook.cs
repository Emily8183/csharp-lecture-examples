namespace Chapter07;

public class UsedBook : Book
{

    public string Condition { get; set; }

    // Generate constructor after setting base class
    public UsedBook(string name, string desc, double price, int quantity, string author, string genre, string format, string condition) : base(name, desc, price, quantity, author, genre, format)
    {
        Condition = condition;
    }

    public override string ToString()
    {
        return base.ToString() +
            "Condition: " + Condition + Environment.NewLine;
    }

    public override string Describe()
    {
        string nl = Environment.NewLine;
        return Name + " by " + Author + nl +
            Desc + nl +
            Common.JoinWithPipe([Genre, Format, Condition, Price.ToString()]) + nl;
    }
}
