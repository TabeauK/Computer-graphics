using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GK4
{
    public class RotatingPolyhedron : Polyhedron
    {
        public RotatingPolyhedron(Form1 f, params Relation[] rel) : base(f, rel)
        {
        }
    }
}
