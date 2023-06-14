namespace Program_21
{
    public class Program
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            List<string> myList = new List<string> { "A", "B", "C", "D", "A", "C", "E", "E", "E" };
            Console.WriteLine("Original List : ");

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            // remove duplicate values
            List<string> uniqueList = new List<string>(new HashSet<string>(myList));
            Console.WriteLine("\nList Without Duplicate :");

            foreach (var item in uniqueList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}