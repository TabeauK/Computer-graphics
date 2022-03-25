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

        private void MainPictureBox_SizeChanged(object sender, EventArgs e)
        {
            if (mainPictureBox.Image != null)
            {
                mainPictureBox.Image = new Bitmap(mainPictureBox.Width, mainPictureBox.Height);
                mainPictureBox.DrawAll();
            }
        }


        private void TrackBarE_Scroll(object sender, EventArgs e)
        {
            label1.Text = "Size of edges: " + trackBarE.Value.ToString();
            foreach(var elem in Polygons.l)
            {
                foreach(var elem2 in elem.edges)
                {
                    elem2.boldness = trackBarE.Value;
                }
            }
            Polygons.RefreshEdges();
            mainPictureBox.DrawAll();
            
        }

        private void TrackBarV_Scroll(object sender, EventArgs e)
        {
            label2.Text = "Size of verticles: " + trackBarV.Value.ToString();
            foreach (var elem in Polygons.l)
            {
                foreach (var elem2 in elem.verticles)
                {
                    elem2.boldness = trackBarV.Value;
                }
            }
            mainPictureBox.DrawAll();
        }
    }
}
