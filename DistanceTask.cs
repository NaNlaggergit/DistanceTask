using System;

namespace DistanceTask;

public static class DistanceTask
{
    // Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
    public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
    {
        double xAP=x-ax;
        double yAP=y-ay;
        double xAB = bx - ax;
        double yAB = by - ay;
        double ab2=xAB*xAB+ yAB*yAB;
        if (ab2 == 0) return Math.Sqrt(xAP * xAP + yAP * yAP);
        double t = (xAP*xAB+ yAP*yAB)/ab2;
        if (t <= 0) 
            return Math.Sqrt(xAP*xAP+ yAP*yAP);
        else if (t >= 1)
        {
            double xBP = x - bx;
            double yBP = y- by;
            return Math.Sqrt(xBP * xBP + yBP * yBP);
        }
        else
        {
            double projx = ax + t * xAB;
            double projy = ay + t * yAB;
            double dx = x - projx;
            double dy = y - projy;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}