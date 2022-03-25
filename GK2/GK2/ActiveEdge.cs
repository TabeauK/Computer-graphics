using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK2
{
    class ActiveEdge
    {
        public readonly int YMax;
        public double XMin;
        Vertex V1;
        Vertex V2;
        double M;
        public ActiveEdge(Vertex v1, Vertex v2)
        {
            V1 = v1;
            V2 = v2;
            M = ((double)(V1.X - V2.X)) / (V1.Y - V2.Y);
            YMax = (V1.Y > V2.Y ? V1 : V2).Y;
            XMin = (V1.Y < V2.Y ? V1 : V2).X;
        }

        public static ActiveEdge operator ++(ActiveEdge e)
        {
            e.XMin += e.M;
            return e;
        }

        public static ActiveEdge operator --(ActiveEdge e)
        {
            e.XMin -= e.M;
            return e;
        }
    }
}
