namespace Program_14
{
    public class IMethod9 : IMethod5, IMethod6, IMethod7, IMethod8
    {
        /// <summary>is the addtion.</summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        public void IAddtion(int number1, int number2)
        {
            Console.WriteLine("\nAddtional " + number1 + " + " + number2 + "= " + (number1 + number2));
        }
        /// <summary>is the subtraction.</summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        public void ISubtraction(int number1, int number2)
        {
            Console.WriteLine("Subtraction " + number1 + " - " + number2 + "= " + (number1 - number2));
        }
        /// <summary>is the multiplication.</summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        public void IMultiplication(int number1, int number2)
        {
            Console.WriteLine("Multiplication " + number1 + " * " + number2 + "= " + (number1 * number2));
        }
        /// <summary>is the division.</summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        public void IDivision(int number1, int number2)
        {
            Console.WriteLine("Division " + number1 + " / " + number2 + "= " + (number1 / number2));
        }
    }
}
