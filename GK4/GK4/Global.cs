using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GK4
{
    public class Global: GlobalDraw
    {
        public List<IObject3D> Objects3D { get; set; }
        public int SphereDetails;
        public bool RotateLights;
        public bool ShowLights;
    }

    public class GlobalDraw
    {
        public Vector3 V { get; set; }
        public RotatingPolyhedron RPolyhedron { get; set; }
        public Shading Shading { get; set; }
        public bool Moving { get; set; }
        public List<LightSource> Lights { get; set; }
        public int RotationCounter { get; set; }
        public int Kd;
        public int Ks;
        public int n;
        public int Ka;
    }
}
