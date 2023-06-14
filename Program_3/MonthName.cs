namespace Program_3
{
    public class MonthName
    {
        /// <summary>Initializes a new instance of the <see cref="MonthName" /> class.</summary>
        /// switch case used
        /// method are constructor
        public MonthName()
        {
            Console.Write("Enter Month Number : ");
            int monthNumber = Convert.ToInt32(Console.ReadLine());

            switch (monthNumber)
            {
                case 1:
                    Console.WriteLine("January");
                    break;

                case 2:
                    Console.WriteLine("February");
                    break;

                case 3:
                    Console.WriteLine("March");
                    break;

                case 4:
                    Console.WriteLine("April");
                    break;

                case 5:
                    Console.WriteLine("May");
                    break;

                case 6:
                    Console.WriteLine("June");
                    break;

                case 7:
                    Console.WriteLine("July");
                    break;

                case 8:
                    Console.WriteLine("August");
                    break;

                case 9:
                    Console.WriteLine("September");
                    break;

                case 10:
                    Console.WriteLine("Octomber");
                    break;

                case 11:
                    Console.WriteLine("November");
                    break;

                case 12:
                    Console.WriteLine("December");
                    break;

                default:
                    Console.WriteLine("Invalid Month Number.");
                    break;
            }
        }
    }

}
