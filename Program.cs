using System;

namespace zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangles triangle = new Triangles(2, 3, 4, 4, 5, 7);
            Circle circle = new Circle(4);
            Figures figure1 = circle;
            Figures figure2 = triangle;
            Console.WriteLine(figure1);
            Console.WriteLine(figure2);

        }
    }
}
