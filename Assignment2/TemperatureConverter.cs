using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class TemperatureConverter
    {

        /// <summary>
        /// Function for starting the program and all other functions
        /// </summary>
        public void Start()
        {
            int choice;
     
            do
            {
                DisplayMenu();

                choice = Input.ReadIntegerConsole("Your Choice: ");


                switch (choice)
                {
                    case 1:
                        ConvertFahrenheitToCelsius();
                        break;
                    case 2:
                        ConvertCelsiusToFahrenheit();
                        break;
                    case 0:
                        Console.WriteLine("Exiting This Program and Starting Next Program");
                        break;
                    default:
                        Console.WriteLine("Invalid Option, Choose between 0 and 2");
                        break;
                }
            } while (choice != 0);
        }

        /// <summary>
        /// Function for printing out the menu
        /// </summary>
        private void DisplayMenu()
        {
            Console.WriteLine("\n--- Temperature Converter ---");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");
            Console.WriteLine("0. EXIT");
            Console.Write("Choose an option: ");
        }


        
        /// <summary>
        /// Function for Converting Farenheit to Celsius
        /// </summary>
        private void ConvertFahrenheitToCelsius()
        {
            Console.WriteLine("\nFahrenheit To Celsius:");
            Console.WriteLine("Fahrenheit\tCelsius");

            for (int f = 0; f <= 212; f += 10)
            {
                double celsius = (5.0 / 9.0) * (f - 32);
                Console.WriteLine($"{f,10} F \t{celsius:F1} C");
            }
        }

        /// <summary>
        /// Function for converting Celsius to Farenheit
        /// </summary>
        private void ConvertCelsiusToFahrenheit()
        {
            Console.WriteLine("\nCelsius to Fahrenheit:");
            Console.WriteLine("Celsius\tFahrenheit");

            for (int c = 0; c <= 100; c += 5)
            {
                double fahrenheit = (9.0 / 5.0) * c + 32;
                Console.WriteLine($"{c,7} C \t{fahrenheit:F1} F");
            }
        }
    }
}
