namespace Chapter03
{
    public class Dictionaries
    {
        public static void RunExamples()
        {
            /* CREATING A DICTIONARY AND ADDING KEY/VALUE PAIRS */

            // TODO: Declare an empty dictionary, add key/value pairs, and print the map

            // Create a dictionary, elfAges, that can hold String keys and Integer values
            Dictionary<string, int> elfAges = []; // or, new Dictionary<string, int>()

            // Add 4 key/value pairs to it representing the elves and their ages
            elfAges.Add("Legolas", 2931);
            elfAges.Add("Arwen", 2901);
            elfAges.Add("Elrond", 6497);
            elfAges.Add("Galadriel", 8382);

            // Print Legolas' age
            Console.WriteLine("Legolas is " + elfAges["Legolas"] + " years old.");

            /* DICTIONARY METHODS */

            // TODO: Practice using different methods of the Dictionary class

            // Print the count
            Console.WriteLine(elfAges.Count);

            // Print just the keys
            Console.WriteLine(string.Join(", ", elfAges.Keys));

            // Print just the values
            Console.WriteLine(string.Join(", ", elfAges.Values));

            // Check if it contains a certain key and print result
            Console.WriteLine(elfAges.ContainsKey("Arwen"));

            // Check if it contains a certain value and print result
            Console.WriteLine(elfAges.ContainsValue(5000));
        }
    }
}
