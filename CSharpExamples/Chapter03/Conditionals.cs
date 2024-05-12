namespace Chapter03
{
    public class Conditionals
    {
        public static void RunExamples()
        {
            /* EQUALITY & LOGICAL OPERATORS */

            // TODO: Print several boolean expressions using different operators with the specified types

            // 6 is not equal to 3 + 4
            Console.WriteLine(6 != 3 + 4);

            // 8.146 is greater than or equal to 10
            Console.WriteLine(8.126 >= 10);

            // "Gandalf" is equal to "gandalf" if case-insensitive
            Console.WriteLine(Equals("Gandalf".ToLower(), "gandalf"));

            // 15 is greater than 10 AND is less than or equal to 20
            Console.WriteLine(15 > 10 && 15 <= 20);

            // "fellowship" contains the substring "boat" OR "ship"
            Console.WriteLine("fellowship".Contains("boat") || "fellowship".Contains("ship"));

            /* IF, ELSE-IF, AND ELSE */

            // TODO: Store information about a noble in a dictionary

            // Create a dictionary with string key and string value
            Dictionary<string, string> noble = [];

            // Prompt the user for a name
            Console.WriteLine("Please enter the name of a noble: ");
            string nobleName = Console.ReadLine();

            // Store the name in the dictionary
            noble.Add("name", nobleName);

            // Declare (but do not initialize) a string, title
            string title;

            // Construct a series of if/else-if/else blocks to initialize the title
            //   Eomer becomes King of Rohan
            //   Eowyn becomes Lady of Ithilien
            //   Aragorn becomes King of Gondor
            if (Equals(nobleName, "Eomer"))
            {
                title = "King of Rohan";
            }
            else if (Equals(nobleName, "Eowyn"))
            {
                title = "Lady of Ithilien";
            }
            else if (Equals(nobleName, "Aragorn"))
            {
                title = "King of Gondor";
            }
            else
            {
                Console.WriteLine("Sorry, I do not have information on that noble.");
                title = "unknown";
            }

            // Set the title into the dictionary
            noble.Add("title", title);

            // Print a sentence using the noble's name and title
            Console.WriteLine(noble["name"] + " is " + noble["title"]);

            /* SWITCH STATEMENTS */

            // TODO: Store information about a elf in a dictionary

            // Create a dictionary with string key and string value
            Dictionary<string, string> elf = [];

            // Prompt the user for a name
            Console.WriteLine("Please enter the name of an elf: ");
            string elfName = Console.ReadLine();

            // Store the name in the dictionary
            elf.Add("name", elfName);

            // Declare (but do not initialize) a string, realm
            string realm;

            // Construct a switch statement to initialize the realm
            //   Legolas is from the Woodland Realm
            //   Elrond is from Rivendell
            //   Galadriel is from Lothlórien
            switch (elfName)
            {
                case "Legolas":
                    realm = "the Woodland Realm";
                    break;
                case "Elrond":
                    realm = "Rivendell";
                    break;
                case "Galadriel":
                    realm = "Lothlórien";
                    break;
                default:
                    Console.WriteLine("Sorry, I don't have information on that elf.");
                    realm = "unknown";
                    break;
            }

            // Set the realm into the dictionary
            elf.Add("realm", realm);

            // Print a sentence using the elf's name and realm
            Console.WriteLine(elf["name"] + " is from " + elf["realm"]);
        }
    }
}
