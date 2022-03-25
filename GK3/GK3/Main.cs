using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK3
{
    public partial class Form1 : Form
    {
        public void Main(Version v, Bitmap source, Bitmap map, int k)
        {
            Octree oct = new Octree(0, null, false,0);
            Dictionary<Color, int> colors = new Dictionary<Color, int>();
            for (int i = 0; i < source.Width; i++)
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    if (!colors.ContainsKey(c))
                        colors.Add(c, 1);
                    else
                        colors[c]++;
                }
            if (v ==Version.v1)
            {
                foreach (var elem in colors.Keys)
                    oct.AddColor(elem,colors[elem]);
                while (oct.leafCount > k)
                    oct.Reduce();
            }
            else if (v == Version.v2)
            {
                foreach (var elem in colors.Keys)
                {
                    oct.AddColor(elem,colors[elem]);
                    while (oct.leafCount > k)
                        oct.Reduce();
                    //if (oct.leafCount > k)
                    //    oct.Reduce();
                } 
            }
            else
            {
                var col = colors.ToList();
                col.Sort((c1, c2) => c2.Value.CompareTo(c1.Value));
                for (int i = 0; i < k && i < col.Count; i++)
                    oct.AddColor(col[i].Key,col[i].Value);
            }
            for (int i = 0; i < source.Width; i++)
                for (int j = 0; j < source.Height; j++)
                {
                    map.SetPixel(i, j, oct.Find(source.GetPixel(i, j)));
                }
            return;
        }
    }
}
