using System;
using System.Collections.Generic;
using System.Text;

/*
 * Class: Triangle.cs
 * Author: Piper Sicard 000824338
 * Date: October 6th, 2021
 * 
 * Purpose: This class contains the constructor and methods for the creation of a triangle.
 * Inherits the Shape class.
 * 
 * I, Piper Sicard, 000824338 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
*/
namespace Lab2A
{
    class Triangle : Shape
    {
        double Length;
        double Height;

        /// <summary>
        /// Constructor for the triangle object
        /// </summary>
        /// <param name="length"></param>
        /// <param name="height"></param>
        public Triangle(double length, double height)
        {
            Length = length;
            Height = height;
        }

        /// <summary>
        /// Calculates the area of the triangle
        /// </summary>
        /// <returns>area</returns>
        public override double CalculateArea()
        {
            double area = (Height * Length) / 2;
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
        /// Sets the data for the triangle
        /// </summary>
        public override void SetData()
        {
            Console.WriteLine("Enter Length of Base As a Double: ");
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

            Triangle triangle = new Triangle(Length, Height);


        }

        /// <summary>
        /// Overrides toString for the triangle table output
        /// </summary>
        /// <returns>triangle string</returns>
        public override string ToString()
        {
            return "| Triangle   | " + Length + " | " + 0 + " | " + Height + " |";
        }
    }
}
