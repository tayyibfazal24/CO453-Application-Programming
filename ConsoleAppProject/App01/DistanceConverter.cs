using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Converts from a user selected unit of
    /// distance to another
    /// </summary>
    /// <author>
    /// Tayyib Fazal
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        
        public const double METRES_IN_MILES = 1609.34;
        
        public const double FEET_IN_METRES = 3.28084;

        private double fromDistance;
        private double toDistance;
        private string fromUnit;
        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }

        public const string FEET = "Feet";
        public const string METRES = "Metres";
        public const string MILES = "Miles";
//----------------------------------------------------------------------------------------------------//
        public void ConvertDistance()
        {
            fromUnit = SelectUnit("Please select the from distance unit: ");
            toUnit = SelectUnit("Please select the to distance unit: ");
            OutputHeading($"Converting {fromUnit} to {toUnit}");
            fromDistance = InputDistance($"Please enter the number of {fromUnit}: ");
            CalculateDistance();        
            OutputDistance();
        }

        private void CalculateDistance()
        {
            if(fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            else if (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            }
            else if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
        }

//----------------------------------------------------------------------------------------------------//

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);
            return ExecuteChoice(choice);
        }

        private static string ExecuteChoice(string choice)
        {
            
            if(choice.Equals("1"))
            {
                return FEET;
            }
            else if (choice.Equals("2"))
            {
                return METRES;
            }
            else if (choice.Equals("3"))
            {
                return MILES;
            }

            return null;
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");
            Console.WriteLine();

            Console.Write(prompt);
            string choice = Console.ReadLine();
            return choice;
        }
//----------------------------------------------------------------------------------------------------//
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }
        private void OutputDistance()
        {
            Console.WriteLine($" {fromDistance} {fromUnit}" +
            $" is {toDistance} {toUnit}");
        }

        private void OutputHeading(String prompt)
        {
            Console.WriteLine("\n----------------------------");
            Console.WriteLine("      Convert Distances       ");
            Console.WriteLine("       by Tayyib Fazal        ");
            Console.WriteLine("----------------------------\n");

            Console.WriteLine(prompt);
            Console.WriteLine("");
        }
    }
}