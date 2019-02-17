using System;
using System.Collections.Generic;

namespace PadawansTask9
{
    public class CartesianCoordinates
    {
        public static List<Point> GetNeighbors(Point point, int range, params Point[] points)
        {
            if (point.Equals(null) || range == null || points == null || points.Equals(null) || point.X.Equals(null) || point.Y.Equals(null)
                 || point.X == null || point.Y == null)
            {
                throw new ArgumentNullException();
            }
            foreach (var item in points)
            {
                if (item.Equals(null) || item.X.Equals(null) || item.Y.Equals(null)
                    || item.X == null || item.Y == null)
                    throw new ArgumentNullException();
            }
            if (range <= 0)
            {
                throw new ArgumentException();
            }
            List<Point> result = new List<Point>();
            foreach (var item in points)
            {
                if ((point.X - range) <= item.X && (point.X + range) >= item.X && (point.Y - range) <= item.Y && (point.Y + range) >= item.Y)
                {
                    result.Add(item);
                }
            }
            result.Sort(delegate (Point first, Point second)
            {
                return first.X.CompareTo(second.X);
            });
            return result;
        }
    }
}