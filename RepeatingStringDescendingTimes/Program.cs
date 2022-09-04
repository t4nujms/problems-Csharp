namespace RepeatingStringDescendingTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to repeat: ");
            string? str = Console.ReadLine();

            Console.Write("Enter the number of times to repeat the string: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            for (int i = n; i > 0; i--)
            {
                string display = string.Empty;
                for (int j = 0; j < i; j++)
                {
                    display = display + str;
                }

                Console.WriteLine(display);
            }
        }
    }
}