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
        static public void FillTriangle(Form1 form, Relation rel, DirectBitmap g, float[,] ZBuffer, GlobalDraw global)
        {
            if (global.Shading == Shading.Normal)
                FillTriangleNormal(form, rel, g, ZBuffer, global);
            else if (global.Shading == Shading.Gourauds)
                FillTriangleGuords(form, rel, g, ZBuffer, global);
            else
                FillTrianglePhongs(form, rel, g, ZBuffer, global);
        }

        static public Vector3 GetColor(Form1 form, float x, float y, float z, Color col, Vector3 Normal, DirectBitmap map, GlobalDraw g)
        {
            Vector3 Ia = new Vector3(col.R, col.G, col.B);
            Vector3 Ka = new Vector3((float)g.Ka/10, (float)g.Ka / 10, (float)g.Ka / 10);
            Vector3 Kd = new Vector3((float)g.Kd / 10, (float)g.Kd / 10, (float)g.Kd / 10);
            Vector3 Ks = new Vector3((float)g.Ks / 10, (float)g.Ks / 10, (float)g.Ks / 10);
            int n = g.n;

            Vector3 color = new Vector3();
            color = Vector3.Multiply(Ia, Ka);

            foreach (var source in g.Lights)
            {
                Vector3 LightVector = new Vector3(x - source.Vector.X, y - source.Vector.Y, z - source.Vector.Z);
                LightVector = Vector3.Normalize(LightVector);
                //if (source.parent != null)
                //    if ((new Vector4(x, y, z, source.W) - source.Vector).Length() >= (new Vector4(source.parent.Normal, source.W) - new Vector4(x, y, z, source.W) + source.Vector).Length())
                //        continue;
                Vector3 ILight = new Vector3(source.Color.Value.R, source.Color.Value.G, source.Color.Value.B);
                var cosNL = Vector3.Dot(Normal, LightVector);
                if (cosNL < 0)
                {
                    continue;
                }
                var R = 2 * cosNL * Normal - LightVector;
                R = Vector3.Normalize(R);
                var cosVR = Vector3.Dot(g.V, R);
                if (cosVR < 0)
                {
                    cosVR = 0;
                }
                //if (cosNL < 0)
                //{
                //    cosNL = 0;
                //}

                var Id = Vector3.Multiply(ILight, cosNL * Kd);
                var Is = Vector3.Multiply(ILight, Ks * (float)Math.Pow(cosVR, n));
                color += Id + Is;
                if (float.IsNaN(color.X))
                {
                    return Vector3.Zero;
                }
            }
            if (color.X < 0) color.X = 0;
            if (color.Y < 0) color.Y = 0;
            if (color.Z < 0) color.Z = 0;

            return color;
        }

    }
}
