using System;
using System.Collections.Generic;
using System.Text;

/*
 * Class: Square.cs
 * Author: Piper Sicard 000824338
 * Date: October 6th, 2021
 * 
 * Purpose: This class contains the constructor and methods for the creation of a square.
 * Inherits the Shape class.
 * 
 * I, Piper Sicard, 000824338 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
*/
namespace Lab2A
{
    public class Square : Shape
    {
        private double Length;

        /// <summary>
        /// Constructor for the Square object.
        /// </summary>
        /// <param name="length"></param>
        public Square(double length)
        {
            Length = length;
        }

        /// <summary>
        /// Calculates the area of the Square
        /// </summary>
        /// <returns>area</returns>
        public override double CalculateArea()
        {
            double area = Length * 2;
            return area;
        }

        /// <summary>
        /// Calculates the volume
        /// </summary>
        /// <returns>0</returns>
        public override double CalculateVolume()
        {
            return 0;
        }

        /// <summary>
        /// Sets the data of the square object.
        /// </summary>
        public override void SetData()
        {
            Console.WriteLine("Enter Length As a Double: ");
            try
            {
                Length = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Character Entered Is Not A Double.");
            }
        }

        /// <summary>
        /// Overrides the toString to format it for the square output.
        /// </summary>
        /// <returns>Square string</returns>
        public override string ToString()
        {
            return "| Square      | " + Length + " | " + Length + " | " + 0 + " |";
        }
    }
}
