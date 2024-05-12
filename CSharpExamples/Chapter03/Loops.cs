namespace Chapter03
{
    public class Loops
    {
        public static void RunExamples()
        {
            Console.WriteLine("\nLOOPS\n");

            /* FOR LOOP */

            string[] battles =
            {
                "The Battle of Moria",
                "The Battle for Isengard",
                "The Battle of Helm's Deep",
                "The Battle of the Pelennor Fields",
                "The Battle of the Black Gate"
            };

            // TODO: Construct a basic for loop to print each battle
            for (int i = 0; i < battles.Length; i++)
            {
                Console.WriteLine(battles[i]);
            }

            /* FOREACH LOOP */

            string[] words = ["YOU", "SHALL", "NOT", "PASS"];

            // TODO: Construct a foreach loop to print each element of the array above
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

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
            foreach (string key in moria.Keys)
            {
                Console.WriteLine(key);
            }

            // Loop through values and print each
            foreach (string val in moria.Values)
            {
                Console.WriteLine(val);
            }

            // Loop through key/value pairs and print them
            foreach (KeyValuePair<string, string> kvp in moria)
            {
                Console.WriteLine("The " + kvp.Key + " of Moria is " + kvp.Value);
            }

            /* WHILE LOOP */

            int[] orcs = [2, 14, 33, 57, 61, 89, 94, 106, 123, 176];

            // TODO: Construct a while loop to print each number in the Array above as long as the value is below 100

            int index = 0;

            while (orcs[index] < 100)
            {
                Console.WriteLine(orcs[index]);
                index++;
            }

            /* DO-WHILE LOOP */

            List<string> bookTitles = [];

            string title;
            bool isQuitting = false;

            // TODO: Construct a do-while loop to ask the user for book titles until they enter "QUIT"
            // Unless quitting, add each title to the collection above
            do
            {
                Console.WriteLine("Please enter a book title, or hit ENTER to quit: ");
                title = Console.ReadLine();
                isQuitting = Equals(title.Trim(), "");
                if (!isQuitting)
                {
                    bookTitles.Add(title);
                }
            } while (!isQuitting);

            // Print all book titles in the list
            foreach (string book in bookTitles)
            {
                Console.WriteLine(book);
            }

            // TEMP NOTE TODO
            // break and continue keywords
            // StringBuilder class
        }
    }
}
