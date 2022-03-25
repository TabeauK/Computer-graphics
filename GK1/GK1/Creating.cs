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
        private void MainPictureBox_Click(object sender, EventArgs e)
        {
            if (Focuss.Object == null && (e as MouseEventArgs).Button == MouseButtons.Left && !Action.moving && !Action.relating)
            {
                if (!Action.creating)
                {
                    mainPictureBox.MouseMove -= MainPictureBox_MouseMove;
                    mainPictureBox.MouseMove += MainPictureBox_MouseMoveCreating;
                    Action.creating = true;
                    CreatingPolygon.l = new List<Vertex> { new Vertex((e as MouseEventArgs).X, (e as MouseEventArgs).Y, trackBarV.Value) };
                    (mainPictureBox.Image as Bitmap).DrawVerticle(CreatingPolygon.l[0], Color.Black);
                    CreatingPolygon.map = (mainPictureBox.Image as Bitmap).Clone() as Bitmap;
                }
                else
                {
                    Vertex v = new Vertex((e as MouseEventArgs).X, (e as MouseEventArgs).Y,trackBarV.Value);
                    if (v.Same(CreatingPolygon.l[0]))
                    {
                        Action.creating = false;
                        var t = new Poly(trackBarE.Value, CreatingPolygon.l.ToArray());
                        Polygons.l.Add(t);
                        mainPictureBox.DrawAll();
                        mainPictureBox.MouseMove -= MainPictureBox_MouseMoveCreating;
                        mainPictureBox.MouseMove += MainPictureBox_MouseMove;
                        return;
                    }
                    else
                    {
                        (mainPictureBox.Image as Bitmap).DrawVerticle(v, Color.Black);
                        CreatingPolygon.map = (mainPictureBox.Image as Bitmap).Clone() as Bitmap;
                        CreatingPolygon.l.Add(v);
                    }
                }
            }
        }

        private void MainPictureBox_MouseMoveCreating(object sender, MouseEventArgs e)
        {
            Bitmap temp = CreatingPolygon.map.Clone() as Bitmap;
            temp.DrawLine(CreatingPolygon.l.Last(), new Vertex(e.X, e.Y, trackBarV.Value), Color.Black);
            mainPictureBox.Image = temp;
        }
    }
}
