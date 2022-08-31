using System.Text;

namespace RepeatingString
{
    internal class RepeatingString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to repeat: ");
            string? str = Console.ReadLine();

            Console.Write("Enter the number of times to repeat the string: ");
            int n = Convert.ToInt32(Console.ReadLine());

            StringBuilder display = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                display.Append(str);
            }

            Console.WriteLine(display.ToString());
        }
    }
}
