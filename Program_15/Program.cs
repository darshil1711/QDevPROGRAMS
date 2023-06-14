namespace Program_15
{
    class Program
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Number obj = new Number();
            obj.Additional(20,30);
            obj.Additional(40,50,60);
            obj.Additional(10.20,20.30,40.20);

            Digit digit = new Digit();
            obj.Additional(30,50);

            Console.ReadLine();

        }
    }
}