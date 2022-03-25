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
        public bool MoveVectorEdge(int vectorX, int vectorY, Vertex v1, Vertex v2)
        {
            Poly poly = Polygons.l.Find(x => x.verticles.Contains(v1));
            Edge e2 = poly.edges.Find(x => x.from == v1);
            Edge e1 = poly.edges.Find(x => x.to == v1);
            Edge e3 = poly.edges.Find(x => x.from == v2);
            var l = new List<Edge>();
            v1.x += vectorX;
            v1.y += vectorY;
            v2.x += vectorX;
            v2.y += vectorY;
            bool temp;
            if (e1.related == e3 || e2.related == e3)
            {
                temp = e1.MakeRelation(l) && e2.MakeRelation(l);
            }
            else if (e1.related == e2)
            {
                temp = e1.MakeRelation(l) && e3.MakeRelation(l);
            }
            else
            {
                temp = e1.MakeRelation(l) && e2.MakeRelation(l) && e3.MakeRelation(l);
            }
            if (!temp)
            {
                v1.x -= vectorX;
                v1.y -= vectorY;
                v2.x -= vectorX;
                v2.y -= vectorY;
                return false;
            }
            return true;
        }

        public bool MoveVectorVertex(int vectorX, int vectorY, Vertex v)
        {
            Poly poly = Polygons.l.Find(x => x.verticles.Contains(v));
            Edge e1 = poly.edges.Find(x => x.to == v);
            Edge e2 = poly.edges.Find(x => x.from == v);
            var l = new List<Edge>();
            v.x += vectorX;
            v.y += vectorY;
            bool temp;
            if (e1.related != e2)
            {
                temp = e2.MakeRelation(l) && e1.MakeRelation(l);
            }
            else
            {
                temp = e1.MakeRelation(l);
            }
            if (!temp)
            {
                v.x -= vectorX;
                v.y -= vectorY;
                return false;
            }
            return true;
        }


        private void MainPictureBox_MouseMovingObject(object sender, MouseEventArgs e)
        {
            bool moved = true;
            if (Action.moving)
            {
                foreach (Vertex v in MovingObject.original.verticles)
                {
                    v.x += e.X - MovingObject.startX;
                    v.y += e.Y - MovingObject.startY;
                }
            }
            else if (Focuss.Object is Edge)
            {
                moved = MoveVectorEdge(e.X - MovingObject.startX, e.Y - MovingObject.startY, (Focuss.Object as Edge).from, (Focuss.Object as Edge).to);
            }
            else
            {
                moved = MoveVectorVertex(e.X - MovingObject.startX, e.Y - MovingObject.startY, Focuss.Object as Vertex);
            }
            if (!moved) return;
            MovingObject.startX = e.X;
            MovingObject.startY = e.Y;
            Bitmap map = new Bitmap(mainPictureBox.Image.Width, mainPictureBox.Image.Height);
            foreach (var elem in Polygons.l)
            {
                foreach (var elem2 in elem.edges)
                {
                    map.DrawLine(elem2.from, elem2.to, Color.Black);
                }
            }
            Polygons.UpdateLabels();
            mainPictureBox.Image = map;
        }


        private void MainPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                RightClick.x = e.X;
                RightClick.y = e.Y;
                return;
            }
            if (Focuss.Object != null)
            {
                mainPictureBox.Cursor = Cursors.Cross;
                mainPictureBox.MouseMove -= MainPictureBox_MouseMove;
                MovingObject.startX = e.X;
                MovingObject.startY = e.Y;
                mainPictureBox.MouseMove += MainPictureBox_MouseMovingObject;
            }
        }

        private void MainPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (Focuss.Object != null && (e as MouseEventArgs).Button == MouseButtons.Left)
            {
                mainPictureBox.Cursor = Cursors.Default;
                Polygons.RefreshEdges();
                if (Action.moving)
                {
                    Action.moving = false;
                }
                Bitmap map = new Bitmap(mainPictureBox.Image.Width, mainPictureBox.Image.Height);
                mainPictureBox.DrawAll();
                mainPictureBox.MouseMove -= MainPictureBox_MouseMovingObject;
                mainPictureBox.MouseMove += MainPictureBox_MouseMove;
            }
        }
    }
}