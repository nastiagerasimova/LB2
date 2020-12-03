using System;

namespace MainController._2_nd_lb_classes.Point_and_Figure
{
    class Point
    {
        public Point(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }

        public int X { get; }
        public int Y { get; }
        public string Name { get; }
    }
}
