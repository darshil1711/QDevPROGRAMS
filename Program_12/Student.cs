namespace Program_12
{

    /// <summary>
    /// data abstraction.
    /// </summary>
    abstract class Student
    {
        /// <summary>Students the details.</summary>
        public abstract void StudentDetails();

        /// <summary>Students the identifier.</summary>
        public void StudentID()
        {
            Console.WriteLine("Student ID : 1");
        }
    }
}
