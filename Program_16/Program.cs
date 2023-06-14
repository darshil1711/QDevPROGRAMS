namespace Program_16
{ 
    //interface
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

            IMethod5 method5 = new IMethod5();
            method5.Addition(number1, number2);
            method5.Subtraction(number1,number2);
            method5.Multiplication(number1,number2);
            method5.Division(number1,number2);
        }
    }
}