using ConsoleAppProject.App04;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Tayyib Fazal 17/02/2022
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2021-2022! ");
            Console.WriteLine("        by Tayyib Fazal                           ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("             Choose which App to run:             ");
            Console.WriteLine("             Distance Converter - 1.              ");
            Console.WriteLine("               BMI Calculator   - 2.              ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();
        }
        
    }
}
