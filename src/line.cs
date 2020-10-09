
namespace Codingames.Math
{
    using System;

    public class Point
    {
        public double X { get; }
        public double Y { get; }
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public Point(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public override string ToString()
        {
            return "X:" + X + " Y:" + Y;
        }
    }

    public class Line
    {
        public double X { get; }
        public double Y { get; }
        public double C { get; }
        public double S => DV.Y / DV.X;

        public Point NV => new Point(X, Y);
        public Point DV => new Point(Y, -X);
        public Line(Point p1, Point p2)
        {
            // (y2-y1)⋅(x-x1)=(x2-x1)⋅(y-y1)
            X -= p2.Y - p1.Y;
            Y = p2.X - p1.X;
            C = X * (-p1.X) + Y * (-p1.Y);
        }

        public Line(double x, double y, double c){
            X=x;
            Y=y;
            C=c;
        }

        public double OrientedPointDistance(Point p)
        {
            var d = 0.0;
            d = (X * p.X + Y * p.Y + C) / (System.Math.Sqrt(X * X + Y * Y));

            return d;
        }

        public double PointDistance(Point p)
        {
            return System.Math.Abs(OrientedPointDistance(p));
        }


    }
}

