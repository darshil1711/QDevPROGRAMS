namespace Program_15
{
    public class Number
    {
        /// <summary>Additionals the specified a.</summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        public virtual void Additional(int a, int b)              // Runtime Polymorphism derived Class method
        {
            int c = a + b;
            Console.WriteLine("Additional " + a + " + " + b + " = " + c);
        }

        public void Additional(int a, int b, int c)          // Compile time Polymorphism for same class method
        {
            int d = a + b + c;
            Console.WriteLine("Additional " + a + " + " + b + " + " + c + " = " + d);
        }

        public void Additional(double a, double b, double c)        // Compile time Polymorphism
        {
            double d = a + b + c;
            Console.WriteLine("Additional " + a + " + " + b + " + " + c + " = " + d);
        }
    }
}
