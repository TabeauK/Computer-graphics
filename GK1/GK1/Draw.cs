using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK1
{
    static public class Draw
    {
        static public PictureBox DrawAll(this PictureBox main)
        {
            Bitmap map = new Bitmap(main.Width, main.Height);
            foreach (Poly elem in Polygons.l)
            {
                map.DrawPoly(elem);
            }
            Polygons.UpdateLabels();
            main.Image = map;
            return main;
        }

        static public Bitmap DrawPoly(this Bitmap map, Poly poly)
        {
            foreach (Edge e in poly.edges)
            {
                e.AddPoints();
                map.DrawObject(e.from);
                map.DrawObject(e);
            }
            return map;
        }

        static public Bitmap DrawObject(this Bitmap map, ObjectOnBitmap o)
        {
            if (Action.moving && (Focuss.Object == null || MovingObject.original.verticles.Contains(Focuss.Object) || MovingObject.original.edges.Contains(Focuss.Object)))
            {
                map.DrawObjectColor(o, Color.Blue);
            }
            else if (Action.relating && o is Edge && (o as Edge).relation == Relation.NoRelation)
            {
                if ((o as Edge) == CreatingRelation.edge)
                {
                    map.DrawEdge((o as Edge), Color.Red);
                }
                else
                {
                    map.DrawEdge((o as Edge), Color.Green);
                }
            }
            else
            {
                map.DrawObjectColor(o, Color.Black);
            }
            return map;
        }

        static public Bitmap DrawObjectColor(this Bitmap map, ObjectOnBitmap o, Color c)
        {
            if (o is Vertex)
            {
                map.DrawVerticle((o as Vertex), c);
            }
            if (o is Edge)
            {
                map.DrawEdge((o as Edge), c);
            }
            return map;
        }

        static public Bitmap DrawVerticle(this Bitmap map, Vertex v, Color color)
        {
            v.bolding.Clear();
            for (int i = -v.boldness; i <= v.boldness; i++)
            {
                for (int j = -v.boldness; j <= v.boldness; j++)
                {
                    if (i + v.x > 0 && i + v.x < map.Width && j + v.y > 0 && j + v.y < map.Height)
                    {
                        v.bolding.Add((v.x + i, v.y + j));
                        map.SetPixel(v.x + i, v.y + j, color);
                    }
                }
            }
            return map;
        }

        static public Bitmap DrawEdge(this Bitmap map, Edge edge, Color color)
        {
            foreach (var elem in edge.bolding)
            {
                if (!edge.from.bolding.Contains(elem) && !edge.to.bolding.Contains(elem))
                    if (elem.x >= 0 && elem.x < map.Width && elem.y >= 0 && elem.y < map.Height)
                        map.SetPixel(elem.x, elem.y, color);
            }
            return map;
        }

        static public Bitmap DrawLine(this Bitmap map, Vertex a, Vertex b, Color color)
        {
            int x1 = b.x;
            int x0 = a.x;
            int y1 = b.y;
            int y0 = a.y;
            int dx = Math.Abs(x1 - x0), sx = x0 < x1 ? 1 : -1;
            int dy = Math.Abs(y1 - y0), sy = y0 < y1 ? 1 : -1;
            int err = (dx > dy ? dx : -dy) / 2, e2;
            for (; ; )
            {
                if (x0 >= 0 && x0 < map.Width && y0 >= 0 && y0 < map.Height)
                    map.SetPixel(x0, y0, color);
                if (x0 == x1 && y0 == y1)
                    break;
                e2 = err;
                if (e2 > -dx) { err -= dy; x0 += sx; }
                if (e2 < dy) { err += dx; y0 += sy; }
            }
            return map;
        }

        static public Bitmap DrawAllLines(this Bitmap map)
        {
            foreach(var elem in Polygons.l)
            {
                foreach (var elem2 in elem.edges)
                {
                    map.DrawLine(elem2.from, elem2.to, Color.Black);
                    
                }                
            }
            return map;
        }

    }
}
