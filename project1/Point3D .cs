using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public class Point3D : ICloneable, IComparable<Point3D>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        #region Constructors with chaining
        public Point3D() : this(0, 0, 0) { }
        public Point3D(int x) : this(x, 0, 0) { }
        public Point3D(int x, int y) : this(x, y, 0) { }
        public Point3D(int x, int y, int z)
        {
            X = x; Y = y; Z = z;
        }
        #endregion

        #region Override ToString
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }
        #endregion

        #region Operator Overloading
        public static bool operator ==(Point3D p1, Point3D p2)
        {
            if (ReferenceEquals(p1, null) && ReferenceEquals(p2, null))
            {

                return true;
            }
            if (ReferenceEquals(p1, null) || ReferenceEquals(p2, null))
            {
                return false;
            }
            return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
        }
        public static bool operator !=(Point3D p1, Point3D p2) => !(p1 == p2);

        public override bool Equals(object obj)
        {
            if (obj is Point3D p) return this == p;
            return false;
        }
        public override int GetHashCode() => (X, Y, Z).GetHashCode();
        #endregion

        #region Sorting (IComparable)
        public int CompareTo(Point3D other)
        {
            if (X != other.X) return X.CompareTo(other.X);
            return Y.CompareTo(other.Y);
        }
        #endregion

        #region ICloneable
        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }
        #endregion
    }
}
