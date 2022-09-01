namespace RepeatingString
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

            RepeatingString repeatingString = new RepeatingString(str, n);

            Console.WriteLine("Output using StringBuilder and for-loop: ");
            Console.WriteLine(repeatingString.Display1());
            Console.WriteLine();

            Console.WriteLine("Output using StringBuilder only: ");
            Console.WriteLine(repeatingString.Display2());
            Console.WriteLine();

        }
    }
}
