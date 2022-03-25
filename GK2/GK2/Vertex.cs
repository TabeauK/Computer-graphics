using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace GK2
{
    public class Vertex
    {
        public int Area { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Color C { get; set; }
        public Vector3D V { get; set; }

        public bool Same(Vertex v)
        {
            return (v.X - X) * (v.X - X) + (v.Y - Y) * (v.Y - Y) <= Area * Area;
        }

        public bool Same(int x, int y)
        {
            return (x - X) * (x - X) + (y - Y) * (y - Y) <= Area * Area;
        }
    }
}
