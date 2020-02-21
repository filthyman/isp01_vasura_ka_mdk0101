using System;
using System.Collections.Generic;
using System.Text;

namespace Vector
{
    class Vector3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Vector3D(int x, int y, int z) 
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"vec(x:{X},y:{Y},z:{Z};)";
        }


        public double VectorLength() 
        {
            double resiltOFscalarProduct = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
            return resiltOFscalarProduct;
        }

        public double scalarProductWithOther(Vector3D vector2) 
        {
            double resiltOFscalarProductWithOther = vector2.X + Y * vector2.Y * Z * vector2.Z;
            return resiltOFscalarProductWithOther;
        }

        public Vector3D vectorMultiplicationWithAnotherVector(Vector3D vector) 
        {
            Vector3D resVector = new Vector3D(0,0,0);

            resVector.X = Y * vector.Z - Z * vector.Y;
            resVector.Y = Z * vector.X - X * vector.Z;
            resVector.Z = X * vector.Y - Y * vector.X;

            return resVector;
        }


    }
}
