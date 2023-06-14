namespace Program_5
{
    class ForLoop
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        /// for loop use.
        static void Main(string[] args)
        {
            Console.Write("Enter Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            Console.Write("Enter Number:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            for (int p = 0; p <= number2; p++)
            {
                for (int q = 1; q <= number2 - p; q++)
                {
                    Console.Write(" ");
                }

                for (int r = 1; r <= 2 * p - 1; r++)
                {
                    Console.Write("* ");

                }

                Console.WriteLine();
              
            }
        }
    }
}