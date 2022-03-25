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
        private void MainPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (Poly poly in Polygons.l)
            {
                foreach (Vertex v in poly.verticles)
                {
                    if (FocusSearch(v,(e.X, e.Y)))
                    {
                        mainPictureBox.ContextMenuStrip = contextMenuStripV;
                        return;
                    }
                }
                foreach (Edge edge in poly.edges)
                {
                    if(FocusSearch(edge,(e.X,e.Y)))
                    {
                        mainPictureBox.ContextMenuStrip = contextMenuStripE;
                        return;
                    }
                }
            }
            (mainPictureBox.Image as Bitmap).DrawObject(Focuss.Object);
            mainPictureBox.Refresh();
            mainPictureBox.ContextMenuStrip = null;
            Focuss.Object = null;
        }

        public bool FocusSearch(ObjectOnBitmap v, (int X,int Y) e)
        {
            foreach (var (x, y) in v.bolding)
            {
                if (e.X == x && e.Y == y)
                {
                    if (Focuss.Object != null)
                    {
                        (mainPictureBox.Image as Bitmap).DrawObject(Focuss.Object);
                    }
                    Focuss.Object = v;
                    mainPictureBox.ContextMenuStrip = contextMenuStripV;
                    if (!Action.moving)
                    {
                        (mainPictureBox.Image as Bitmap).DrawObjectColor(v, Color.Red);
                    }
                    mainPictureBox.Refresh();
                    return true;
                }
            }
            return false;
        }
    }
}
