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
            Console.WriteLine("\n  A voting system made in C#, which focuses on managing the");
            Console.WriteLine("               votes happening inside the school.\n");

            // Ask you the user to pick an option to vote or manage the votes
            Console.WriteLine("==================== Select an option: ======================\n");
            Console.WriteLine("         1. Vote     2. Admin Panel      3. Exit             \n");
			                 
            Console.Write("Your selection: ");
            int option=Convert.ToInt32(Console.ReadLine());

            // Identify the options then its statement
            if (option == 1)
            {
                // This the vote option...
				Console.WriteLine("\n<----------------------------------------------------------->");
        	    Console.WriteLine("    Before you start to vote, fill the following details!!");
        	    Console.Write("	First Name		: ");
				string voterFirstName=Console.ReadLine();
        	    Console.Write("	Last Name		: ");
				string voterLastName=Console.ReadLine();
        	    Console.Write(" Age				: ");
				int voterAge=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("<----------------------------------------------------------->");

                // Class President
                Console.Write("Vote: ");
                int president=Convert.ToInt32(Console.ReadLine());
			}
                /*if (president == 1){

                } else if (president == 2){

                } else {

                }
            } elif (option == 2) {
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

