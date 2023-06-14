namespace Program_7
{
    class Program
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.Write("Enter Number 1 : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 2 : ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Math math1 = new Math();
            Math math2 = new Math(number1, number2);
            Console.ReadLine();
        }
    }
}