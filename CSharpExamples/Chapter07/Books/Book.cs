namespace Chapter07;

public class Book : Product
{
    public string Author { get; set; }
    public string Genre { get; set; }
    public string Format { get; set; }

    public Book(string name, string desc, double price, int quantity, string author, string genre, string format) : base(name, desc, price, quantity)
    {
        Author = author;
        Genre = genre;
        Format = format;
    }

    public override string ToString() {
        string nl = Environment.NewLine;
        return base.ToString() +
            "Author: " + Author + nl +
            "Genre: " + Genre + nl +
            "Format: " + Format + nl;
    }

    public override string Describe() {
        string nl = Environment.NewLine;
        return Name + " by " + Author + nl +
            Desc + nl +
            Common.JoinWithPipe([Genre, Format, "$" + Price.ToString()]) + nl;
    }
}

