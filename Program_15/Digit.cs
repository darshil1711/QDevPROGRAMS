namespace Program_15
{
    class Digit : Number
    {
        /// <summary>Additionals the specified a.</summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        public override void Additional(int a, int b)       // Runtime Polymorphism
        {
            int c = a + b;
            Console.WriteLine("Additional " + a + " + " + b + " = " + c);
        }
    }
}
