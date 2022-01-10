using System;
using System.Collections.Generic;
using System.Text;

/*
 * Class: Box.cs
 * Author: Piper Sicard 000824338
 * Date: October 6th, 2021
 * 
 * Purpose: This class contains the constructor and methods for the creation of a box.
 * Inherits the rectangle class.
 * 
 * I, Piper Sicard, 000824338 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
*/
namespace Lab2A
{
    public class Box : Rectangle
    {
        private double Length;
        private double Width;
        private double Height;
        /// <summary>
        /// Constructor for the Box object.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Box(double length, double width, double height) : base(length, width)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Calculates the box area
        /// </summary>
        /// <returns>area</returns>
        public override double CalculateArea()
        {
            double area = (2 * (Length * Width)) + (2 * (Length * Height)) + (2 * (Height * Width));
            return area;
        }

        /// <summary>
        /// Calculates the box volume
        /// </summary>
        /// <returns>volume</returns>
        public override double CalculateVolume()
        {
            double volume = Length * Width * Height;
            return volume;
        }

        /// <summary>
        /// Sets the data for the box object
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
            Console.WriteLine("Enter Width As a Double: ");
            try
            {
                Width = double.Parse(Console.ReadLine());
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
        }

        //Overrides the toString to output the box for the table.
        public override string ToString()
        {
            return "| Box        | " + Length + " | " + Width + " | " + Height + " |";
        }
    }
}
