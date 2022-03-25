using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GK4
{
    public class RelationWithLight : Relation
    {
        public LightSource Light;

        public RelationWithLight(List<LightSource> lights,Color col,Color colL, params Vertex[] v) : base(col, v)
        {
            Light = new LightSource(new Vector4(v.Sum(x => x.X) / 3, v.Sum(x => x.Y) / 3, v.Sum(x => x.Z) / 3, v.Sum(x => x.W) / 3),colL,this);
            lights.Add(Light);
        }


    }
}
