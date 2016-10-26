using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber1
{
    class Program
    {
        static void Main(string[] args) //create entry point
        {
            string Continue; //create variable for restarting at the end
            Continue = "y"; //set variable
            while (Continue != "n") //do all this while Continue equals yes
            {
                    //declaring input variables
                    string LengthInput; //placeholder for user input
                    decimal Length; //numeric value of user input
                    string WidthInput; //placeholder for user input
                    decimal Width; //numeric value of user input

                    Console.WriteLine("Welcome!  Let's calculate the perimeter of the room."); //write greeting message to the console

                    Console.Write("Enter the length of the room (in feet): "); //prompt user for length
                    LengthInput = Console.ReadLine(); //get user input
                    Length = Convert.ToDecimal(LengthInput); //convert string to number

                    Console.Write("Enter the width of the room (in feet): "); //prompt user for width
                    WidthInput = Console.ReadLine(); //get user input
                    Width = Convert.ToDecimal(WidthInput); //convert string to number

                    Console.WriteLine(); //blank line
                    decimal Perimeter; //declare variable for perimeter
                    Perimeter = (Length + Width) * 2; //calculation for perimeter
                    Console.WriteLine("The perimeter of the room is: " + Perimeter + " feet."); //output the results
                    decimal Area = Length * Width; //calculation for area
                    Console.WriteLine("The area of the room is: " + Area + " cubic feet."); //output the results

                    Console.WriteLine(); //blank line
                    Console.Write("Continue? (y/n): "); //prompt user to continue or close
                    Continue = Console.ReadLine(); //get user input
                while (Continue != "y" && Continue != "n" && Continue != "N" && Continue != "Y") //validate user's entry
                {
                    Console.WriteLine("Invalid entry. Try again.");
                    Continue = Console.ReadLine();
                        }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine();

                }
                }              
            }
        }
    

   
