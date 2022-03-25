using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GK4
{
    public interface IObject3D
    {
        void Show(DirectBitmap map, float[,] ZBuffor,GlobalDraw global);
    }
}
