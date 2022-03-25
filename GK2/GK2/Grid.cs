using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace GK2
{
    public enum FillingType { Standard, Interpolated, Hybrid}
    public partial class Grid
    {
        public bool EditingNet;
        public bool ColorFill;
        public bool UsingNormalMap;
        public FillingType fillingType;
        public DirectBitmap DB;
        public DirectBitmap NormalMap;
        public DirectBitmap background;
        public PictureBox pictureBox;
        public Vector3D LightVersor;
        public Color lightColor;
        public Color color;
        public int ColumnSize;
        public int RowSize;
        public double Kd;
        public double Ks;
        public double M;
        public (int x, int y) MouseOnVertexIndex;
        public Vertex MouseOnVertex;
        public Vertex[,] vertices;
        public List<Triangle> triangles;
        public Grid(int columnSize, int rowSize, PictureBox box, Color color)
        {
            EditingNet = true;
            ColorFill = true;
            fillingType = FillingType.Standard;
            LightVersor = new Vector3D(0, 0, 1);
            lightColor = Color.White;
            Kd = 50;
            Ks = 50;
            M = 50;
            pictureBox = box;
            background = null;
            this.color = color;
            ColumnSize = columnSize < 2 ? 2 : columnSize;
            RowSize = rowSize < 2 ? 2 : rowSize;
            Resize();
        }

        public void Resize()
        {
            vertices = new Vertex[ColumnSize, RowSize];
            double xDistance = ((double)pictureBox.Width - 1) / (RowSize - 1);
            double yDistance = ((double)pictureBox.Height - 2) / (ColumnSize - 1);
            for (int i = 0; i < ColumnSize; i++)
            {
                for (int j = 0; j < RowSize; j++)
                {
                    vertices[i, j] = new Vertex
                    {
                        X = (int)xDistance * j,
                        Y = (int)yDistance * i,
                        Area = 3
                    };
                }
            }
            triangles = new List<Triangle>();
            for (int i = 0; i < ColumnSize; i++)
                for (int j = 0; j < RowSize; j++)
                {
                    if (i < ColumnSize - 1 && j < RowSize - 1)
                    {
                        triangles.Add(new Triangle(vertices[i, j], vertices[i + 1, j], vertices[i, j + 1]));
                    }
                    if (i < ColumnSize - 1 && j > 0)
                    {
                        triangles.Add(new Triangle(vertices[i, j], vertices[i + 1, j], vertices[i + 1, j - 1]));
                    }
                }
            this.UpdateAllGrid();
        }
    }
}
