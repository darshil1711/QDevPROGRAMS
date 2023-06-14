namespace Program_14
{
    public class Method2 : Method1 //Multi-Level Inheritance
    {
        /// <summary>Subtractions the specified number1.</summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        public void Subtraction(int number1, int number2)
        {
            Console.WriteLine("Subtraction " + number1 + " - " + number2 + "= " + (number1 - number2));
        }
    }
}
