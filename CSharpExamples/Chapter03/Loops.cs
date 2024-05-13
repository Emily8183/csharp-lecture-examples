using System.Text;

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

            // Construct a basic for loop to print each battle
            for (int i = 0; i < battles.Length; i++)
            {
                Console.WriteLine(battles[i]);
            }

            /* FOREACH LOOP */

            string[] words = ["YOU", "SHALL", "NOT", "PASS"];

            // Construct a foreach loop to print each element of the array above
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

            // Construct three for-each loops for the dictionary above

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

            /* FOREACH LOOP WITH STRINGBUILDER */

            // Use the StringBuilder class for the accumulator pattern with strings

            string[] frodoLetters = ["f", "r", "o", "d", "o"];

            // Declare new Stringbuilder object
            StringBuilder frodo = new StringBuilder(); // or just new()

            // Loop over and add to it a letter at a time - make it uppercase
            foreach (string letter in frodoLetters)
            {
                frodo.Append(letter.ToUpper());
            }

            // Print the final result
            Console.WriteLine(frodo);

            /* WHILE LOOP */

            int[] orcs = [2, 14, 33, 57, 61, 89, 94, 106, 123, 176];

            // Construct a while loop to print each number in the Array above as long as the value is below 100

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

            // Construct a do-while loop to ask the user for book titles until they enter "QUIT"
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

            // Loop through the key/value pairs using while(true)
            // If a character is a member of the fellowship, put them in a list
            // If a character is not a member, continue without checking count
            // Break the loop when all 9 members have been found
            // If a character was found but fellowship is still not at 9, print a statement
            List<string> fellowship = [];

            foreach (KeyValuePair<string, bool> lotrChar in lotrCharacters)
            {
                if (lotrChar.Value)
                {
                    fellowship.Add(lotrChar.Key);
                    Console.WriteLine(lotrChar.Key + " added to the fellowship.");
                }
                else
                {
                    Console.WriteLine(
                        "(" + lotrChar.Key + " is not a member of the fellowship.)\n"
                    );
                    continue; // will skip remaining code of loop body but continue looping
                }

                if (fellowship.Count == 9)
                {
                    Console.WriteLine("All members have been found!");
                    break; // stops loop altogether
                }
                Console.WriteLine("Still searching for more fellowship members...\n");
            }

            // Print the list of fellowship members
            Console.WriteLine("\nThe Fellowship of the Ring:");
            Console.WriteLine(string.Join(", ", fellowship));
        }
    }
}
