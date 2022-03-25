using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GK4
{
    public class Sphere : IObject3D
    {
        public readonly Form1 form;
        public Vertex Center;
        public float Radius;
        public List<Relation> Relations;

        public Sphere(Form1 f, Vertex C, float R,int k)
        {
            form = f;
            Center = C;
            Radius = R;
            Vertex X = new Vertex(new Vector4(Center.X + Radius, Center.Y, Center.Z, Center.W), Color.Cyan);
            Vertex Y = new Vertex(new Vector4(Center.X, Center.Y + Radius, Center.Z, Center.W), Color.Magenta);
            Vertex Z = new Vertex(new Vector4(Center.X, Center.Y, Center.Z + Radius, Center.W), Color.Yellow);
            Vertex X2 = new Vertex(new Vector4(Center.X - Radius, Center.Y, Center.Z, Center.W), Color.Blue);
            Vertex Y2 = new Vertex(new Vector4(Center.X, Center.Y - Radius, Center.Z, Center.W), Color.Red);
            Vertex Z2 = new Vertex(new Vector4(Center.X, Center.Y, Center.Z - Radius, Center.W), Color.Green);
            List<Relation> r = new List<Relation>
            {
                new Relation(this, X2, Y2, Z2),
                new Relation(this, X2, Y2, Z),
                new Relation(this, X2, Y, Z),
                new Relation(this, X2, Y, Z2),
                new Relation(this, X, Y2, Z2),
                new Relation(this, X, Y2, Z),
                new Relation(this, X, Y, Z),
                new Relation(this, X, Y, Z2)
            };
            for (int zz = 0; zz < k; zz++)
            {
                List<Relation> rnew = new List<Relation>();
                foreach (Relation rel in r)
                {
                    var vert = rel.vertices;
                    Vector4 v1 = new Vector4((vert[0].X + vert[1].X) / 2, (vert[0].Y + vert[1].Y) / 2, (vert[0].Z + vert[1].Z) / 2, 1);
                    Vector4 v2 = new Vector4((vert[1].X + vert[2].X) / 2, (vert[1].Y + vert[2].Y) / 2, (vert[1].Z + vert[2].Z) / 2, 1);
                    Vector4 v3 = new Vector4((vert[2].X + vert[0].X) / 2, (vert[2].Y + vert[0].Y) / 2, (vert[2].Z + vert[0].Z) / 2, 1);
                    v1 = Center.Vector + ((Radius)) * (v1 - Center.Vector) / (Center.Vector - v1).Length();
                    v2 = Center.Vector + ((Radius)) * (v2 - Center.Vector) / (Center.Vector - v2).Length();
                    v3 = Center.Vector + ((Radius)) * (v3 - Center.Vector) / (Center.Vector - v3).Length();
                    Color? c1 = null;
                    Color? c2 = null;
                    Color? c3 = null;
                    if (vert.All(x => x.Color.HasValue))
                    {
                        c1 = Color.FromArgb((vert[0].Color.Value.R + vert[1].Color.Value.R) / 2, (vert[0].Color.Value.G + vert[1].Color.Value.G) / 2, (vert[0].Color.Value.B + vert[1].Color.Value.B) / 2);
                        c2 = Color.FromArgb((vert[1].Color.Value.R + vert[2].Color.Value.R) / 2, (vert[1].Color.Value.G + vert[2].Color.Value.G) / 2, (vert[1].Color.Value.B + vert[2].Color.Value.B) / 2);
                        c3 = Color.FromArgb((vert[2].Color.Value.R + vert[0].Color.Value.R) / 2, (vert[2].Color.Value.G + vert[0].Color.Value.G) / 2, (vert[2].Color.Value.B + vert[0].Color.Value.B) / 2);
                    }
                    var vertex1 = new Vertex(v1, c1);
                    var vertex2 = new Vertex(v2, c2);
                    var vertex3 = new Vertex(v3, c3);
                    rnew.Add(new Relation(this, vertex1, vert[0], vertex3));
                    rnew.Add(new Relation(this, vertex1, vert[1], vertex2));
                    rnew.Add(new Relation(this, vertex2, vert[2], vertex3));
                    rnew.Add(new Relation(this, vertex1, vertex2, vertex3));
                }
                r = rnew;
            }
            Relations = r.ToList();
        }

        public void Show(DirectBitmap map, float[,] ZBuffor,GlobalDraw global)
        {
            foreach (var item in Relations)
            {
                item.Fill(form, map, ZBuffor,global);
            }
        }
    }
}
