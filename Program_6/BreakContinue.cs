namespace Program_6
{
    public class BreakContinue
    {
        /// <summary>Initializes a new instance of the <see cref="BreakContinue" /> class.</summary>
        /// break and continue use.
        public BreakContinue()
        {
            Console.Write("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (i == 7)
                {
                    break;
                }

                Console.WriteLine(i);
            }

            Console.WriteLine("-----------------------");
            for (int i = 1; i <= number; i++)
            {
                if (i == 7)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
