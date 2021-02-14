using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Vector3:IComparable<Vector3>
    {
        private readonly double x;
        private readonly double y;
        private readonly double z;

       

        public Vector3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double Length()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
        }
        public void Output()
        {
            Console.WriteLine($"({x},{y},{z})");
        }

        public static double ScalarComposition(Vector3 vector1,Vector3 vector2)
        {
            return (vector1.x * vector2.x) + (vector1.y * vector2.y) +( vector1.z + vector2.z);
        }

        public static double MixedComposition(Vector3 vector1,Vector3 vector2,Vector3 vector3)
        {
            return (vector1.x * vector2.y * vector3.z + vector2.x * vector3.y * vector1.z + vector1.y * vector2.z * vector3.x) - (vector1.z * vector2.y * vector3.x + vector1.x * vector2.z * vector3.y + vector1.y * vector2.x * vector3.z);
        }
        public int CompareTo(Vector3 that)
        {
            if (x == that.x && y == that.y && z == that.z)
            {
                return 1;
            }
            else
                return 0;
        }

        public static Vector3 operator +(Vector3 vector1, Vector3 vector2)
         {
            return new Vector3(vector1.x + vector2.x, vector1.y + vector2.y, vector1.z + vector2.z);
         }
        public static Vector3 operator * (Vector3 vector1, double multiplier)
        {
            return new Vector3(vector1.x * multiplier, vector1.y * multiplier, vector1.z * multiplier);
        }
        public static Vector3 operator *(Vector3 vector1, Vector3 vector2)
        {
            return new Vector3((vector1.y * vector2.z)-(vector2.y-vector1.z), ((vector1.x*vector2.z)-(vector2.x*vector1.z)),(vector1.x * vector2.y)-(vector2.x*vector1.y));
        }


    }
}
