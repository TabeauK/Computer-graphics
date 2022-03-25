using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    public class Vertex : ObjectOnBitmap
    {
        public int x, y;
        public Vertex(int x, int y, int vertexBoldness)
        {
            boldness = vertexBoldness;
            bolding = new List<(int x, int y)>();
            this.x = x;
            this.y = y;
            for (int i = -vertexBoldness; i <= vertexBoldness; i++)
            {
                for (int j = -vertexBoldness; j <= vertexBoldness; j++)
                {
                    bolding.Add((x + i, y + j));
                }
            }
        }
        public bool Same(Vertex v)
        {
            foreach (var (x, y) in this.bolding)
                foreach ((int x, int y) elem2 in v.bolding)
                {
                    if (x == elem2.x && y == elem2.y)
                        return true;
                }
            return false;
        }
    }
}


