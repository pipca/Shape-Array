using System;
using System.Collections.Generic;
using System.Text;

/*
 * Class: Sphere.cs
 * Author: Piper Sicard 000824338
 * Date: October 6th, 2021
 * 
 * Purpose: This class contains the constructor and methods for the creation of a sphere.
 * Inherits the Circle class.
 * 
 * I, Piper Sicard, 000824338 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
*/
namespace Lab2A
{
    class Sphere : Circle
    {
        private double Length;

        /// <summary>
        /// Constructor for the sphere object
        /// </summary>
        /// <param name="length"></param>
        public Sphere(double length) : base(length)
        {
            Length = length;
        }

        /// <summary>
        /// Calculates the area of the sphere
        /// </summary>
        /// <returns>area</returns>
        public override double CalculateArea()
        {
            double area = 4 * (3.141592653589793 * (Length / 2));
            return area;
        }

        /// <summary>
        /// Calculates the volume of the sphere
        /// </summary>
        /// <returns>volume</returns>
        public override double CalculateVolume()
        {
            double volume = (4 / 3) * 3.141592653589793 * Math.Pow((Length / 2), 3);
            return volume;
        }

        /// <summary>
        /// Sets the data for the sphere
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

            Sphere sphere = new Sphere(Length);
        }

        /// <summary>
        /// overrides toString for the sphere table output
        /// </summary>
        /// <returns>sphere string</returns>
        public override string ToString()
        {
            return "| Sphere      | " + Length + " | " + Length + " | " + Length + " |";
        }
    }
}
