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

            //get the something that user press 
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            //get the something that user press 
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

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

//ctrl+k+d --> automatic indent
// for declaration of variable use first letter in lowercase and another word starting with uppercase
// can declare many variables in the same line or can use more than one line for each variable
