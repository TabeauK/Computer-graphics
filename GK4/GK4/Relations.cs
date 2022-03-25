using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK4
{
    public class Relation
    {
        public IObject3D Poly;
        public List<Vertex> vertices;
        public Color? c;
        public Vector3 Normal;


        public Relation(IObject3D p, params Vertex[] v)
        {
            Poly = p;
            vertices = v.ToList();
            c = null;
        }

        public Relation(Color col, params Vertex[] v)
        {
            vertices = v.ToList();
            c = col;
        }

        public Relation(Color? col, params Vertex[] v)
        {
            vertices = v.ToList();
            c = col;
        }

        public List<Vertex> ToList()
        {
            return vertices;
        }


        public Vector3 NormalVector(Form1 form, DirectBitmap map, List<Vertex> vertices)
        {
            Vector3 normal;
            if (Poly is Polyhedron)
            {
                Vector3 v1 = new Vector3(vertices[0].X, vertices[0].Y, vertices[0].Z);
                Vector3 v2 = new Vector3(vertices[1].X, vertices[1].Y, vertices[1].Z);
                Vector3 v3 = new Vector3(vertices[2].X, vertices[2].Y, vertices[2].Z);
                normal = Vector3.Cross(v1 - v2, v3 - v2);
                normal = Vector3.Normalize(normal);
                if ((v1 + normal - (Poly as Polyhedron).CenterScaled).LengthSquared() + 1 > (v1 - (Poly as Polyhedron).CenterScaled).LengthSquared())
                    normal = Vector3.Negate(normal);
            }
            else
            {
                var P = Poly as Sphere;
                Vector4 p = new Vector4(P.Center.X, P.Center.Y, P.Center.Z, P.Center.W);
                p = form.MultiplyMatrixByVector(form.ModelMatrix, p);
                p = form.MultiplyMatrixByVector(form.ViewMatrix, p);
                p = form.MultiplyMatrixByVector(form.ProjectionMatrix, p);
                normal = new Vector3((p.X / p.W + 0.75f) * map.Width / 2, (p.Y / p.W + 0.75f) * map.Height / 2, (p.Z / p.W + 0.75f) * map.Height/2);

            }
            return normal;
        }

        virtual public void Fill(Form1 form, DirectBitmap map, float[,] ZBuffor, GlobalDraw global)
        {
            List<Vertex> l = new List<Vertex>();
            foreach (var elem in vertices)
            {
                Vector4 p = new Vector4(elem.Vector.X, elem.Vector.Y, elem.Vector.Z, elem.Vector.W);
                p = form.MultiplyMatrixByVector(form.ModelMatrix, p);
                p = form.MultiplyMatrixByVector(form.ViewMatrix, p);
                p = form.MultiplyMatrixByVector(form.ProjectionMatrix, p);
                Vertex zz = new Vertex(new Vector4((p.X / p.W + 0.75f) * map.Width / 2, (p.Y / p.W + 0.75f) * map.Height / 2, (p.Z / p.W + 0.75f) * map.Height / 2, p.W), elem.Color);
                l.Add(zz);
            }
            Normal = NormalVector(form, map, l);

            List<Relation> nl = new List<Relation>();
            for (int i = 1; i < l.Count - 1; i++)
            {
                {
                    Relation l2 = new Relation(c, l[0], l[i], l[i + 1])
                    {
                        Poly = Poly,
                        Normal = Normal
                    };
                    nl.Add(l2);
                }
            }
            foreach (var item in nl)
            {
                FillingTriangles.FillTriangle(form, item, map, ZBuffor, global);
            }
        }
    }
}
