using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK1
{
    static public class CreatingPolygon
    {
        static public List<Vertex> l;
        static public Bitmap map;
    }
    static public class Focuss
    {
        static public ObjectOnBitmap Object;
    }
    static public class RightClick
    {
        static public int x;
        static public int y;
    }
    static public class MovingObject
    {
        static public int startX;
        static public int startY;
        static public Poly original;
    }
    static public class CreatingRelation
    {
        static public Edge edge;
        static public Relation relation;
    }
    public enum Relation { NoRelation, Equal, Perpendicular }
    public class ObjectOnBitmap
    {
        public List<(int x, int y)> bolding;
        public int boldness;
    }
}
