using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK4
{
    public class ActiveEdge
    {
        public readonly int YMax;
        public float XMin;
        public float Zmin;
        readonly Vertex V1;
        readonly Vertex V2;
        float Mx;
        float Mz;
        public float R, G, B;
        public readonly bool HasColors;
        float Mr, Mg, Mb;
        public ActiveEdge(Vertex v1, Vertex v2)
        {
            V1 = v1.Y > v2.Y ? v1 : v2;
            V2 = v1.Y <= v2.Y ? v1 : v2;

            Mx = (V1.X - V2.X) / (V1.Y - V2.Y + 2);
            Mz = (V1.Z - V2.Z) / (V1.Y - V2.Y + 2);
            YMax = (int)V1.Y + 1;
            XMin = (int)V2.X;
            Zmin = V2.Z;
            if (this.V1.Color.HasValue)
            {
                HasColors = true;
                R = V2.Color.Value.R;
                G = V2.Color.Value.G;
                B = V2.Color.Value.B;
                Mr = (V1.Color.Value.R - V2.Color.Value.R) / (V1.Y - V2.Y + 2);
                Mg = (V1.Color.Value.G - V2.Color.Value.G) / (V1.Y - V2.Y + 2);
                Mb = (V1.Color.Value.B - V2.Color.Value.B) / (V1.Y - V2.Y + 2);
            }
        }

        public static ActiveEdge operator ++(ActiveEdge e)
        {
            e.XMin += e.Mx;
            e.Zmin += e.Mz;
            e.R += e.Mr;
            e.G += e.Mg;
            e.B += e.Mb;
            return e;
        }

        public static ActiveEdge operator --(ActiveEdge e)
        {
            e.XMin -= e.Mx;
            e.XMin -= e.Mz;
            e.R -= e.Mr;
            e.G -= e.Mg;
            e.B -= e.Mb;
            return e;
        }
    }
}
