namespace Program_14
{
    public class Method3 : Method2   //Hierarchical Inheritance //Hybrid Inheritance

    {
        /// <summary>Multiplications the specified number1.</summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        public void Multiplication(int number1, int number2)
        {
            Console.WriteLine("Multiplication " + number1 + " * " + number2 + "= " + (number1 * number2));
        }
    }
}
