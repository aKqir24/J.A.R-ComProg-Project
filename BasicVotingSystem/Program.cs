// Ascii voter program art here:)
// Put the candidates here gian, eg. president,vice
// Assign these candidates into a variable for show
// Identify if they are a voter or a scrutineer <-- this can be done by him
// Display the candidates in a ascii table						^
// Calculate the votes each category and identify the winer -----|

using System;

namespace SchoolVote
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome the 'User or Voter' when using this program!!
            Console.WriteLine("                _                 _  _                       ");
            Console.WriteLine("       ()      | |               | |(_|   |_/                ");
            Console.WriteLine("       /\\  __  | |      __   __  | |  |   | __ _|_  _       ");
            Console.WriteLine("      /  \\/    |/ \\    /  \\_/  \\_|/   |   |/  \\_|  |/   ");
            Console.WriteLine("     /(__/\\___/|   |_\\/\\__/ \\__/ |__/  \\_/ \\__/ |_/|__/");
            Console.WriteLine("\nA voting system made in C#, which focuses on managing the votes");
            Console.WriteLine("               happening inside the school.\n");

            // Ask you the user to pick an option to vote or manage the votes
            Console.WriteLine("==================== Select an option: ======================\n");
            Console.WriteLine("         1. Vote     2. Admin Panel      3. Exit             \n");
            Console.Write("Your selection: ");
            int option=Convert.ToInt32(Console.ReadLine());

            // Identify the options then its statement
        }
    }
}
