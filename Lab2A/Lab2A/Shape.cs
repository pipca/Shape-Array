/*
 * Class: Shape.cs
 * Author: Nicholas J. Corkigian
 * Date: September 4, 2017
 * 
 * Purpose: This abstract class is the base class of an object hierarchy
 * that describes many many other two-dimensional and three-dimensional
 * shapes.
 * 
 * As it is an abstract class, there can be no instances of it.
 * 
 * This code is not to be altered.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2A
{
    public abstract class Shape
    {
        public string Type { get; protected set; } //The type of shape
        private static int count = 0; //Number of instantiated shapes
        protected const double PI = 3.141592653589793; //Constant value for pi

        //All this constructor does is increment the number of Shape instances
        public Shape()
        {
            count++;
        }

        public abstract double CalculateArea(); //Calculate the shape's area (surface area if 3-d)

        public abstract double CalculateVolume(); //Calculate the shape's volume (If 3-d)

        public abstract void SetData(); //prompts the user for dimensions

        public override string ToString() => ""; //used for printing shape data

        //Retrieves the current number of shape instances
        public static int GetCount()
        {
            return count;
        }
    }
}
