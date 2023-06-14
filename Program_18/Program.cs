namespace Program_18
{
    public class Program
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Enter our List Element to Find the Number : ");
            int elementToFind = Convert.ToInt32(Console.ReadLine());

            //index of array element
            int index = Array.IndexOf(numbers, elementToFind);

            if (index != 1)
            {
                Console.WriteLine("Element {0} found at index {1}", elementToFind, index);
            }
            else
            {
                Console.WriteLine("Element {0} not found in the array ", elementToFind);
            }
            Console.ReadKey();
        }
    }
}