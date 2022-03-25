using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK1
{
    public partial class GK1 : Form
    {
        private void DeletePolygonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var elem in Polygons.FindFocus().edges)
            {
                if (elem.label != null)
                    elem.label.Dispose();
            }
            Polygons.l.Remove(Polygons.FindFocus());
            mainPictureBox.DrawAll();
            Focuss.Object = null;
        }

        private void DeleteVericleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vertex v = Focuss.Object as Vertex;
            Poly poly = Polygons.FindFocus();
            Edge e1 = poly.edges.Find(x => x.to == v);
            Edge e2 = poly.edges.Find(x => x.from == v);
            e1.DeleteRelation();
            e2.DeleteRelation();
            e1.to = e2.to;
            poly.edges.Remove(e2);
            poly.verticles.Remove(v);
            e1.AddPoints();
            mainPictureBox.DrawAll();
            Focuss.Object = null;
        }

        private void MovePolygonToolStripMenuItemV_Click(object sender, EventArgs e)
        {
            MovingObject.original = Polygons.FindFocus();
            Action.moving = true;
            mainPictureBox.DrawAll();
        }

        private void AddVerticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vertex v = new Vertex(RightClick.x, RightClick.y, trackBarV.Value);
            Edge edge = Focuss.Object as Edge;
            Edge e1 = new Edge(edge.from, v, trackBarE.Value);
            Edge e2 = new Edge(v, edge.to, trackBarE.Value);
            edge.DeleteRelation();
            Poly p = Polygons.FindFocus();
            p.verticles.Add(v);
            p.edges.Add(e1);
            p.edges.Add(e2);
            p.edges.Remove(edge);
            mainPictureBox.DrawAll();
            Focuss.Object = null;
        }
    }
}
