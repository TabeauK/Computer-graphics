using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GK4
{
    static public partial class FillingTriangles
    {
        static public void FillTriangleNormal(Form1 form, Relation rel, DirectBitmap g, float[,] ZBuffer, GlobalDraw global)
        {
            var P = rel.ToList();
            P.Sort((v1, v2) => v1.Y.CompareTo(v2.Y));
            ActiveEdge e1 = new ActiveEdge(P[0], P[1]);
            ActiveEdge e2 = new ActiveEdge(P[0], P[2]);
            ActiveEdge e3 = new ActiveEdge(P[1], P[2]);
            (ActiveEdge edge1, ActiveEdge edge2) Active = (e2, e1);
            if ((int)P[1].Y == (int)P[0].Y)
            {
                Active = (e2, e3);
            }
            for (float y = P[0].Y; y <= P[2].Y + 1 && y < g.Height; y++)
            {
                if ((int)y - 1 == (int)P[1].Y)
                {
                    Active = (e2, e3);
                }
                (ActiveEdge edge1, ActiveEdge edge2) = Active;
                if (edge1.XMin > edge2.XMin)
                {
                    ActiveEdge temp = edge1;
                    edge1 = edge2;
                    edge2 = temp;
                }
                for (float i = edge1.XMin; i <= edge2.XMin && i < g.Width; i++)
                {
                    if (y >= 0 && i >= 0)
                    {
                        float total = edge2.XMin - edge1.XMin;
                        float Z = edge1.Zmin + (edge2.Zmin - edge1.Zmin) * ((i - edge1.XMin) / total);

                        if (Z > ZBuffer[(int)i, (int)y])
                        {
                            Color col;
                            if (edge1.HasColors)
                            {
                                float R = edge1.R + (edge2.R - edge1.R) * ((i - edge1.XMin) / total);
                                float G = edge1.G + (edge2.G - edge1.G) * ((i - edge1.XMin) / total);
                                float B = edge1.B + (edge2.B - edge1.B) * ((i - edge1.XMin) / total);
                                col = Color.FromArgb((int)R, (int)G, (int)B);
                            }
                            else
                            {
                                col = rel.c.Value;
                            }
                            Vector3 Normal = rel.Normal;
                            if (rel.Poly is Sphere)
                            {
                                Normal = Normal - new Vector3(i, y, Z);
                                Normal = Vector3.Normalize(Normal);
                            }

                            //Vector3 I = new Vector3(col.R, col.G, col.B);
                            Vector3 I = GetColor(form, i, y, Z, col, Normal, g, global); //help
                            float R1 = I.X > 255 ? 255 : I.X < 0 ? 0 : I.X;
                            float G1 = I.Y > 255 ? 255 : I.Y < 0 ? 0 : I.Y;
                            float B1 = I.Z > 255 ? 255 : I.Z < 0 ? 0 : I.Z;
                            g.SetPixel((int)i, (int)y, Color.FromArgb((int)R1, (int)G1, (int)B1));
                            ZBuffer[(int)i, (int)y] = Z;
                        }
                    }
                }
                edge2++;
                edge1++;
            }
        }
    }
}
