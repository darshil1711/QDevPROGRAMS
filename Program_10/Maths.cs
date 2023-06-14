namespace Program_10
{
    public class Maths
    {
        public int number1;
        public int number2;

        /// <summary>Initializes a new instance of the <see cref="Maths" /> class.</summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// this keyword use.
        public Maths(int number1, int number2)
        {
            this.number1 = number1;
            this.number1 = number1;
            this.number2 = number2;
        }

        public void Addition()
        {
            var result = number1 + number2;
            Console.WriteLine("\nAddition " + number1 + " + " + number2 + " = " + result);
        }

        public void Subtraction()
        {
            var result = (number1 - number2);
            Console.WriteLine("Subtraction " + number1 + " - " + number2 + " = " + result);
        }

        public void Multiplication()
        {
            var result = (number1 * number2);
            Console.WriteLine("Subtraction " + number1 + " * " + number2 + " = " + result);
        }
        public void Division()
        {
            var result = (number1 / number2);
            Console.WriteLine("Division " + number1 + " / " + number2 + " = " + result);
        }
    }

}
