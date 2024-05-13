namespace Chapter02
{
    public class Examples
    {
        // Static methods can be called directly on class
        
        public static void SayHello(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }

        public static int AddThreeNums(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
