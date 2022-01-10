using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2A
{
    /*
 * Class: Rectangle.cs
 * Author: Piper Sicard 000824338
 * Date: October 6th, 2021
 * 
 * Purpose: This class contains the methods to create a rectangle shape.
 * It inherits the Shape class.
 * 
 * I, Piper Sicard, 000824338 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
*/
    public class Rectangle : Shape
    {
        private double Length;
        private double Width;

        /// <summary>
        /// Constructor for the Rectangle shape.
        /// Is used to create a rectangle shape
        /// Using the length and width inputted by
        /// the user.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        /// <summary>
        /// method that calculates the area of the rectangle.
        /// </summary>
        /// <returns>area</returns>
        public override double CalculateArea()
        {
            double area = Length * Width;
            return area;
        }

        /// <summary>
        /// Method that calculates the volume.
        /// </summary>
        /// <returns>0</returns>
        public override double CalculateVolume()
        {
            return 0;
        }

        /// <summary>
        /// Method that sets the data for the shape created by the user.
        /// </summary>
        public override void SetData()
        {
            Console.WriteLine("Enter Length As a Double: ");
            try
            {
                Length = double.Parse(Console.ReadLine());
            } catch (Exception)
            {
                Console.WriteLine("Character Entered Is Not A Double.");
            }
            Console.WriteLine("Please Enter Width As a Double: ");
            try
            {
                Width = double.Parse(Console.ReadLine());
            } catch (Exception)
            {
                Console.WriteLine("Character Entered Is Not A Double.");
            }
            Rectangle rectangle = new Rectangle(Length, Width);
        }

        /// <summary>
        /// ToString override that formats the  rectangles output for the table.
        /// </summary>
        /// <returns>Rectangle string</returns>
        public override string ToString()
        {
            return "| Rectangle   | " + Length + " | " + Length + " | " + 0 + " |";
        }
    }
}
