namespace Program_10
{
    class Program
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.Write("Enter number1 : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number2 : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Maths maths = new Maths(number1, number2);
            maths.Addition();
            maths.Subtraction();
            maths.Multiplication();
            maths.Division();
            Console.ReadKey();
        }
    }
}