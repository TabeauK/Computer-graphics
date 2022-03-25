using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK3
{
    public class Octree
    {
        Octree[] children;
        bool isLeaf;
        Color? color;
        int height;
        readonly int position;
        int count;
        public int leafCount;


        public Octree(int position, Color? c, bool Leaf, int counter)
        {
            children = Leaf ? null : new Octree[8];
            isLeaf = Leaf;
            height = 0;
            count = counter;
            this.position = position;
            color = c;
            leafCount = Leaf ? 1 : 0;
        }

        public void AddColor(Color c, int counter)
        {
            var R = (c.R & (1 << (7 - position))) != 0;
            var G = (c.G & (1 << (7 - position))) != 0;
            var B = (c.B & (1 << (7 - position))) != 0;
            int RGB = (R ? 4 : 0) + (G ? 2 : 0) + (B ? 0 : 1);
            if (isLeaf)
            {
                count += counter;
                return;
            }
            Octree o = children[RGB];
            if (o == null)
            {
                if (position == 7)
                    children[RGB] = new Octree(position + 1, c, true, counter);
                else
                {
                    children[RGB] = new Octree(position + 1, null, false, 0);
                    children[RGB].AddColor(c, counter);
                }
                leafCount = children.Select(x => x).Where(x => x != null).Sum(z => z.leafCount);
                height = children.Select(x => x).Where(x => x != null).Max(z => z.height) + 1;
                count = children.Select(x => x).Where(x => x != null).Sum(z => z.count);
            }
            else
            {
                o.AddColor(c, counter);
                leafCount = children.Select(x => x).Where(x => x != null).Sum(z => z.leafCount);
                height = children.Select(x => x).Where(x => x != null).Max(z => z.height) + 1;
                count = children.Select(x => x).Where(x => x != null).Sum(z => z.count);
            }

        }

        public bool Reduce()
        {
            if (height == 0)
                return false;
            if (height > 1)
            {
                int max = children.Select(x => x).Where(x => x != null).Max(x => x.height);
                int maxC = children.Select(x => x).Where(x => x != null && x.height == max).Max(x => x.count);
                Octree o = children.First(x => x != null && x.height == max && x.count == maxC);
                o.Reduce();
                leafCount = children.Select(x => x).Where(x => x != null).Sum(z => z.leafCount);
                height = children.Select(x => x).Where(x => x != null).Max(z => z.height) + 1;
                count = children.Select(x => x).Where(x => x != null).Sum(z => z.count);
                return true;
            }
            (Color? c, int count)[] colors = children.Select(x => x).Where(x => x != null).Select(x => (x.color, x.count)).ToArray();

            var R = (int)colors.Sum(x => x.c.Value.R * x.count) / count;
            var G = (int)colors.Sum(x => x.c.Value.G * x.count) / count;
            var B = (int)colors.Sum(x => x.c.Value.B * x.count) / count;
            leafCount = 1;
            color = Color.FromArgb(R, G, B);
            isLeaf = true;
            children = null;
            count = colors.Sum(x => x.count);
            height = 0;
            return true;
        }

        public Color Find(Color c)
        {
            var R = (c.R & (1 << (7 - position))) != 0;
            var G = (c.G & (1 << (7 - position))) != 0;
            var B = (c.B & (1 << (7 - position))) != 0;
            if (!isLeaf)
            {
                Octree o = children[(R ? 4 : 0) + (G ? 2 : 0) + (B ? 0 : 1)];
                return o.Find(c);
            }
            return color.Value;
        }
    }
}
