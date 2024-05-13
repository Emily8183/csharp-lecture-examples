namespace Chapter03
{
    public class Loops
    {
        public static void RunExamples()
        {
            Console.WriteLine("\nLOOPS\n");

            /* FOR LOOP */

            string[] battles =
            [
                "The Battle of Moria",
                "The Battle for Isengard",
                "The Battle of Helm's Deep",
                "The Battle of the Pelennor Fields",
                "The Battle of the Black Gate"
            ];

            // TODO: Construct a basic for loop to print each battle


            /* FOREACH LOOP */

            string[] words = ["YOU", "SHALL", "NOT", "PASS"];

            // TODO: Construct a foreach loop to print each element of the array above


            /* FOREACH LOOP WITH DICTIONARY */

            Dictionary<string, string> moria = []; // or, new Dictionary<string, string>()

            moria.Add("name", "the Mines of Moria");
            moria.Add("ancientName", "Khazad-dûm");
            moria.Add("location", "the Misty Mountains");
            moria.Add("founder", "Durin");
            moria.Add("king", "Balin");
            moria.Add("monster", "a balrog");

            // TODO: Construct three for-each loops for the dictionary above

            // Loop through keys and print each

            // Loop through values and print each

            // Loop through key/value pairs and print them


            /* FOREACH LOOP WITH STRINGBUILDER */

            // TODO: Use the StringBuilder class for the accumulator pattern with strings

            // Declare new Stringbuilder object

            // Loop over and add to it a letter at a time - make it uppercase


            // Print the final result


            /* WHILE LOOP */

            int[] orcs = [2, 14, 33, 57, 61, 89, 94, 106, 123, 176];

            // TODO: Construct a while loop to print each number in the Array above as long as the value is below 100


            /* DO-WHILE LOOP */

            List<string> bookTitles = [];

            // TODO: Construct a do-while loop to ask the user for book titles until they enter "QUIT"
            // Unless quitting, add each title to the collection above


            /* BREAK AND CONTINUE KEYWORDS WITH LOOPS */

            Dictionary<string, bool> lotrCharacters = new Dictionary<string, bool>
            {
                { "Bilbo Baggins", false },
                { "Frodo Baggins", true },
                { "Samwise (Sam) Gamgee", true },
                { "Gandalf the Grey", true },
                { "Peregrin (Pippin) Took", true },
                { "Meriadoc (Merry) Brandybuck", true },
                { "Aragorn", true },
                { "Arwen Evenstar", false },
                { "Elrond Halfelven", false },
                { "Boromir", true },
                { "Faramir", false },
                { "Galadriel", false },
                { "Legolas", true },
                { "Gimli", true },
                { "Gollum (Sméagol)", false },
                { "Sauron", false }
            };

            Console.WriteLine("\nGATHERING THE FELLOWSHIP\n");

            // TODO: Loop through the key/value pairs using while(true)
            // If a character is a member of the fellowship, put them in a list
            // If a character is not a member, continue without checking count
            // Break the loop when all 9 members have been found
            // If a character was found but fellowship is still not at 9, print a statement

            // Print the list of fellowship members
        }
    }
}
