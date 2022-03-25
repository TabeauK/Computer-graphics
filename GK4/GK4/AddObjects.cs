using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GK4
{
    static public class AddObjects
    {
        static public void Script(Form1 f,Global g,int k)
        {
            AddSphere1(f, g,k);
            AddCube1(f, g);
            AddPyramid1(f, g);
        }

        static public void AddSphere1(Form1 f, Global global,int k)
        {
            float R = 0.3f;
            Vector4 V = new Vector4(-0.6f, -0.6f, -0.6f, 1);
            Vertex Vx = new Vertex(V);
            Sphere s = new Sphere(f, Vx, R,k);
            global.Objects3D.Add(s);
        }

        static public void AddCube1(Form1 f, Global global)
        {
            float a = 1f;
            float b = 0.8f;
            Vertex v1 = new Vertex(new Vector4(b, b, b, 1f));
            Vertex v2 = new Vertex(new Vector4(b, b, a, 1f));
            Vertex v3 = new Vertex(new Vector4(b, a, b, 1f));
            Vertex v4 = new Vertex(new Vector4(a, b, b, 1f));
            Vertex v5 = new Vertex(new Vector4(a, a, a, 1f));
            Vertex v6 = new Vertex(new Vector4(a, a, b, 1f));
            Vertex v7 = new Vertex(new Vector4(a, b, a, 1f));
            Vertex v8 = new Vertex(new Vector4(b, a, a, 1f));
            Relation r1 = new Relation(Color.Red, v1, v2, v8, v3);
            Relation r2 = new RelationWithLight(global.Lights,Color.Chocolate,Color.White, v1, v4, v7, v2);
            Relation r3 = new Relation(Color.Blue, v1, v3, v6, v4);
            Relation r4 = new Relation(Color.Cyan, v5, v7, v4, v6);
            Relation r5 = new Relation(Color.Magenta, v5, v6, v3, v8);
            Relation r6 = new Relation(Color.Yellow, v5, v8, v2, v7);
            RotatingPolyhedron p = new RotatingPolyhedron(f, r1, r2, r3, r4, r5, r6);
            global.Objects3D.Add(p);
        }

        static public void AddPyramid1(Form1 f, Global global)
        {
            Vector4 V1 = new Vector4(0.1f, 0.1f, 0.1f, 1);
            Vector4 V2 = new Vector4(0.4f, 0.4f, 0.1f, 1);
            Vector4 V3 = new Vector4(0.4f, 0.1f, 0.4f, 1);
            Vector4 V4 = new Vector4(0.1f, 0.4f, 0.4f, 1);
            Vertex Vx1 = new Vertex(V1, Color.Yellow);
            Vertex Vx2 = new Vertex(V2, Color.Cyan);
            Vertex Vx3 = new Vertex(V3, Color.Magenta);
            Vertex Vx4 = new Vertex(V4, Color.White);
            Polyhedron p = new Polyhedron(f, Vx4, Vx3, Vx2, Vx1);
            global.Objects3D.Add(p);
        }
    }
}
