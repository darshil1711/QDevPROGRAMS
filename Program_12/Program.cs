using Program_12;

namespace Program_12
{
    class Program
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            StudentName studentName = new StudentName();
            studentName.StudentID();
            studentName.StudentDetails();
            Console.ReadKey();
        }
    }
}