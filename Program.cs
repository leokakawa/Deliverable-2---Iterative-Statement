/*
 Author: Leonardo Constante 
 Date: 09/12/2019
 Comments: This code is reference to Deliverable 2 - Iterative Statement
*/
using System;

namespace Deliverable_2___Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)

        {

                    // Use Try Catch Statement
                    try
            {
                    // Ask for user input
                    Console.Write(" Please enter a number between 1 and 100: ");


                    // Parse input 
                    int number = int.Parse(Console.ReadLine());

                    // If statement forinput is between 1 and 100
                    if (number > 0 && number <= 100)
                {
                    // Use loopnum  the while loop while keeping number intact
                    int loopNum = number;

                    // While loop that will loop through what the user has input. While loop will loop untill loopNum reaches 0
                    while (loopNum > 0)
                    {
                        // writeline to display output
                        Console.WriteLine("You have entered: " + number + " This is the current integer value in the loop: " + loopNum);
                        // decrease loopNet down by one to prevent infinite loop
                        loopNum--;
                    }
                }
                else
                {
                    // If user uses a number greater than 100 or less than 1 this message will be shown:
                    Console.WriteLine("**Enter a number between 1 and 100**");
                }

            }
            // catch statement if any errors occurs
            catch (Exception ex)
            {
                // Error message
                Console.WriteLine(ex.Message);
            }
        }
    }
}