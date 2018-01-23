using System;

// Name: GlazerCalc
// Author: Daniel Brazil
// Description:
// This class will get user input for the width and length desired for a window, in meters.
// It will then calculate and display to the console the total length of wood required,
// in feet, and surface area of glass needed in square meters.

/*
 * Another type of comment
 */

namespace GlazerCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaration of variables
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            //ask user about lenght of width
            Console.WriteLine("Please type width window:");
            //get the something that user press 
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            // Check to see if window is not too high.
            if (width < 5 || width > 10)
            {
                //tell the user that the width is incorrect
                Console.WriteLine("The width of your window cannot be greater than 10 OR" + Environment.NewLine +
                                  "The width of your window cannot be less than 5");
                //wait the user type ENTER to end program
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Good Job!!!! Continue.");
                //ask user about lenght of height
                Console.WriteLine("Please type height window:");
                //get the something that user press 
                heightString = Console.ReadLine();
                height = double.Parse(heightString);

                // Check to see if window is not too high.
                if (height < 5 || height > 10)
                {
                    //tell the user that the width is incorrect
                    Console.WriteLine("The height of your window cannot be greater than 10. OR" + Environment.NewLine +
                                      "The height of your window cannot be less than 5");
                    //wait the user type ENTER to end program
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Good Job!!!!");
                    //calculate the woodlength
                    woodLength = 2 * (width + height) * 3.25;
                    // multiply area * 2 to account for double panes
                    // of glass when calculating glass area
                    glassArea = 2 * (width * height);

                    //show to user the results
                    Console.WriteLine("The length of the wood is " + woodLength + " feet");
                    Console.WriteLine("The area of the glass is " + glassArea + " square metres");

                    //wait the user type ENTER to end program
                    Console.ReadLine();

                }

            }



        }
    }
}

//ctrl+k+d --> automatic indent
//shift + tab --> remove 1 indent
//tab --> 1 indent

// for declaration of variable use first letter in lowercase and another word starting with uppercase
// can declare many variables in the same line or can use more than one line for each variable
