using System;

namespace flytime
{
    public struct Point
    {
        public int x, y, z;
        public Point(int nx, int ny, int nz)
        {
            x = nx;
            y = ny;
            z = nz;
        }
        public static double Distance (Point p1, Point p2)
        {
            double distance = Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2) + Math.Pow(p2.z - p1.z, 2));
            return distance;
        }
    }
}

