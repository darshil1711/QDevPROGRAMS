namespace Program_16
{
    public class IMethod5 : IMethod1, IMethod2, IMethod3, IMethod4
    {
        /// <summary>Additions the specified number1.</summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        public void Addition(int number1, int number2)
        {
            Console.WriteLine("\nAddtional " + number1 + " + " + number2 + "= " + (number1 + number2));
        }
        /// <summary>Subtractions the specified number1.</summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        public void Subtraction(int number1, int number2)
        {
            Console.WriteLine("Subtraction " + number1 + " - " + number2 + "= " + (number1 - number2));
        }
        /// <summary>Multiplications the specified number1.</summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        public void Multiplication(int number1, int number2)
        {
            Console.WriteLine("Multiplication " + number1 + "  " + number2 + "= " + (number1 * number2));
        }
        /// <summary>Divisions the specified number1.</summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        public void Division(int number1, int number2)
        {
            Console.WriteLine("Division " + number1 + " / " + number2 + "= " + (number1 / number2));
        }
    }
}
