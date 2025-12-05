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
			string forThePosition="Vote for position of ";
			string tuiSpace="|                                                              |";
			string tuiUnderline=" ______________________________________________________________ ";
            string tuiUnderlinev2="______________________________________________________________";
            string tuiTopLine=$"\n{tuiUnderline}\n{tuiSpace}";
            string tuiBottomLine=$"{tuiSpace}\n|{tuiUnderlinev2}|";
            string tuiBottomLinev2=$"{tuiBottomLine}\n";
			string voteChoice="     Enter candidate number: ";

            // Welcome the 'User or Voter' when using this program!!
			Console.WriteLine("                _                _     ___  _						");
			Console.WriteLine("       ()      | |              | |   / (_)| |					    ");
			Console.WriteLine("       /\\  __  | |     __   __  | |   \\__  | |  _   __ _|_		    ");
			Console.WriteLine("      /  \\/    |/ \\   /  \\_/  \\_|/    /    |/  |/  /    |		");
			Console.WriteLine("     /(__/\\___/|  |_\\/\\__/ \\__/ |__/  \\___/|__/|__/\\___/|_/	");
            Console.WriteLine("\n    A voting system made in C#, which focuses on managing the      ");
            Console.WriteLine("         `SPG` votes in Escalante Central Elementary School.       \n");

            // Ask you the user to pick an option to vote or manage the votes
            Console.WriteLine(" ===================== Select an option: ======================\n");
            Console.WriteLine("          1. Vote     2. Instructions     3. Exit              \n");

            Console.Write("  Your selection: ");
            int option=Convert.ToInt32(Console.ReadLine());


            // Identify the options then its statement
			if (option == 2 ) {
			Console.WriteLine(" +====================== Instructions: ======================+\n");
			} else if (option == 3) {
				Console.WriteLine("\nPress any key to exit...");
				Console.ReadKey();
			} else if (option == 1) {
                // Proceed to vote
				Console.WriteLine(tuiTopLine);
        	    Console.WriteLine("|   Before you start to vote, fill the following details!!     |");
                Console.WriteLine(tuiBottomLinev2);
        	    Console.Write("     First Name      : ");
				voterFirstName=Console.ReadLine();
        	    Console.Write("     Last Name       : ");
				voterLastName=Console.ReadLine();
        	    Console.Write("     Grade           : ");
                voterGrade=Convert.ToInt32(Console.ReadLine());

				// Verify voter, if allowed then proceed
				if ( voterGrade >= 4 ) {
                    Console.WriteLine("\n\n     Hello " + voterFirstName + " " + voterLastName + ", You can now proceed to vote!!");

					// Class President
                    Console.WriteLine(tuiTopLine);
					Console.WriteLine("|              " + forThePosition + "'President'"+ "                |");
					Console.WriteLine(tuiBottomLine);
                    Console.WriteLine(tuiSpace);
                    Console.WriteLine("|        1. Marco Lopez                                        |");
                    Console.WriteLine("|        2. Tristan Abadilla                                   |");
                    Console.WriteLine("|        3. Kyla Vergara                                       |");
                    Console.WriteLine(tuiBottomLinev2);
					Console.Write(voteChoice);
					int president=Convert.ToInt32(Console.ReadLine());

                    // Vice President
                    Console.WriteLine(tuiTopLine);
					Console.WriteLine("|           " + forThePosition + "'Vice President'"+ "              |");
					Console.WriteLine(tuiBottomLine);
                    Console.WriteLine(tuiSpace);
                    Console.WriteLine("|        1. Janelle                                            |");
                    Console.WriteLine("|        2. Cruz Jude                                          |");
                    Console.WriteLine("|        3. Ramirez Sofia Dizon                                |");
                    Console.WriteLine(tuiBottomLinev2);
					Console.Write(voteChoice);
					int vice_president=Convert.ToInt32(Console.ReadLine());

                    // Secretary
                    Console.WriteLine(tuiTopLine);
					Console.WriteLine("|              " + forThePosition + "'Secretary'"+ "                |");
					Console.WriteLine(tuiBottomLine);
                    Console.WriteLine(tuiSpace);
                    Console.WriteLine("|        1. Hannah Bautista                                    |");
                    Console.WriteLine("|        2. Miguel Sarmiento                                   |");
                    Console.WriteLine("|        3. Ramirez Sofia Dizon                                |");
                    Console.WriteLine(tuiBottomLinev2);
					Console.Write(voteChoice);
					int secretary=Convert.ToInt32(Console.ReadLine());
				}
				else {
					Console.WriteLine("Only ");
				}
			} else {
				Console.WriteLine("Invalid option!!");
			}
/*1. Class President


2. Vice President




3. Secretary


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
