namespace Chapter03
{
    public class Lists
    {
        public static void RunExamples()
        {
            /* DECLARING LISTS */

            // TODO: Declare two empty lists
            // elves, for data of type string
            // ages, for data of type int
            List<string> elves = new List<string>(); // classic syntax
            List<int> ages = []; // new syntax

            /* ADDING ELEMENTS TO LISTS */

            // TODO: Add elements to each of the lists above

            // 4 well-known elves
            elves.Add("Legolas");
            elves.Add("Arwen");
            elves.Add("Elrond");
            elves.Add("Galadriel");

            // 4 ages of elves above
            ages.Add(2931);
            ages.Add(2901);
            ages.Add(6497);
            ages.Add(8382);

            /* PRINTING LISTS */

            // TODO: Print each list
            Console.WriteLine(string.Join(", ", elves));
            Console.WriteLine(string.Join(", ", ages));

            /* USING LIST METHODS */

            // TODO: Print the count of elves
            Console.WriteLine(elves.Count);

            // TODO: Check to see if ages contains 2901 and print the result
            Console.WriteLine(ages.Contains(2901));

            // TODO: Sort elves and then print it
            elves.Sort();
            Console.WriteLine(string.Join(", ", elves));

            // And now the ages of the elves are not in the same order as the names
            // We will fix this with dictionaries, where we can keep them paired together
        }
    }
}