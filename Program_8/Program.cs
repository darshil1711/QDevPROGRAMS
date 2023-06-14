namespace Program_8
{
    class Program
    {
        /// <summary>Defines the entry point of the application.</summary>
        public static void Main()
        {
            float principal, rate, time;
            Console.Write("Enter Principal Amout:");
            principal = float.Parse(Console.ReadLine());
            
            Console.Write("Enter Interest:");
            rate = float.Parse(Console.ReadLine());
            
            Console.Write("Enter Payment Time Period(Months):");
            time = float.Parse(Console.ReadLine());

            Emi emi = new Emi();
            emi.EmiCalculator(principal, rate, time);
        }
    }
}