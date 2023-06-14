namespace Program_2
{
    public class Age
    {
        /// <summary>Initializes a new instance of the <see cref="Age" /> class.</summary>
        /// Constructor
        /// if / else if statements.
        public Age()
        {
            Console.Write("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());


            if (age <= 0)
            {
                Console.WriteLine("You enter wrong number");
            }
            else if (age <= 1)
            {
                Console.WriteLine("Your age called Infant.");
            }
            else if (age <= 4)
            {
                Console.WriteLine("Your age called Toddler.");
            }
            else if (age <= 12)
            {
                Console.WriteLine("Your age called Child. ");
            }
            else if (age <= 17)
            {
                Console.WriteLine("Your age called Teen");
            }
            else if (age <= 59)
            {
                Console.WriteLine("Your age called Adult. ");
            }
            else if (age <= 60)
            {
                Console.WriteLine("Your age called Senior Adult.");
            }
        }
    }

}
