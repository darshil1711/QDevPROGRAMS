namespace Program_22
{
    public class Program
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            string path = @"D:\myTestFile.txt";
            try
            {
                using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    using (StreamWriter writer = new StreamWriter(fileStream))
                    {
                        writer.WriteLine("Name : Darshil Patel");
                        writer.WriteLine("Age : 21 year");
                        writer.WriteLine("Location : Ahmedabad");
                        writer.WriteLine("Occupation : Software Devloper");
                        Console.WriteLine("File Created and Data Add Successfully.");
                    }
                    using (StreamReader reader = File.OpenText(path))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
            }

            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found!");
                Console.WriteLine("Exception : " + ex.Message);
            }

        }
    }
}