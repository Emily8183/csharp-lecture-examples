using System.Text;

namespace Chapter06
{
    public class Utils
    {
        // This uses the StringBuilder class for an accumulator pattern
        // It has to be converted to a string at the end to match the return type
        public static string GetInitials(string fullName)
        {
            StringBuilder initials = new();
            string[] names = fullName.Split(" ");
            foreach (string name in names)
            {
                initials.Append(name[0]);
            }
            return initials.ToString().ToUpper();
        }
    }
}
