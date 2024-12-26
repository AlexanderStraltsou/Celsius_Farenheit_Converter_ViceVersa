namespace Assignment2
{
    internal class Program
    {

        /// <summary>
        /// Main method for running both programs. Second program is starting when user exiting the first one
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "Assignment 2 <By: Aliaksandr Straltsou>";
            Console.WriteLine("");
            StringFunctions stringFunctions = new StringFunctions();
            TemperatureConverter converter = new TemperatureConverter();
            converter.Start();
            stringFunctions.Start();
        }
    }
}



