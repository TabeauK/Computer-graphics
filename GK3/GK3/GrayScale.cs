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
        private void ButtonGrayscale_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                current = Version.gray;
                for (int i = 0; i < pictureBox.Image.Width; i++)
                    for (int j = 0; j < pictureBox.Image.Height; j++)
                    {
                        Color c =(pictureBox1.Image as Bitmap).GetPixel(i, j);
                        int gray = (int)(c.R * 0.3 + 0.59 * c.G + 0.11 * c.B);
                        Color newC = Color.FromArgb(gray,gray,gray);
                        (pictureBox.Image as Bitmap).SetPixel(i, j, newC);
                    }
                pictureBox.Refresh();
            }
        }
    }
}
