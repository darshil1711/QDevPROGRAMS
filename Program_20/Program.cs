namespace Program_20
{
    public class Program
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        /// add dictionary as string in key value pair.
        static void Main(string[] args)
        {
            Dictionary<string, string> details = new Dictionary<string, string>();
            details.Add("Student Name", "Darshil Patel");
            details.Add("Student Education", "BCA");
            details.Add("Student Location", "Ahmedabad");

            foreach (var pair in details)
            {
                string keyValueString = string.Format("{0} = {1}",pair.Key, pair.Value);
                Console.WriteLine(keyValueString);
            }

            Console.ReadKey();
        }
    }
}