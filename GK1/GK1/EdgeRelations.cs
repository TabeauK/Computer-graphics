using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    public partial class Edge : ObjectOnBitmap
    {
        public bool IsRelationOk
        {
            get
            {
                if (relation == Relation.Equal)
                {
                    return Lenght == related.Lenght;
                }
                if (relation == Relation.Perpendicular)
                {
                    if (to.y - from.y == 0)
                    {
                        if (related.to.x - related.from.x == 0)
                        {
                            return true;
                        }
                        return false;
                    }
                    if (related.to.y - related.from.y == 0)
                    {
                        if (to.x - from.x == 0)
                        {
                            return true;
                        }
                        return false;
                    }
                    return (to.x - from.x) * (related.to.y - related.from.y) == -1 * (to.y - from.y) * (related.to.x - related.from.x);
                }
                return true;
            }
        }

        public bool MakeRelation(List<Edge> edges)
        {
            if (IsRelationOk || relation == Relation.NoRelation)
            {
                return true;
            }
            if (edges.Contains(this))
            {
                return false;
            }
            edges.Add(this);
            if (relation == Relation.Equal)
            {
                if (!MakeEqual(edges))
                {
                    return related.MakeEqual(edges);
                }
            }
            if (relation == Relation.Perpendicular)
            {
                if (!MakePerpendicular(edges))
                {
                    return related.MakePerpendicular(edges);
                }
            }
            return true;
        }

        public bool MakeEqual(List<Edge> edges)
        {
            if (related.Lenght == 0 || Lenght == 0)
            {
                return false;
            }
            int tempX = related.to.x;
            int tempY = related.to.y;
            double ratio = Lenght / related.Lenght;
            int dxE2 = related.to.x - related.from.x;
            int dyE2 = related.to.y - related.from.y;
            related.to.x = related.from.x + (int)(dxE2 * ratio);
            related.to.y = related.from.y + (int)(dyE2 * ratio);
            Edge edge = Polygons.l.Find(x => x.verticles.Contains(related.to)).edges.Find(x => x.from == related.to);
            if (this == edge)
            {
                return true;
            }
            if (!edge.MakeRelation(edges))
            {
                related.to.x = tempX;
                related.to.y = tempY;
                return false;
            }
            return true;
        }

        public bool MakePerpendicular(List<Edge> edges)
        {
            if (related.Lenght == 0 || Lenght == 0)
            {
                return false;
            }
            Edge edge = Polygons.l.Find(z => z.verticles.Contains(related.to)).edges.Find(z => z.from == related.to);
            double dx = to.x - from.x;
            double dy = to.y - from.y;
            int tempX = related.to.x;
            int tempY = related.to.y;
            if (dx == 0)
            {
                related.to.y = related.from.y;
                if (this == edge)
                {
                    return true;
                }
                if (!edge.MakeRelation(edges))
                {
                    related.to.y = tempY;
                    return false;
                }
                return true;
            }
            else if (dy == 0)
            {
                related.to.x = related.from.x;
                if (this == edge)
                {
                    return true;
                }
                if (!edge.MakeRelation(edges))
                {
                    related.to.x = tempX;
                    return false;
                }
                return true;
            }
            double a = dy / dx;
            a = -1 / a; //prostopadle
            int x = 20;
            int y = (int)Math.Round(x * a);
            double vectorLen = Math.Sqrt(x * x + y * y);
            double ratio = related.Lenght / vectorLen;
            x = (int)Math.Round(x * ratio);
            y = (int)Math.Round(y * ratio);
            related.to.x = related.from.x + x;
            related.to.y = related.from.y + y;
            if (this == edge)
            {
                return true;
            }
            if (!edge.MakeRelation(edges))
            {
                related.to.x = tempX;
                related.to.y = tempY;
                return false;
            }
            return true;
        }


    }
}
