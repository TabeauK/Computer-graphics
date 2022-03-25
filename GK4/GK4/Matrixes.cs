using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GK4
{
    public partial class Form1 : Form
    {

        public Matrix4x4 ModelMatrix
        {
            get
            {
                Matrix4x4 tab = new Matrix4x4
                {
                    M11 = (float)Math.Cos(2 * alpha),
                    M12 = -(float)Math.Sin(2 * alpha),
                    M21 = (float)Math.Sin(2 * alpha),
                    M22 = (float)Math.Cos(2 * alpha),
                    M33 = 1f, 
                    M44 = 1f,
                    M14 = -0.5f,
                    M24 = -0.5f,
                    M34 = -0.5f
                };

                return tab;
            }
        }

        public Matrix4x4 ModelMatrixLight
        {
            get
            {
                Matrix4x4 tab = new Matrix4x4
                {
                    M11 = (float)Math.Cos(0),
                    M12 = -(float)Math.Sin(0),
                    M21 = (float)Math.Sin(0),
                    M22 = (float)Math.Cos(0),
                    M33 = 1f,
                    M44 = 1f,
                    M14 = -0.5f,
                    M24 = -0.5f,
                    M34 = -0.5f
                };

                return tab;
            }
        }

        public Matrix4x4 ProjectionMatrix
        {
            get
            {
                int n = 1;
                int fov = trackBarFOV.Value;
                int f = 45;
                float e = 1 / (float)(Math.Tan(fov * Math.PI / 360));
                float a = (float)pictureBox1.Height / (float)pictureBox1.Width;
                Matrix4x4 tab = new Matrix4x4
                {
                    M11 = e,
                    M22 = e / a,
                    M33 = -(f + n) / (f - n),
                    M34 = -2 * f * n / (f - n),
                    M43 = 1
                };
                return tab;
            }
        }

        public Matrix4x4 ViewMatrix
        {
            get
            {
                Matrix4x4 tab = new Matrix4x4
                {
                    M11 = -0.164f,
                    M12 = 0.986f,
                    M13 = 0,
                    M14 = 0,
                    M21 = -0.16f,
                    M22 = -0.027f,
                    M23 = 0.987f,
                    M24 = 0,
                    M31 = 0.973f,
                    M32 = 0.162f,
                    M33 = 0.162f,
                    M34 = -3.082f,
                    M44 = 1
                };
                return tab;
            }
        }

        public Vector4 MultiplyMatrixByVector(Matrix4x4 matrix, Vector4 vector)
        {
            Vector4 v4 = new Vector4
            {
                X = matrix.M11 * vector.X + matrix.M12 * vector.Y + matrix.M13 * vector.Z + matrix.M14 * vector.W,
                Y = matrix.M21 * vector.X + matrix.M22 * vector.Y + matrix.M23 * vector.Z + matrix.M24 * vector.W,
                Z = matrix.M31 * vector.X + matrix.M32 * vector.Y + matrix.M33 * vector.Z + matrix.M34 * vector.W,
                W = matrix.M41 * vector.X + matrix.M42 * vector.Y + matrix.M43 * vector.Z + matrix.M44 * vector.W
            };
            return v4;
        }


        public Vector4 RotationMatrix(Vector4 center, Vector4 v, int beta)
        {


            Matrix4x4 translate2 = new Matrix4x4
            {
                M11 = 1f,
                M22 = 1f,
                M33 = 1f,
                M44 = 1f,
                M14 = -center.X,
                M24 = -center.Y,
                M34 = -center.Z,
            };

            Vector4 vector = MultiplyMatrixByVector(translate2, v);

            Matrix4x4 AroundZ = new Matrix4x4
            {
                M11 = (float)Math.Cos(0.05*beta),
                M22 = (float)Math.Cos(0.05*beta),
                M21 = (float)Math.Sin(0.05 * beta),
                M12 = -(float)Math.Sin(0.05 * beta),
                M33 = 1f,
                M44 = 1f,
            };

            vector = MultiplyMatrixByVector(AroundZ, vector);

            Matrix4x4 AroundX = new Matrix4x4
            {
                M22 = (float)Math.Cos(0.05 * beta),
                M33 = (float)Math.Cos(0.05 * beta),
                M32 = (float)Math.Sin(0.05 * beta),
                M23 = -(float)Math.Sin(0.05 * beta),
                M11 = 1f,
                M44 = 1f,
            };

            vector = MultiplyMatrixByVector(AroundX, vector);

            Matrix4x4 translate1 = new Matrix4x4
            {
                M11 = 1f,
                M22 = 1f,
                M33 = 1f,
                M44 = 1f,
                M14 = center.X,
                M24 = center.Y,
                M34 = center.Z,
            };

            vector = MultiplyMatrixByVector(translate1, vector);

            return vector;
        }
    }
}
