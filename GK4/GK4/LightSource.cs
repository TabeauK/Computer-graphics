using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GK4
{
    public class LightSource : Vertex
    {
        public RelationWithLight parent;
        public LightSource(Vector4 vector4, Color color,RelationWithLight r = null) : base(vector4, color)
        {
            parent = r;
        }
    }
}
