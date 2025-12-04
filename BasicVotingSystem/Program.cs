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
			// Voters Info
			string voterFirstName;
			string voterLastName;
			int voterGrade;

            // Positions

			// Messages / TUI
			string forThePosition="|	Vote for position of ";
			string tuiSpace="| 							       |";
			string tuiUnderline=" ______________________________________________________________ ";
            string tuiUnderlinev2=" ____________________________________________________________ ";
			string tuiUnderline_dashed=" -------------------------------------------------------------- ";
            string tuiTopLine=$"\n{tuiUnderline}\n{tuiSpace}";
            string tuiBottomLine=$"{tuiSpace}\n|{tuiUnderlinev2}|\n";
			string voteChoice="  Your Vote: ";

            // Welcome the 'User or Voter' when using this program!!
			Console.WriteLine("                _                _     ___  _						");
			Console.WriteLine("       ()      | |              | |   / (_)| |					    ");
			Console.WriteLine("       /\\  __  | |     __   __  | |   \\__  | |  _   __ _|_		    ");
			Console.WriteLine("      /  \\/    |/ \\   /  \\_/  \\_|/    /    |/  |/  /    |		");
			Console.WriteLine("     /(__/\\___/|  |_\\/\\__/ \\__/ |__/  \\___/|__/|__/\\___/|_/	");
            Console.WriteLine("\n    A voting system made in C#, which focuses on managing the      ");
            Console.WriteLine("               votes happening inside the school.\n");

            // Ask you the user to pick an option to vote or manage the votes
            Console.WriteLine(" ===================== Select an option: ======================\n");
            Console.WriteLine("          1. Vote     2. Instructions     3. Exit              \n");

            Console.Write("  Your selection: ");
            int option=Convert.ToInt32(Console.ReadLine());


            // Identify the options then its statement
			if (option == 2 ) {
			Console.WriteLine("+====================== Instructions: ======================+\n");
			} else if (option == 3) {
				Console.WriteLine("\nPress any key to exit...");
				Console.ReadKey();
			} else if (option == 1) {
                // Proceed to vote
				Console.WriteLine(tuiTopLine);
        	    Console.WriteLine("|   Before you start to vote, fill the following details!!     |");
                Console.WriteLine(tuiBottomLine);
        	    Console.Write("	First Name		: ");
				voterFirstName=Console.ReadLine();
        	    Console.Write("	Last Name		: ");
				voterLastName=Console.ReadLine();
        	    Console.Write("	Grade			: ");
                voterGrade=Convert.ToInt32(Console.ReadLine());

				// Verify voter, if allowed then proceed
				if ( voterGrade >= 4 ) {
					Console.WriteLine("\n\n  You may now proceed to vote!!\n");

					// Class President
                    Console.WriteLine(tuiTopLine);
					Console.WriteLine(forThePosition + "`President`"+ "!!");
					Console.WriteLine(tuiBottomLine);
					Console.Write(voteChoice);
					int president=Convert.ToInt32(Console.ReadLine());
				}
				else {
					Console.WriteLine("Only ");
				}
			} else {
				Console.WriteLine("Invalid option!!");
			}
/*1. Class President
Janelle Cruz
Jude Ramirez
Sofia Dizon

2. Vice President
Marco Lopez
Kyla Vergara
Tristan Abadilla

3. Secretary
Hannah Bautista
Miguel Sarmiento
Andrei Ong

4. Assistant Secretary
Lance Villanueva
Erika Santos
Nicole Javier

5. Treasurer
Justin Mendoza
Carla Fajardo
Rhea Salvador

6. Assistant Treasurer
Jerome Tan
Lea Cortez
Bianca Ramos

7. Auditor
Daniel Uy
Jasmine Flores
Nathan Robles

8. Public Information Officer (PIO)
Chloe Marquez
Ranier  Navarro
Bea Catalan
Ryan Torres

9. Peace Officer / Sergeant-at-Arms
Mark Delos Reyes
Faith Santiago
Leo Arcilla
Shaira Manalo

10. BOD – 12 names
 Adrian Lim
Kristine Barrios
Paolo Hernandez
Lianne Cruzado
Victor Manapat
Jasmine Reyes
Carl Buenaventura
Mia Tan
Seth Villoria
Andrea Palomares
Joshua Alcantara
Claire Santos

11.Muse
Angelique Perez
Mary Grace Torres
Kathryn Dela Peña

12. Escort
John Carlo Medina
Francis Paul Reyes
Noel Fernando*/
        }
    }
}
