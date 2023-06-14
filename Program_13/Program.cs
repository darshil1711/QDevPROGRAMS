namespace Program_13
{
    class Program
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        ///  encapsulation.
        public static void Main(string[] args)
        {
            Student student = new Student();
            student.StudentName = "Darshil";
            student.StudentID = 1;
            student.StudentAge = 21;
            Console.WriteLine("Student ID : " + student.StudentID);
            Console.WriteLine("Student Name : " + student.StudentName);
            Console.WriteLine("Student Age : " + student.StudentAge);

            Console.ReadKey();
        }
    }
}