using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace GK2
{
    public partial class Grid
    {
        internal Color GetColor(int x, int y)
        {
            Color c = ColorFill ? color : background.GetPixel(x, y);
            Vector3D v = GetVector(x, y);
            double skalar = (v.X * LightVersor.X + v.Y * LightVersor.Y + v.Z * LightVersor.Z);
            Vector3D R = 2 * skalar * v - LightVersor;
            double temp = Kd / 100 * skalar + Ks / 100 * Math.Pow(R.Z, M);
            double r = lightColor.R * c.R * temp / 255;
            double g = lightColor.G * c.G * temp / 255;
            double b = lightColor.B * c.B * temp / 255;
            return Color.FromArgb((int)(r < 0 ? 0 : r > 255 ? 255 : r), (int)(g < 0 ? 0 : g > 255 ? 255 : g), (int)(b < 0 ? 0 : b > 255 ? 255 : b));
        }

        internal Color GetColorInterpolated(int x, int y, Triangle t)
        {
            double len1 = Math.Sqrt((t.v1.X - x) * (t.v1.X - x) + (t.v1.Y - y) * (t.v1.Y - y));
            double len2 = Math.Sqrt((t.v2.X - x) * (t.v2.X - x) + (t.v2.Y - y) * (t.v2.Y - y));
            double len3 = Math.Sqrt((t.v3.X - x) * (t.v3.X - x) + (t.v3.Y - y) * (t.v3.Y - y));
            double len = len1 + len2 + len3;
            double Red = len1 / len * t.v1.C.R + len2 / len * t.v2.C.R + len3 / len * t.v3.C.R;
            double Green = len1 / len * t.v1.C.G + len2 / len * t.v2.C.G + len3 / len * t.v3.C.G;
            double Blue = len1 / len * t.v1.C.B + len2 / len * t.v2.C.B + len3 / len * t.v3.C.B;
            return Color.FromArgb((int)Red, (int)Green, (int)Blue);
        }

        internal Color GetColorHybrid(int x, int y, Triangle t)
        {
            Color c = ColorFill ? color : background.GetPixel(x, y);
            double len1 = Math.Sqrt((t.v1.X - x) * (t.v1.X - x) + (t.v1.Y - y) * (t.v1.Y - y));
            double len2 = Math.Sqrt((t.v2.X - x) * (t.v2.X - x) + (t.v2.Y - y) * (t.v2.Y - y));
            double len3 = Math.Sqrt((t.v3.X - x) * (t.v3.X - x) + (t.v3.Y - y) * (t.v3.Y - y));
            double len = len1 + len2 + len3;
            double Red = len1 / len * c.R + len2 / len * c.R + len3 / len * c.R;
            double Green = len1 / len * c.G + len2 / len * c.G + len3 / len * c.G;
            double Blue = len1 / len * c.B + len2 / len * c.B + len3 / len * c.B;
            double X = len1 / len * t.v1.V.X + len2 / len * t.v2.V.X + len3 / len * t.v3.V.X;
            double Y = len1 / len * t.v1.V.Y + len2 / len * t.v2.V.Y + len3 / len * t.v3.V.Y;
            double Z = len1 / len * t.v1.V.Z + len2 / len * t.v2.V.Z + len3 / len * t.v3.V.Z;
            Vector3D normal = new Vector3D(X, Y, Z);

            double skalar = (X * LightVersor.X + Y * LightVersor.Y + Z * LightVersor.Z);
            Vector3D R = 2 * skalar * new Vector3D(X, Y, Z) - LightVersor;
            double temp = Kd / 100 * skalar + Ks / 100 * Math.Pow(R.Z, M);
            double r = lightColor.R * Red * temp / 255;
            double g = lightColor.G * Green * temp / 255;
            double b = lightColor.B * Blue * temp / 255;
            return Color.FromArgb((int)(r < 0 ? 0 : r > 255 ? 255 : r), (int)(g < 0 ? 0 : g > 255 ? 255 : g), (int)(b < 0 ? 0 : b > 255 ? 255 : b));

        }

        public Vector3D GetVector(int x, int y)
        {
            if (UsingNormalMap)
            {
                var v = new Vector3D(NormalMap.GetPixel(x, y).R - 128, NormalMap.GetPixel(x, y).G - 128, NormalMap.GetPixel(x, y).B);
                v = v / v.Length;
                return v;
            }
            else
            {
                return new Vector3D(0, 0, 1);
            }
        }

        public void FillTriangles(Vertex v = null)
        {
            foreach(var vert in vertices)
            {
                if (fillingType != FillingType.Standard)
                {
                    vert.C = GetColor(vert.X, vert.Y);
                }
                if (fillingType == FillingType.Hybrid)
                {
                    vert.V = GetVector(vert.X, vert.Y);
                }
            }
            if (v == null)
                Parallel.ForEach(triangles, x => x.FillTriangle(this));
            else
                Parallel.ForEach(triangles.FindAll(x => x.v1 == v || x.v2 == v || x.v3 == v), x => x.FillTriangle(this));
        }
    }
}
