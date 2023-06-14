namespace Program_14
{
    public class Method1 : Maths  //Single Level Inheritance
    {
        /// <summary>Addtions the specified number1.</summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        public void Addtion(int number1, int number2)
        {
            Console.WriteLine("\nAddtional " + number1 + " + " + number2 + "= " + (number1 + number2));
        }
    }
}
