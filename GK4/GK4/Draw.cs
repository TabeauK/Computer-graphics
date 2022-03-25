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
    static public class Draw
    {
        static public PictureBox UpdateAll(this PictureBox box, Form1 form, Global global, Color back)
        {
            if (box != null && box.Image != null)
            {
                var b = ((box.Image as Bitmap).Tag as DirectBitmap);
                b.Dispose();
            }
            var ZBuffor = new float[box.Width, box.Height];
            DirectBitmap map = new DirectBitmap(box.Width, box.Height);
            for (int i = 0; i < box.Width; i++)
            {
                for (int j = 0; j < box.Height; j++)
                {
                    ZBuffor[i, j] = float.MinValue;
                    map.SetPixel(i, j, back);
                }
            }
            List<LightSource> gl = new List<LightSource>();
            foreach (var elem in global.Lights)
            {
                if (float.IsNaN(elem.X))
                    return box;
                Vector4 p2 = new Vector4(elem.Vector.X, elem.Vector.Y, elem.Vector.Z, elem.Vector.W);
                if(elem.parent==null && global.RotateLights)
                p2 = form.MultiplyMatrixByVector(form.ModelMatrixLight, p2);
                else
                    p2 = form.MultiplyMatrixByVector(form.ModelMatrix, p2);
                p2 = form.MultiplyMatrixByVector(form.ViewMatrix, p2);
                p2 = form.MultiplyMatrixByVector(form.ProjectionMatrix, p2);
                Vector4 v1 = new Vector4((p2.X / p2.W + 0.75f) * map.Width / 2, (p2.Y / p2.W + 0.75f) * map.Height / 2, (p2.Z / p2.W + 0.75f) * map.Height / 2, p2.W);
                if (float.IsNaN(v1.X))
                    return box;
                LightSource zz2 = new LightSource(v1, elem.Color.Value,elem.parent);
                gl.Add(zz2);
                if(global.ShowLights)
                for (int x = -5; x < 5; x++)
                    for (int y = -5; y < 5; y++)
                        if((int)zz2.X + x>0 && (int)zz2.X + x<map.Width && (int)zz2.Y + y>0 && (int)zz2.Y + y<map.Height)
                        map.SetPixel((int)zz2.X + x, (int)zz2.Y + y, zz2.Color.Value);
            }

            Vector4 p3 = new Vector4(global.V, 1);
            p3 = form.MultiplyMatrixByVector(form.ModelMatrix, p3);
            p3 = form.MultiplyMatrixByVector(form.ViewMatrix, p3);
            p3 = form.MultiplyMatrixByVector(form.ProjectionMatrix, p3);
            Vector3 V = new Vector3((p3.X / p3.W + 0.75f) * map.Width / 2, (p3.Y / p3.W + 0.75f) * map.Height / 2, (p3.Z / p3.W + 0.75f) * map.Height / 2);
            V = Vector3.Normalize(V);

            GlobalDraw g = new GlobalDraw
            {
                Ka = global.Ka,
                Ks = global.Ks,
                Kd =global.Kd,
                n = global.n,
                Moving =global.Moving,
                Shading = global.Shading,
                RPolyhedron =global.RPolyhedron,
                RotationCounter = global.RotationCounter,
                Lights = gl,
                V = V
            };

            if (global != null)
                foreach (var elem in global.Objects3D)
                {
                    elem.Show(map, ZBuffor, g);
                }
            box.Image = map.Bitmap;
            return box;
        }


    }
}
