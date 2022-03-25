using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK2
{
    public class Triangle
    {
        public Vertex v1, v2, v3;
        public Triangle(Vertex V1, Vertex V2, Vertex V3)
        {
            v1 = V1;
            v2 = V2;
            v3 = V3;
        }

        public List<Vertex> ToList()
        {
            return new List<Vertex>() { v1, v2, v3 };
        }

        public void FillTriangle(Grid g)
        {
            List<Vertex> P = ToList();
            List<ActiveEdge> list = new List<ActiveEdge>();
            (Vertex v, int index)[] ind = new (Vertex, int)[P.Count];
            for (int i = 0; i < ind.Length; i++)
            {
                ind[i].v = P[i];
                ind[i].index = i;
            }
            Array.Sort(ind, (v1, v2) => v1.v.Y.CompareTo(v2.v.Y));
            int ymin = P[ind[0].index].Y;
            int ymax = P[ind[ind.Length - 1].index].Y;

            void AddRemove(int k,int y)
            {
                if (P[ind[k + 1 == P.Count ? 0 : k + 1].index].Y == P[ind[k].index].Y)
                {
                    Parallel.For(P[ind[k + 1 == P.Count ? 0 : k + 1].index].X, P[ind[k].index].X, x => g.DB.SetPixel(x, P[ind[k].index].Y, g.GetColor(x, P[ind[k].index].Y)));
                }
                if (P[ind[k].index].Y == y - 1)
                {
                    if (P[ind[k != 0 ? k - 1 : P.Count - 1].index].Y > P[ind[k].index].Y)
                    {
                        list.Add(new ActiveEdge(P[ind[k != 0 ? k - 1 : P.Count - 1].index], P[ind[k].index]));
                    }
                    if (P[ind[k + 1 == P.Count ? 0 : k + 1].index].Y > P[ind[k].index].Y)
                    {
                        list.Add(new ActiveEdge(P[ind[k + 1 == P.Count ? 0 : k + 1].index], P[ind[k].index]));
                    }
                    list.RemoveAll(x => x.YMax == y - 1);
                }
            }

            for (int y = ymin + 1; y < ymax; y++)
            {
                Parallel.For(0, P.Count - 1, k => AddRemove(k,y));
                list.Sort((e1, e2) => e1.XMin.CompareTo(e2.XMin));
                for (int z = 0; z < list.Count - 1; z += 2)
                {
                    if (g.fillingType == FillingType.Standard)
                        Parallel.For((int)list[z].XMin, (int)list[z + 1].XMin, x => g.DB.SetPixel(x, y, g.GetColor(x, y)));
                    else if (g.fillingType == FillingType.Interpolated)
                        Parallel.For((int)list[z].XMin, (int)list[z + 1].XMin, x => g.DB.SetPixel(x, y, g.GetColorInterpolated(x, y, this)));
                    else if (g.fillingType == FillingType.Hybrid)
                        Parallel.For((int)list[z].XMin, (int)list[z + 1].XMin, x => g.DB.SetPixel(x, y, g.GetColorHybrid(x, y, this)));
                }
                for (int i = 0; i < list.Count; i++)
                {
                    list[i]++;
                }
            }
        }
    }
}
