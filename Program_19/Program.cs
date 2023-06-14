namespace Program_19
{
     public class Program
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        /// add string values.
        /// values with comma separated.
        static void Main(string[] args)
        {
            List<string> nameList = new List<string>();
            nameList.Add("Darshil");
            nameList.Add("Patel");
            nameList.Add("(DP)");

            Console.WriteLine(string.Join(",",nameList));
            Console.ReadLine();
        }
    }
}