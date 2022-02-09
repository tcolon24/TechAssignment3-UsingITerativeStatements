/*
    Author: Tyler Colon
    Date: 2/8/2022
    Comments: This C# Conole Application code demonstrates using iterative statements after getting inputs from the user
*/

using System;

namespace TechAssignment3_UsingITerativeStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking the user to input CAD incremental value between 5 and 25
            Console.WriteLine("Enter an incremental CAD Integer value in between 0 and 200: ");
            
            try
            {
               //This variable will gather the data from the user
                string input = Console.ReadLine();
                // This variable will be used to perform the iterative statement and is parsed as an integer
                int CADvalue = int.Parse(input);
                double USDollars;

                //converting CAD value to US dOllars
                USDollars = (CADvalue * .0792367);
                //Using if statement to set paramters for values between 0 and 200
                if ((CADvalue > 0) && (CADvalue <= 200))
                    {
                    //Executing a for loop to compute/ print a table of values for the manager
                    Console.WriteLine("CAD increment value:" + CADvalue);
                   
                    //for loop iterative statement to produce CADvalues
                    for (int i = 0; i < CADvalue; i++ )
                        {
                        // It is statement showing the values of the CAD and USDOLLARS
                        Console.WriteLine("CAD:  " + i + "    USDollars: " + i*USDollars);
                        }

                    //if there is an input error telling the user to try again
                    Console.WriteLine("If error, make sure you are entering a integer value between 0 and 200");
                    Console.WriteLine("Press any key to exit the program");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                //After the catch if errors occur
                Console.WriteLine("Please enter an integer value and run it again");
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey(true);
            } //end of catch 
        } //End of main
    } //End of class
} //End of namespace 
