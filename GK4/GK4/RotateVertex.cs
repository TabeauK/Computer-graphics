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
        public void MoveVertex(Vertex v)
        {
            float valX = v.X;
            float valY = v.Y;
            float valZ = v.Z;
            float valW = v.W;

            if (checkBoxRotate.Checked)
            {
                Vector4 ver = new Vector4(valX, valY, valZ, valW);
                ver = RotationMatrix(Global.RPolyhedron.Center.Vector, ver,1);
                valX = ver.X;
                valY = ver.Y;
                valZ = ver.Z;
                valW = ver.W;

            }
            if (checkBoxMoveX.Checked)
            {
                if (Global.RotationCounter >= 100)
                    valX += 0.01f;
                else
                    valX -= 0.01f;
            }
            if (checkBoxMoveY.Checked)
            {
                if (Global.RotationCounter >= 100)
                    valY += 0.01f;
                else
                    valY -= 0.01f;
            }
            if (checkBoxMoveZ.Checked)
            {
                if (Global.RotationCounter >= 100)
                    valZ += 0.01f;
                else
                    valZ -= 0.01f;
            }
            Vector4 vector = new Vector4(valX, valY, valZ, valW);
            v.Vector = vector;
        }

        public void MoveVertex(Vector4 v)
        {
            float valX = v.X;
            float valY = v.Y;
            float valZ = v.Z;
            float valW = v.W;

            if (checkBoxRotate.Checked)
            {
                Vector4 ver = new Vector4(valX, valY, valZ, valW);
                ver = RotationMatrix(Global.RPolyhedron.Center.Vector, ver,1);
                valX = ver.X;
                valY = ver.Y;
                valZ = ver.Z;
                valW = ver.W;

            }
            if (checkBoxMoveX.Checked)
            {
                if (Global.RotationCounter >= 100)
                {
                    valX += 0.01f;
                }
                else
                {
                    valX -= 0.01f;
                }
            }
            if (checkBoxMoveY.Checked)
            {
                if (Global.RotationCounter >= 100)
                    valY += 0.01f;
                else
                    valY -= 0.01f;
            }
            if (checkBoxMoveZ.Checked)
            {
                if (Global.RotationCounter >= 100)
                    valZ += 0.01f;
                else
                    valZ -= 0.01f;
            }
            Vector4 vector = new Vector4(valX, valY, valZ, valW);
            v = vector;
        }
    }
}
