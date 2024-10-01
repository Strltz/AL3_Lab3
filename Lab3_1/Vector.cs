using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    struct Vector
    {
        double x, y, z;
        
        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector operator+ (Vector a, Vector b)
        {
            return new Vector(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static Vector operator* (Vector a, Vector b)
        {
            return new Vector(a.x * b.x, a.y * b.y, a.z * b.z);
        }
        
        public static Vector operator* (Vector a, double b)
        {
            return new Vector(a.x * b, a.y * b, a.z * b);
        }

        public static Vector operator* (double b, Vector a)
        {
            return new Vector(a.x * b, a.y * b, a.z * b);
        }

        public static bool operator> (Vector a, Vector b)
        {
            return Math.Pow(a.x, 2) + Math.Pow(a.y, 2) + Math.Pow(a.z, 2) >
                Math.Pow(b.x, 2) + Math.Pow(b.y, 2) + Math.Pow(b.z, 2);
        }
        public static bool operator< (Vector a, Vector b)
        {
            return b > a;
        }

        public static bool operator== (Vector a, Vector b)
        {
            return !(a < b) && !(b > a);
        }

        public static bool operator!= (Vector a, Vector b)
        {
            return !(a == b);
        }
    }
}
