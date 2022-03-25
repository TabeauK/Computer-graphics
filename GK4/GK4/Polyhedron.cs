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
    public class Polyhedron : IObject3D
    {
        readonly Form1 form;
        public List<Relation> Relations;
        public Vertex Center;
        public Vector3 CenterScaled;


        public Polyhedron(Form1 f, params Relation[] rel)
        {
            Relations = rel.ToList();
            form = f;
            foreach (var r in Relations)
            {
                r.Poly = this;
            }
            int count = 0;
            double X = 0;
            double Y = 0;
            double Z = 0;
            foreach (var elem in Relations)
                foreach (var vert in elem.vertices)
                {
                    X += vert.X;
                    Y += vert.Y;
                    Z += vert.Z;
                    count++;
                }
            X /= (double)count;
            Y /= (double)count;
            Z /= (double)count;
            Center = new Vertex(new Vector4((float)X, (float)Y, (float)Z, 1));
        }

        public Polyhedron(Form1 f, params Vertex[] l)
        {
            form = f;
            Relations = new List<Relation>();
            for (int i = 0; i < l.Length; i++)
            {
                List<Vertex> l2 = new List<Vertex>
                {
                    l[i],
                    l[(i+1)>=l.Length?i+1-l.Length:i+1],
                    l[(i+2)>=l.Length?i+2-l.Length:i+2]
                };
                Relations.Add(new Relation(this, l2.ToArray()));
            }
            int count = 0;
            double X = 0;
            double Y = 0;
            double Z = 0;
            foreach (var elem in Relations)
                foreach (var vert in elem.vertices)
                {
                    X += vert.X;
                    Y += vert.Y;
                    Z += vert.Z;
                    count++;
                }
            X /= (double)count;
            Y /= (double)count;
            Z /= (double)count;
            Center = new Vertex(new Vector4((float)X, (float)Y, (float)Z, 1));
        }

        public Polyhedron(Form1 f, params (Vector4 v, Color C)[] l)
        {
            form = f;
            var list = new List<Vertex>();
            foreach (var (v, C) in l)
            {
                list.Add(new Vertex(v, C));
            }
            Relations = new List<Relation>();
            for (int i = 0; i < l.Length; i++)
            {
                List<Vertex> l2 = new List<Vertex>
                {
                    list[i],
                    list[(i+1)>=l.Length?i+1-l.Length:i+1],
                    list[(i+2)>=l.Length?i+2-l.Length:i+2]
                };
                Relations.Add(new Relation(this, l2.ToArray()));
            }
        }

        public void Show(DirectBitmap map, float[,] ZBuffor, GlobalDraw global)
        {
            Vector4 p = new Vector4(Center.X,Center.Y, Center.Z,Center.W);
            p = form.MultiplyMatrixByVector(form.ModelMatrix, p);
            p = form.MultiplyMatrixByVector(form.ViewMatrix, p);
            p = form.MultiplyMatrixByVector(form.ProjectionMatrix, p);
            CenterScaled = new Vector3((p.X / p.W + 0.75f) * map.Width / 2, (p.Y / p.W + 0.75f) * map.Height / 2, (p.Z / p.W + 0.75f) * map.Height / 2);
            foreach (var wall in Relations)
            {
                wall.Fill(form, map, ZBuffor, global);
            }
        }
    }
}
