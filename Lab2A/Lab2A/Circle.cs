using System;
using System.Collections.Generic;
using System.Text;

/*
 * Class: Circle.cs
 * Author: Piper Sicard 000824338
 * Date: October 6th, 2021
 * 
 * Purpose: This class contains the constructor and methods for the creation of a circle.
 * Inherits the Shape class.
 * 
 * I, Piper Sicard, 000824338 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
*/
namespace Lab2A
{
    class Circle : Shape
    {
        private double Length;

        /// <summary>
        /// Constructor for the circle object
        /// </summary>
        /// <param name="length"></param>
        public Circle(double length)
        {
            Length = length;
        }

        /// <summary>
        /// Calculates the area of the circle
        /// </summary>
        /// <returns>area</returns>
        public override double CalculateArea()
        {
            double area = 3.141592653589793 * (Length / 2);
            return area;
        }

        /// <summary>
        /// Calculates volume
        /// </summary>
        /// <returns>0</returns>
        public override double CalculateVolume()
        {
            return 0;
        }

        /// <summary>
        /// Sets the data for the circle object
        /// </summary>
        public override void SetData()
        {
            Console.WriteLine("Enter Length of Diameter As a Double: ");
            try
            {
                Length = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Character Entered Is Not A Double.");
            }

            Circle circle = new Circle(Length);
        }

        /// <summary>
        /// overrides the toString for the circle table output
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "| Circle      | " + Length + " | " + Length + " | " + 0 + " |";
        }
    }
}
