namespace Program_14
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

            Method3 method3 = new Method3();
            method3.Addtion(number1,number2);
            method3.Subtraction(number1,number2);
            method3.Multiplication(number1,number2);
            
            Method4 method4 = new Method4();
            method4.Division(number1,number2);

            IMethod9 method9 = new IMethod9();
            method9.IAddtion(number1,number2);
            method9.ISubtraction(number1,number2);
            method9.IMultiplication(number1,number2);
            method9.IDivision(number1,number2);
            Console.ReadKey();
        }
    }
}