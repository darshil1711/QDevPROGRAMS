namespace Program_11
{
    public class PersonDetails
    {
        /// <summary>The first name</summary>
        /// <summary>The last name</summary>
        /// <summary>Person1s this instance.</summary>
        /// static keyword use.
        
        public static string firstName;
        public static string lastName;

        public static void Person1()
        {
            firstName = "Darshil";
            lastName = "Patel";
            Console.WriteLine(firstName + lastName);
        }

        /// <summary>Person2s this instance.</summary>
        public static void Person2()
        {
            firstName = "Keval";
            lastName = "Vasoya";
            Console.WriteLine(firstName + lastName);
        }

        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            PersonDetails personDetails = new PersonDetails();
            PersonDetails.Person1();
            PersonDetails.Person2();
            Console.ReadKey();
        }
    }
}