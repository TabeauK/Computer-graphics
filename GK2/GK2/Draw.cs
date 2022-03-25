using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK2
{
    static class Draw
    {
        static public Grid DrawLine(this Grid g, Vertex a, Vertex b, Color? color = null, DirectBitmap direct = null)
        {
            if (b == null)
            {
                return g;
            }
            int x1 = b.X;
            int x0 = a.X;
            int y1 = b.Y;
            int y0 = a.Y;
            int dx = Math.Abs(x1 - x0), sx = x0 < x1 ? 1 : -1;
            int dy = Math.Abs(y1 - y0), sy = y0 < y1 ? 1 : -1;
            int err = (dx > dy ? dx : -dy) / 2, e2;
            for (; ; )
            {
                if (x0 >= 0 && x0 < g.DB.Bitmap.Width && y0 >= 0 && y0 < g.DB.Bitmap.Height)
                {
                    if (direct != null)
                        g.DB.Bitmap.SetPixel(x0, y0, direct.GetPixel(x0, y0));
                    else if (color.HasValue)
                        g.DB.Bitmap.SetPixel(x0, y0, color.Value);
                    else
                        g.DB.Bitmap.SetPixel(x0, y0, g.GetColor(x0, y0));
                }
                if (x0 == x1 && y0 == y1)
                    break;
                e2 = err;
                if (e2 > -dx) { err -= dy; x0 += sx; }
                if (e2 < dy) { err += dx; y0 += sy; }
            }
            return g;
        }

        static public void CorrectGrid(this Grid g, (int x, int y) ind, Color? c = null, DirectBitmap dB = null)
        {
            g.FillTriangles(g.vertices[ind.x, ind.y]);
            if (g.EditingNet)
            {
                g.DrawLine(g.vertices[ind.x, ind.y], ind.x > 0 ? g.vertices[ind.x - 1, ind.y] : null, c, dB);
                g.DrawLine(g.vertices[ind.x, ind.y], ind.x < (g.ColumnSize - 1) ? g.vertices[ind.x + 1, ind.y] : null, c, dB);
                g.DrawLine(g.vertices[ind.x, ind.y], ind.y > 0 ? g.vertices[ind.x, ind.y - 1] : null, c, dB);
                g.DrawLine(g.vertices[ind.x, ind.y], ind.y < (g.RowSize - 1) ? g.vertices[ind.x, ind.y + 1] : null, c, dB);
                g.DrawLine(g.vertices[ind.x, ind.y], (ind.x > 0 && ind.y < (g.RowSize - 1)) ? g.vertices[ind.x - 1, ind.y + 1] : null, c, dB);
                g.DrawLine(g.vertices[ind.x, ind.y], (ind.x < g.ColumnSize - 1 && ind.y > 0) ? g.vertices[ind.x + 1, ind.y - 1] : null, c, dB);
            }
        }

        static public void UpdateAllGrid(this Grid g)
        {
            g.DB = new DirectBitmap(g.pictureBox.Width, g.pictureBox.Height);
            int xDistance = (g.pictureBox.Width - 1) / (g.RowSize - 1);
            int yDistance = (g.pictureBox.Height - 2) / (g.ColumnSize - 1);
            g.FillTriangles();
            if (g.EditingNet)
                for (int i = 0; i < g.ColumnSize; i++)
                    for (int j = 0; j < g.RowSize; j++)
                    {
                        g.DrawLine(g.vertices[i, j], i > 0 ? g.vertices[i - 1, j] : null, Color.Black);
                        g.DrawLine(g.vertices[i, j], j > 0 ? g.vertices[i, j - 1] : null, Color.Black);
                        g.DrawLine(g.vertices[i, j], (i > 0 && j < (g.RowSize - 1)) ? g.vertices[i - 1, j + 1] : null, Color.Black);
                    }
            g.pictureBox.Image = g.DB.Bitmap;
            g.pictureBox.Refresh();
        }


    }
}