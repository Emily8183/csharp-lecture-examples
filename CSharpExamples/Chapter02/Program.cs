/**** CHAPTER 2 EXAMPLES ****/

// TODO: Make the Examples class available from the namespace
using Chapter02;


/* DECLARING AND INITIALIZING VARIABLES */

// TODO: Declare and initialize several variables
string unit = "Unit";
char unitNum = '2';
string currentUnit = unit + " " + unitNum;
bool unit1Finished = true;
string cohortMonth = "March";
int cohortYear = 2024;
float percentComplete1 = 100 * 7.0f / 16;
double areaOfCircle = Math.PI * 5 * 5;

// TODO: Print sentences to the console using the variables above
Console.WriteLine("We are currently in " + currentUnit);
Console.WriteLine("Unit 1 is " + (unit1Finished ? "finished" : "unfinished"));
Console.WriteLine("The " + cohortMonth + " " + cohortYear + " cohort is " + percentComplete1 + "% done.");
Console.WriteLine("The area of a circle of radius 5 is " + areaOfCircle);


/* GETTING USER INPUT */

// TODO: Get user input with Console.ReadLine()

// Precede your input with output to the user so they know what you need
Console.WriteLine("Please enter your first name: ");

// Receive the input and store it in a variable
string firstName = Console.ReadLine();

// Do something with the stored user input
Console.WriteLine("Hello, " + firstName + "!");

// TODO: Repeat the process
Console.WriteLine("Please enter your last name: ");
string lastName = Console.ReadLine();
string fullName = firstName + " " + lastName;
Console.WriteLine("Hello, " + fullName + "!");

// TODO: Get user input that needs to be converted to other data types

// int
Console.WriteLine("Welcome to Pizza Surprise. Please enter the number of pizzas you would like to order: ");
int numPizzas = int.Parse(Console.ReadLine());
Console.WriteLine("Thank you. We will surprise you with " + numPizzas + " pizzas with random toppings.");

// bool
Console.WriteLine("True or false: These surprise pizzas are delicious. ");
bool areDelicious = bool.Parse(Console.ReadLine());
Console.WriteLine("Your answer: " + (areDelicious ? "YES!" : "...not so much"));

// double
Console.WriteLine("On a scale of 0.1000000000 (truly terrible) to 10.0000000000 (absolutely amazing), how would you rate the Pizza Surprise concept overall?");
double rating = double.Parse(Console.ReadLine());
Console.WriteLine("Your rating: " + rating);


/* STRING METHODS */

string bizName = "Pizza Surprise";

// TODO: Print the length of the business name
Console.WriteLine(bizName.Length);

// TODO: Find the space and use its index to print just "Surprise"
int spaceIdx = bizName.IndexOf(' '); // char
Console.WriteLine(bizName.Substring(spaceIdx + 1));

// TODO: Print the result of checking if the word "pizza" is in the name (case-insensitive)
Console.WriteLine(bizName.ToLower().Contains("pizza"));


/* ARRAYS */

// A new array of size 8
string[] toppings = new string[8];

// TODO: Verify length of array
Console.WriteLine(toppings.Length);

// TODO: Add some toppings
toppings[0] = "pepperoni";
toppings[1] = "anchovies";
toppings[2] = "olives";
toppings[3] = "pineapple";

Console.WriteLine(toppings[5]); // null

// TODO: Try to print the array by name directly
Console.WriteLine(toppings); // prints type only

// TODO: Use the string method .Join() to print the contents of the array
Console.WriteLine(string.Join(", ", toppings));


/* INITIALIZING AN ARRAY WITH VALUES */

// Surprise pizzas!
string[] pizzas = {"anchovy and pineapple", "sauerkraut and tomato", "corn and carrot"};

// TODO: Print a sentence with the third type of pizza using bracket notation
Console.WriteLine("I tried a " + pizzas[2] + " pizza and it wasn't truly terrible.");

// TODO: Print the list of pizzas, one on each line, without looping
Console.WriteLine(string.Join("\n", pizzas));


/* WRITING METHODS */

// TODO: Code a method
static string GetFullName(string firstName, string lastName) {
    return firstName + " " + lastName;
}

// TODO: Call the method and store the result in a variable, then print it
// Take note of the data type of the return value
string johnSmith = GetFullName("John", "Smith");

Console.WriteLine(johnSmith);


/* USING METHODS FROM OTHER CLASSES */

// TODO: Create a new class, Examples, and define two methods

// TODO: Call each of the static methods from the Examples class
// Make sure to explicitly access the namespace at the top of the file

Examples.SayHello(johnSmith);

int sum = Examples.AddThreeNums(162, 58, 94);
Console.WriteLine(sum);
