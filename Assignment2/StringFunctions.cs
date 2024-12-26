using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class StringFunctions
    {

        /// <summary>
        /// Start the program function that running other functions until the users answer to run the program again is negative
        /// </summary>
        public void Start()
        {
            bool runAgain = false;
            do
            {
                string text = StringLength();
                DisplayStringLengthInfo(text);
                PredictMyDay();

                runAgain = RunAgain();
            }
            while (runAgain);

        }

        /// <summary>
        /// Function for input of the text/string by user
        /// </summary>
        /// <returns></returns>

        private string StringLength()
        {
            Console.WriteLine("");
            Console.WriteLine("Hello, let's check the length of your text");
            Console.WriteLine("");
            Console.Write("Type In Your Text Here: ");
            string text = Console.ReadLine();
            int length = text.Length;

            Console.WriteLine($"Amount of characters: {length}");
            Console.WriteLine($"Text: {text.ToUpper()}");
            return text;
        }


        /// <summary>
        /// Function for printing out the lenght of the text/string typed in by user
        /// </summary>
        /// <param name="text"></param>
        private void DisplayStringLengthInfo(string text)
        {
            Console.WriteLine("\n ---- STRENGTH LENGTH ---- ");

            int length = text.Length;

            Console.WriteLine();
            Console.WriteLine(text.ToUpper());

            Console.WriteLine("Amount of characters = " + length.ToString());
            Console.WriteLine();
        }

        /// <summary>
        /// Function for prediction of the day by typing in a number
        /// </summary>
        private void PredictMyDay()
        {
            Console.WriteLine();
            Console.WriteLine(" ************ The Fortune Teller *************");
            Console.Write(" Let me predict your day. Enter a number from 1 to 7: ");
            int day = 0;

            while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 7)
            {
                Console.WriteLine("Invalid Option, Choose Between 1 and 7.");  
            }

            
            string comment = day switch
            {
                1 => "Keep calm on Mondays! You can fall apart!",
                2 or 3 => "Tuesdays and Wednesdays break your heart!",
                4 => "Thursday is your lucky day, don't wait for Friday!",
                5 => "Friday, you are in love!",
                6 => "Saturday, do nothing and do plenty of it!",
                7 => "And Sunday always comes too soon!",
                _ => "No day? A good day but it doesn't exist!" 
            };

            Console.WriteLine();
            Console.WriteLine(comment);
            Console.WriteLine();
        }

        /// <summary>
        /// Function is asking user if the program should run again
        /// </summary>
        private bool RunAgain()
        {
            bool again = false;
            Console.Write("Want to try again? (y/n): ");
            string response = Console.ReadLine().ToLower();

            if (response == "y" || response == "yes")
            {
                again = true; 
            }
            else
            {
                again = false; 
            }
            return again; 
        }
    }
}
