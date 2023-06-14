namespace Program_4
{
    public class Loop
    {
        /// <summary>Initializes a new instance of the <see cref="Loop" /> class.</summary>
        /// while or do/while loop use
        /// method are constructor
        public Loop()
        {
            Console.Write("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number < 100)
            {
                number++;
                Console.WriteLine(number);
            }

            Console.Write("Enter Number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            do
            {
                number1++;
                Console.WriteLine(number1);
            } while (number1 < 100);

        }
    }
}
