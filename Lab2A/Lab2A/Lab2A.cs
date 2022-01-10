/*
 * Class: Lab2A.cs
 * Author: Piper Sicard 000824338
 * Date: October 6th, 2021
 * 
 * Purpose: This class contains the main method where the user is prompted to create shapes and can 
 * get an output of a table of said shapes.
 * 
 * I, Piper Sicard, 000824338 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
*/
using System;
using System.Collections.Generic;

namespace Lab2A
{
    class Lab2A
    {
        static void Main(string[] args)
        {
            //int for shutting down the program.
            int i = 0;
            //int to determine what option the user chooses.
            int shape = 0;
            //int to count how many shapes are in the list.
            int shapeAmount = 0;
            //List that holds all the shapes.
            List<Shape> listOfShapes = new List<Shape>();
            //while loop that prints the menu for the user and gets their choice to decide
            //which shapes are generated.
            while (i != 1)
            {
                //prints out the menu for the user to select from.
                Console.WriteLine("Please Select An Option.");
                Console.WriteLine("1. Rectangle | 2. Square | 3. Box");
                Console.WriteLine("4. Cube | 5. Ellipse | 6. Circle");
                Console.WriteLine("7. Cylinder | 8. Sphere | 9. Triangle");
                Console.WriteLine("10. Tetrahedron | 11. Print Table And Exit");
                Console.WriteLine("===============");

                //Gets the users input to determine which shape to generate
                shape = int.Parse(Console.ReadLine());
                //switch for the users options
                switch (shape)
                {
                    //Case to generate a rectangle
                    case 1:
                        //Creates a rectangle shape
                        Rectangle rectangle = new Rectangle(0, 0);
                        //Sets the data for the rectangle shape
                        rectangle.SetData();
                        //adds the rectangle to the list
                        listOfShapes.Add(rectangle);
                        //increases the amount of detected shapes
                        shapeAmount++;
                        break;
                    //Case to generate a square
                    case 2:
                        //Creates a square shape
                        Square square = new Square(0);
                        //Sets the data for the square shape
                        square.SetData();
                        //Adds the square to the list
                        listOfShapes.Add(square);
                        //Increases the amount of detected shapes
                        shapeAmount++;
                        break;
                    case 3:
                        //Creates a box shape
                        Box box = new Box(0, 0, 0);
                        //Sets the data for the box shape
                        box.SetData();
                        //Adds the box to the list
                        listOfShapes.Add(box);
                        //Increases the amount of detected shapes
                        shapeAmount++;
                        break;
                    case 4:
                        //Creates a cube shape
                        Cube cube = new Cube(0);
                        //Sets the data for the cube shape
                        cube.SetData();
                        //Adds the cube to the list
                        listOfShapes.Add(cube);
                        //Increases the amount of detected shapes
                        shapeAmount++;
                        break;
                    case 5:
                        //Creates an Ellipse shape
                        Ellipse ellipse = new Ellipse(0, 0);
                        //Sets the data for the ellipse shape
                        ellipse.SetData();
                        //adds the ellipse to the list
                        listOfShapes.Add(ellipse);
                        //Increases the amount of detected shapes
                        shapeAmount++;
                        break;
                    case 6:
                        //Creates a circle shape
                        Circle circle = new Circle(0);
                        //Sets the data for the circle
                        circle.SetData();
                        //Adds the circle to the list
                        listOfShapes.Add(circle);
                        //Increases the amount of detected shapes
                        shapeAmount++;
                        break;
                    case 7:
                        //Creates a cylinder shape
                        Cylinder cylinder = new Cylinder(0, 0);
                        //Sets the data for the cylinder
                        cylinder.SetData();
                        //Adds the cylinder to the list
                        listOfShapes.Add(cylinder);
                        //Increases the amount of detected shapes
                        shapeAmount++;
                        break;
                    case 8:
                        //Creates a sphere shape
                        Sphere sphere = new Sphere(0);
                        //Sets the data for the sphere
                        sphere.SetData();
                        //Adds the sphere to the list
                        listOfShapes.Add(sphere);
                        //Increases the amount of detected shapes
                        shapeAmount++;
                        break;
                    case 9:
                        //Creates a triangle shape
                        Triangle triangle = new Triangle(0, 0);
                        //Sets the data for the triangle
                        triangle.SetData();
                        //Adds the triangle to the list
                        listOfShapes.Add(triangle);
                        //Increases the amount of detected shapes
                        shapeAmount++;
                        break;
                    case 10:
                        //Create a tetrahedron shape
                        Tetrahedron tetrahedron = new Tetrahedron(0, 0);
                        //Sets the data for the tetrahedron
                        tetrahedron.SetData();
                        //Adds the tetrahedron to the list
                        listOfShapes.Add(tetrahedron);
                        //Increases the amount of detected shapes
                        shapeAmount++;
                        break;
                    case 11:
                        //int to loop against for the amount of shapes
                        int x = 0;
                        //Outputs the table header
                        Console.WriteLine("| Type        | Length | Width | Height | Area | Volume |");
                        //While loop to output each shape from the list
                        while (x < shapeAmount) {
                            //string that holds the table information.
                            string tableOut = listOfShapes[x].ToString() + " | " + listOfShapes[x].CalculateArea().ToString() + " | " + listOfShapes[x].CalculateVolume().ToString() + " |";
                            //Outputs the table of shapes
                            Console.WriteLine(tableOut);
                            //increases the number the amount of shapes are being compared against
                            x++;
                        }
                        //Sets the i to 1 so that it exits the program
                        i = 1;
                        break;
                }
            }
        }
    }
}
