using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK1
{
    public partial class Edge : ObjectOnBitmap
    {
        public Vertex from;
        public Vertex to;
        public Relation relation;
        public Edge related;
        public Label label;
        public Edge(Vertex x, Vertex y, int EdgeBoldness, Relation r = Relation.NoRelation, Edge rel = null, Label l = null)
        {
            bolding = new List<(int x, int y)>();
            from = x;
            to = y;
            relation = r;
            related = rel;
            label = l;
            boldness = EdgeBoldness;
            AddPoints();
        }
        public void AddPoints()
        {
            bolding.Clear();
            int x1 = this.to.x;
            int x0 = this.from.x;
            int y1 = this.to.y;
            int y0 = this.from.y;
            int dx = Math.Abs(x1 - x0), sx = x0 < x1 ? 1 : -1;
            int dy = Math.Abs(y1 - y0), sy = y0 < y1 ? 1 : -1;
            int err = (dx > dy ? dx : -dy) / 2, e2;
            for (; ; )
            {
                if (Math.Abs(from.x - to.x) > Math.Abs(from.y - to.y))
                {
                    for (int i = -boldness; i <= boldness; i++)
                    {
                        bolding.Add((x0, y0 + i));
                    }
                }
                else
                {
                    for (int i = -boldness; i <= boldness; i++)
                    {
                        bolding.Add((x0 + i, y0));
                    }
                }
                if (x0 == x1 && y0 == y1)
                    break;
                e2 = err;
                if (e2 > -dx) { err -= dy; x0 += sx; }
                if (e2 < dy) { err += dx; y0 += sy; }
            }
            return;
        }

        public Label CreateLabel(int i)
        {
            var c = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            Label label = new Label
            {
                Text = relation.ToString()[0].ToString(),
                Location = new Point((from.x + to.x + boldness * 4) / 2, (4 * boldness + from.y + to.y) / 2),
                Size = new Size(20, 20),
                Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.FromKnownColor(c[i]),
                ForeColor = Color.FromArgb(255 - Color.FromKnownColor(c[i]).R, 255 - Color.FromKnownColor(c[i]).G, 255 - Color.FromKnownColor(c[i]).B)
            };
            label.BringToFront();
            this.label = label;
            return label;
        }

        public double Lenght
        {
            get
            {
                int lenX = (from.x - to.x) * (from.x - to.x);
                int lenY = (from.y - to.y) * (from.y - to.y);
                return Math.Sqrt(lenX + lenY);
            }
        }

        public void CreateRelation(Edge e1, Relation rel, PictureBox box)
        {
            Random r = new Random();
            int i = r.Next() % 30;
            relation = rel;
            related = e1;
            e1.related = this;
            related.relation = rel;
            CreateLabel(i);
            box.Controls.Add(label);
            if (!MakeRelation(new List<Edge>()))
            {
                DeleteRelation();
                Action.relating = false;
                return;
            }
            e1.CreateLabel(i);
            box.Controls.Add(e1.label);
            Polygons.UpdateLabels();
        }

        public void DeleteRelation()
        {
            if (relation == Relation.NoRelation)
            {
                return;
            }
            relation = Relation.NoRelation;
            related.relation = Relation.NoRelation;
            related.label.SendToBack();
            related.label.Dispose();
            related.label = null;
            related.related = null;
            related = null;
            if (label != null)
            {
                label.SendToBack();
                label.Dispose();
                label = null;
            }
        }

    }
}
