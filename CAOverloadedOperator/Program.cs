using System;
namespace CAOverloadedOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(20, 10);
            Point b = new Point(0, 10);
            Point addTwoPoint = a + b;
            Point subTwoPoint = a - b;

            Console.WriteLine($"new Point Coordinates After Add : ({addTwoPoint.X} , {addTwoPoint.Y})");
            Console.WriteLine($"new Point Coordinates After Sub : ({subTwoPoint.X} , {subTwoPoint.Y})");


            Console.ReadKey();
        }
    }


    public class Point
    {
        private int x;
        private int y;

        public int X => x;
        public int Y => y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static Point operator + (Point point1, Point point2){

            var newPointX = point1.X + point2.X;
            var newPointY = point1.Y + point2.Y;
            return new Point(newPointX, newPointY);
        }

        public static Point operator -(Point point1, Point point2)
        {

            var newPointX = point1.X - point2.X;
            var newPointY = point1.Y - point2.Y;
            return new Point(newPointX, newPointY);
        }



    }
}
