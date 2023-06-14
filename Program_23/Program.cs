using System;
using System.IO;

class Program
{
    /// <summary>Defines the entry point of the application.</summary>
    /// <param name="args">The arguments.</param>
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Please enter the full path of the image file:");
            string imagePath = Console.ReadLine();

            Console.WriteLine("Please enter the destination folder path:");
            string destinationPath = Console.ReadLine();

            // Check if the source file exists
            if (!File.Exists(imagePath))
            {
                Console.WriteLine("The specified image file does not exist.");
                return;
            }

            // Create the destination directory if it doesn't exist
            if (!Directory.Exists(destinationPath))
            {
                Directory.CreateDirectory(destinationPath);
            }

            // Get the file name from the source path
            string fileName = Path.GetFileName(imagePath);

            // Construct the destination path
            string destinationFilePath = Path.Combine(destinationPath, fileName);

            // Copy the file to the destination path
            File.Copy(imagePath, destinationFilePath);

            Console.WriteLine("Image uploaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}