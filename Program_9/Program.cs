namespace Program_9
{
    public class Program
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            string str1 = "C# QDev Programs";
            string str2 = "Programs";

            Console.WriteLine("\nstring : " + str1);

            int length = str1.Length;
            Console.WriteLine("\nLength : " + length); //length method

            string joined = string.Concat(str1, str2);
            Console.WriteLine("\nJoined String : " + joined); //concat method

            bool equal = string.Equals(str1, str2);  //equals method
            Console.WriteLine("\n"+equal);

            string upper = str2.ToUpper(); //ToUpper method
            Console.WriteLine("\nConvert string in Upper : " + upper);

            string lower = str1.ToLower(); //ToLower method
            Console.WriteLine("\nConvert string in Lower : " + lower);

            string remove = str1.Remove(5); //remove method
            Console.WriteLine("\nRemove Character After 5th Character : " + remove);

            string messege = string.Format("\n{0}{1}", str1, str2); //format method
            Console.WriteLine(messege);

            Console.ReadKey();

        }
    }
}