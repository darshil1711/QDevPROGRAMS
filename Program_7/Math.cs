namespace Program_7
{
    public class Math
    {

        /// <summary>Initializes a new instance of the <see cref="Math" /> class.</summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// Parameterized constructor
        public Math(int number1, int number2)
        {
            int addition = number1 + number2;
            Console.WriteLine("\nAddition : " + number1 + " + " + number2 + " = " + addition);
            int subtraction = number2 - number1;
            Console.WriteLine("Subtraction : " + number1 + " - " + number2 + " = " + subtraction);
            int multiplication = number1 * number2;
            Console.WriteLine("Multiplication : " + number1 + " * " + number2 + " = " + multiplication);
            int division = number1 / number2;
            Console.WriteLine("Division : " + number1 + " / " + number2 + " = " + division);
        }

        /// <summary>Initializes a new instance of the <see cref="Math" /> class.</summary>
        /// Default constructor
        public Math()
        {
            Console.WriteLine("\nThis is Mathematics all Formula : ");
        }
    }
}
