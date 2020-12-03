using System;

namespace MainController._2_nd_lb_classes.Point_and_Figure
{
    class Figure
    {
        Point A;
        Point B;
        Point C;
        Point D;
        Point E;

        public Figure(Point A, Point B, Point C,Point D,Point E)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.E = E;
        }
        public Figure(Point A, Point B, Point C,Point D) : this(A, B, C, D, null) { }
        public Figure(Point A, Point B, Point C) : this(A, B, C, null, null) { }

        private double LengthSide(Point A, Point B) => Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
        
        public void Perimeter()
        {
            double result;

            if(D==null && E == null)
            {
                result = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, A);
                Console.WriteLine($"Периметр многоугольника {A.Name + B.Name + C.Name} : {result}");
            }
            else if (E==null)
            {
                result = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, A);
                Console.WriteLine($"Периметр многоугольника {A.Name + B.Name + C.Name + D.Name} : {result}");
            }
            else
            {
                result = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, E) + LengthSide(E, A);
                Console.WriteLine($"Периметр многоугольника {A.Name + B.Name + C.Name + D.Name + E.Name} : {result}");
            }
        }
    }
}
