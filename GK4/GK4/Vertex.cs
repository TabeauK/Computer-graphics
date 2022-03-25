using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GK4
{
    public class Vertex
    {
        public Vector4 Vector;
        public Color? Color;

        public Vertex(Vector4 vector4, Color? color)
        {
            Vector = vector4;
            Color = color;
        }

        public Vertex(Vector4 vector4, Color color)
        {
            Vector = vector4;
            Color = color;
        }

        public Vertex(Vector4 vector4)
        {
            Vector = vector4;
            Color = null;
        }

        public Vector4 CopyVector()
        {
            return new Vector4(Vector.X, Vector.Y, Vector.Z, Vector.W);
        }



        public float X
        {
            get
            {
                return Vector.X;
            }
        }
        public float Y
        {
            get
            {
                return Vector.Y;
            }
        }
        public float Z
        {
            get
            {
                return Vector.Z;
            }
        }
        public float W
        {
            get
            {
                return Vector.W;
            }
        }
    }

    public class Compare : IEqualityComparer<Vertex>
    {
        public bool Equals(Vertex x, Vertex y)
        {
            return (x.X == y.X && x.Y == y.Y && x.Z == y.Z && x.W == y.W);
        }

        public int GetHashCode(Vertex obj)
        {
            return 0;
        }
    }
}
