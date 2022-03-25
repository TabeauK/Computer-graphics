using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK3
{
    public partial class Form1 : Form
    {
        private void ButtonV1_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                current = Version.v1;
                Main(current,pictureBox1.Image as Bitmap, pictureBox.Image as Bitmap, (int)Math.Pow(d,trackBar1.Value));
                pictureBox.Refresh();
            }
        }



        private void ButtonV2_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                current = Version.v2;
                Main(current, pictureBox1.Image as Bitmap, pictureBox.Image as Bitmap, (int)Math.Pow(d, trackBar1.Value));
                pictureBox.Refresh();
            }
        }



        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            buttonV1.Text = $"Reduce to {(int)Math.Pow(d,trackBar1.Value)} colors (v1)";
            buttonV2.Text = $"Reduce to {(int)Math.Pow(d, trackBar1.Value)} colors (v2)";
        }
    }
}
