using System;
using System.Collections.Generic;
using System.Text;

/*
 * Class: Cube.cs
 * Author: Piper Sicard 000824338
 * Date: October 6th, 2021
 * 
 * Purpose: This class contains the constructor and methods for the creation of a cube.
 * Inherits the Square class.
 * 
 * I, Piper Sicard, 000824338 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
*/
namespace Lab2A
{
    public class Cube : Square
    {
        private double Length;

        /// <summary>
        /// Constructor for the Cube object
        /// </summary>
        /// <param name="length"></param>
        public Cube(double length) : base(length)
        {
            Length = length;
        }

        /// <summary>
        /// Calculates the area of the cube
        /// </summary>
        /// <returns>area</returns>
        public override double CalculateArea()
        {
            double area = 6 * (Math.Pow(Length, 2));
            return area;
        }


        /// <summary>
        /// Calculates the volume for the cube
        /// </summary>
        /// <returns>volume</returns>
        public override double CalculateVolume()
        {
            double volume = Math.Pow(Length, 3);
            return volume;
        }

        /// <summary>
        /// Sets the data for the cube
        /// </summary>
        public override void SetData()
        {
            Console.WriteLine("Enter The Side Length As a Double: ");
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
        /// Overrides the tostring for the cubes table output
        /// </summary>
        /// <returns>cube string</returns>
        public override string ToString()
        {
            return "| Cube        | " + Length + " | " + Length + " | " + Length + " |";
        }
    }
}
