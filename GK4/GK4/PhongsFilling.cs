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
        static public void FillTrianglePhongs(Form1 form, Relation rel, DirectBitmap g, float[,] ZBuffer, GlobalDraw global)
        {
            List<(Vector3 v, Vector3 color, Vector3 Normal)> verts = new List<(Vector3, Vector3,Vector3)>();
            foreach (var elem in rel.vertices)
            {
                Vector3 Normal = rel.Normal;
                if (rel.Poly is Sphere)
                {
                    Normal = Normal - new Vector3(elem.X, elem.Y, elem.Z);
                    Normal = Vector3.Normalize(Normal);
                }
                Vector3 col;
                if (elem.Color.HasValue)
                {
                    col = new Vector3(elem.Color.Value.R, elem.Color.Value.G, elem.Color.Value.B);
                }
                else
                {
                    col = new Vector3(rel.c.Value.R, rel.c.Value.G, rel.c.Value.B);
                }
                verts.Add((new Vector3(elem.X, elem.Y, elem.Z), col, Normal));
            }

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
                        //float Z = InterpolateZ(form, i, y, rel.vertices);
                        if (Z > ZBuffer[(int)i, (int)y])
                        {
                            Color Col = InterpolateColorPhongs(form, i, y, Z, verts);
                            Vector3 Normal = InterpolateNormal(form, i, y, Z, verts);
                            Vector3 I = GetColor(form, i, y, Z,Col, Normal, g, global);
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
        static public Color InterpolateColorPhongs(Form1 form, float x, float y, float z, List<(Vector3 v, Vector3 color,Vector3 Normal)> vs)
        {
            Vector3 pkt = new Vector3(x, y, z);
            float len1 = (vs[0].v - pkt).Length();
            float len2 = (vs[1].v - pkt).Length();
            float len3 = (vs[2].v - pkt).Length();
            float len = len1 + len2 + len3;
            float Red = len1 / len * vs[0].color.X + len2 / len * vs[1].color.X + len3 / len * vs[2].color.X;
            float Green = len1 / len * vs[0].color.Y + len2 / len * vs[1].color.Y + len3 / len * vs[2].color.Y;
            float Blue = len1 / len * vs[0].color.Z + len2 / len * vs[1].color.Z + len3 / len * vs[2].color.Z;
            return Color.FromArgb((int)Red, (int)Green, (int)Blue);
        }

        static public Vector3 InterpolateNormal(Form1 form, float x, float y, float z, List<(Vector3 v, Vector3 color, Vector3 Normal)> vs)
        {
            Vector3 pkt = new Vector3(x, y, z);
            float len1 = (vs[0].v - pkt).Length();
            float len2 = (vs[1].v - pkt).Length();
            float len3 = (vs[2].v - pkt).Length();
            float len = len1 + len2 + len3;
            float X = len1 / len * vs[0].Normal.X + len2 / len * vs[1].Normal.X + len3 / len * vs[2].Normal.X;
            float Y = len1 / len * vs[0].Normal.Y + len2 / len * vs[1].Normal.Y + len3 / len * vs[2].Normal.Y;
            float Z = len1 / len * vs[0].Normal.Z + len2 / len * vs[1].Normal.Z + len3 / len * vs[2].Normal.Z;
            return new Vector3(X, Y, Z);
        }
    }
}
