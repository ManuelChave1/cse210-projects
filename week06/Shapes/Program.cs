using System;

class Program
{
    static void Main(string[] args)
    {

            Square square = new Square("red", 50);
          //  Console.WriteLine($"{square.GetColor()} / {square.GetArea()}");

            Rectangle rectangle = new Rectangle("Blue", 15, 45);
            Circle circle = new Circle("Pink", 30);

            //   Console.WriteLine($"{rectangle.GetColor()} / {rectangle.GetArea()} ");
            //  Console.WriteLine($"{circle.GetColor()} / {circle.GetArea():F}");

            List<Shape> listOfShapeObects = new List<Shape>();

            listOfShapeObects.Add(square);
            listOfShapeObects.Add(rectangle);
            listOfShapeObects.Add(circle);

            foreach(var objects in listOfShapeObects)
            {
                Console.WriteLine($"{objects.GetColor()} / {objects.GetArea():F}");
            }

           
    }
}