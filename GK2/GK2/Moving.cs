using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK2
{
    public partial class Form1 : Form
    {
        private void PictureBox1_SizeChanged(object sender, EventArgs e)
        {
            if (Grid != null)
            {
                for (int i = 0; i < Grid.vertices.GetLength(0); i++)
                    for (int j = 0; j < Grid.vertices.GetLength(1); j++)
                    {
                        Grid.vertices[i, j].X = (int)(Grid.vertices[i, j].X * (double)pictureBox1.Width / W);
                        Grid.vertices[i, j].Y = (int)(Grid.vertices[i, j].Y * (double)pictureBox1.Height / H);
                    }
                Grid.DB.Resize(pictureBox1.Width, pictureBox1.Height);
                if(Grid.background!=null)
                {
                    Grid.background.Resize(pictureBox1.Width, pictureBox1.Height);
                }
                if(Grid.NormalMap!= null)
                {
                    Grid.NormalMap.Resize(pictureBox1.Width, pictureBox1.Height);
                }
                W = pictureBox1.Width;
                H = pictureBox1.Height;
                Grid.UpdateAllGrid();
            }
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < Grid.ColumnSize; i++)
                for (int j = 0; j < Grid.RowSize; j++)
                {
                    if (Grid.vertices[i, j].Same(e.X, e.Y))
                    {
                        Grid.MouseOnVertexIndex = (i, j);
                        Grid.MouseOnVertex = Grid.vertices[i, j];
                        pictureBox1.MouseMove += PictureBox1_MouseMoveVertex;
                        pictureBox1.MouseUp += PictureBox1_MouseUpOnVertex;
                        return;
                    }
                }
        }

        private void PictureBox1_MouseMoveVertex(object sender, MouseEventArgs e)
        {
            if (Grid.UsingNormalMap)
                Grid.CorrectGrid(Grid.MouseOnVertexIndex, null, Grid.background);
            else
                Grid.CorrectGrid(Grid.MouseOnVertexIndex, Grid.color);
            Grid.MouseOnVertex.X = e.X < 0 ? 0 : e.X < Grid.pictureBox.Width ? e.X : Grid.pictureBox.Width - 1;
            Grid.MouseOnVertex.Y = e.Y < 0 ? 0 : e.Y < Grid.pictureBox.Height ? e.Y : Grid.pictureBox.Height - 1;
            Grid.CorrectGrid(Grid.MouseOnVertexIndex, Color.Black);
            Grid.pictureBox.Refresh();
        }

        private void PictureBox1_MouseUpOnVertex(object sender, MouseEventArgs e)
        {
            Grid.UpdateAllGrid();
            pictureBox1.MouseMove -= PictureBox1_MouseMoveVertex;
            pictureBox1.MouseUp -= PictureBox1_MouseUpOnVertex;
        }
    }
}
