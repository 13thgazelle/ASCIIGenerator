using System;
using System.Drawing;
using System.IO;

namespace ASCIIGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "ASCII Art Generator";
            Console.OutputEncoding = System.Text.Encoding.ASCII;

            DrawHeader("ASCII Art Generator");

            Console.WriteLine("Image path (leave empty for default):");
            Console.Write(">>> ");
            string imgLocation = Console.ReadLine();
            Console.WriteLine("ASCII Width (leave empty for 35):");
            Console.Write(">>>");
            int artWidth = 35;
            if(int.TryParse(Console.ReadLine(), out int newHeigth)){
                artWidth = newHeigth;
            }
            Console.WriteLine("Reverse Colors? (Y/n, leave empty for Yes):");
            Console.Write(">>> ");
            string reverseInput = Console.ReadLine()?.Trim().ToLower();
            bool reverse = true; 
            if (!string.IsNullOrEmpty(reverseInput))
            {
                reverse = reverseInput == "y";
            }

            if (string.IsNullOrWhiteSpace(imgLocation))
            {
                Console.WriteLine("[INFO] Using default image.");
                imgLocation = @"C:\Users\amirm\Desktop\img.jpg";
            }

            if (!File.Exists(imgLocation))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[ERROR] File not found. Please check the path.");
                Console.ResetColor();
                return;
            }

            Console.WriteLine("\n[INFO] Generating ASCII art...\n");

            var generator = new Generator();
            string asciiArt = generator.Generate(imgLocation, artWidth, reverse);

            Console.Clear();
            DrawHeader("ASCII Art Output");

            Console.WriteLine(asciiArt);

            string fileName = Path.GetFileNameWithoutExtension(imgLocation) + ".txt";
            string projectRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
            string outputFolder = Path.Combine(projectRoot, "Generated");
            string outputPath = Path.Combine(outputFolder, fileName);

            Directory.CreateDirectory(outputFolder);
            File.WriteAllText(outputPath, asciiArt);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[SAVED] Output written to:");
            Console.WriteLine("         " + outputPath);
            Console.ResetColor();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(true);
        }

        private static void DrawHeader(string title)
        {
            string line = new string('=', title.Length + 4);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(line);
            Console.WriteLine($"| {title.ToUpper()} |");
            Console.WriteLine(line);
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
