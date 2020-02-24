using System;

namespace ConsoleApp20
{
    class Point
    {
        public int X;
        public int Y;
        public Point():this(0,0)
        {

        }
        public Point(Point A):this(A.X,A.Y)
        {

        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void ShowPoint()
        {
            Console.WriteLine($"({X};{Y})");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(4,5);
            Point B = new Point(A);
            A.ShowPoint();
            B.ShowPoint();
            Console.ReadLine();
        }
    }
}
