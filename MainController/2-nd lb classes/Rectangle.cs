using System;

namespace MainController
{
    class Rectangle
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public Rectangle(double side1,double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalculator() => side1 * side2;
        public double PerimeterCalculator() => 2*(side1 + side2);
        
        public double Area
        {
            get
            {
                return AreaCalculator();
            }
            private set { }
        }

        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
            private set { }
        }
    }
}
