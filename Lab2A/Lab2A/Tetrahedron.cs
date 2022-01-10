using System;
using System.Collections.Generic;
using System.Text;

/*
 * Class: Tetrahedron.cs
 * Author: Piper Sicard 000824338
 * Date: October 6th, 2021
 * 
 * Purpose: This class contains the constructor and methods for the creation of a tetrahedron.
 * Inherits the Triangle class.
 * 
 * I, Piper Sicard, 000824338 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
*/
namespace Lab2A
{
    class Tetrahedron : Triangle
    {
        private double Length;
        private double Height;

        /// <summary>
        /// Constructor for the tetrahedron object
        /// </summary>
        /// <param name="length"></param>
        /// <param name="height"></param>
        public Tetrahedron(double length, double height) : base(length, height)
        {
            Length = length;
            Height = height;
        }

        /// <summary>
        /// Calculates the area of the tetrahedron
        /// </summary>
        /// <returns>area</returns>
        public override double CalculateArea()
        {
            double area = (Height * Length) * 4;
            return area;
        }

        /// <summary>
        /// Calculates the volume of the tetrahedron
        /// </summary>
        /// <returns>volume</returns>
        public override double CalculateVolume()
        {
            double volume = Math.Pow(Length, 3) / 6 * Math.Sqrt(2);
            return volume;
        }

        /// <summary>
        /// Sets the data for the tetrahedron
        /// </summary>
        public override void SetData()
        {
            Console.WriteLine("Enter Length of The Face As a Double: ");
            try
            {
                Length = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Character Entered Is Not A Double.");
            }
            Console.WriteLine("Enter Height of The Face As a Double: ");
            try
            {
                Height = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Character Entered Is Not A Double.");
            }

            Tetrahedron tetrahedron = new Tetrahedron(Length, Height);


        }

        /// <summary>
        /// Overrides toString for the tetrahedron table output
        /// </summary>
        /// <returns>tetrahedron string</returns>
        public override string ToString()
        {
            return "| Tetrahedron | " + Length + " | " + Length + " | " + Height + " |";
        }
    }
}
