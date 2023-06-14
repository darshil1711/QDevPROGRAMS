namespace Program_17
{
    public class Program
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <exception cref="System.IndexOutOfRangeException">Index is out of range.</exception>
        public static void Main()
        {
            try
            {
                int[] numbers = { 1, 2, 3 };
                int index = 2;

                if (index >= numbers.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }

                int value = numbers[index];
                Console.WriteLine("Value at index " + index + ": " + value);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeException caught: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }

            Console.WriteLine("Program execution continues...");
        }
    }
}