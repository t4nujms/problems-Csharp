namespace RepeatingStringDecreasingTimes
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
            Console.WriteLine("Output using string addition and for-loop: ");
            for (int i = n; i > 0; i--)
            {
                var repeat = new RepeatingString.RepeatingString(str, i);

                Console.WriteLine(repeat.Display1());
            }

            Console.WriteLine();
            Console.WriteLine("Output using StringBuilder and for-loop: ");
            for (int i = n; i > 0; i--)
            {
                var repeat = new RepeatingString.RepeatingString(str, i);

                Console.WriteLine(repeat.Display2());
            }

            Console.WriteLine();
            Console.WriteLine("Output using StringBuilder only: ");
            for (int i = n; i > 0; i--)
            {
                var repeat = new RepeatingString.RepeatingString(str, i);

                Console.WriteLine(repeat.Display3());
            }

        }
    }
}