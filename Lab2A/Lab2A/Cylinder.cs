using System;
using System.Collections.Generic;
using System.Text;

/*
 * Class: Cylinder.cs
 * Author: Piper Sicard 000824338
 * Date: October 6th, 2021
 * 
 * Purpose: This class contains the constructor and methods for the creation of a cylinder.
 * Inherits the Circle class.
 * 
 * I, Piper Sicard, 000824338 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
*/
namespace Lab2A
{
    class Cylinder : Circle
    {
        private double Length;
        private double Height;

        /// <summary>
        /// Constructor for the cylinder object
        /// </summary>
        /// <param name="length"></param>
        /// <param name="height"></param>
        public Cylinder(double length, double height) : base(length)
        {
            Length = length;
            Height = height;
        }

        /// <summary>
        /// Calculates the area of the cylinder
        /// </summary>
        /// <returns>area</returns>
        public override double CalculateArea()
        {
            double areaA = 2 * (3.141592653589793 * ((Length / 2) * Height));
            double areaB = 2 * (3.141592653589793 * Math.Pow((Length / 2), 2));
            double area = areaA + areaB;
            return area;
        }

        /// <summary>
        /// Calculates the volume of the cylinder
        /// </summary>
        /// <returns>volume</returns>
        public override double CalculateVolume()
        {
            double volume = (3.141592653589793 * Math.Pow((Length / 2), 2) * Height);
            return volume;
        }

        /// <summary>
        /// Sets the data for the cylinder
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
            Console.WriteLine("Enter Height As a Double: ");
            try
            {
                Height = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Character Entered Is Not A Double.");
            }

            Cylinder cylinder = new Cylinder(Length, Height);
        }

        /// <summary>
        /// overrides the toString for the cylinder table output
        /// </summary>
        /// <returns>cylinder string</returns>
        public override string ToString()
        {
            return "| Cylinder    | " + Length + " | " + Length + " | " + Height + " |";
        }
    }
}
