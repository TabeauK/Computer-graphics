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
        public Bitmap CreateImage(int w, int h)
        {
            Color[] colors = new Color[27];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    for (int k = 0; k < 3; k++)
                        colors[i * 9 + j * 3 + k] = Color.FromArgb(i * 127, j * 127, k * 127);
            Bitmap p = new Bitmap(w, h);
            double stepW = w / 54;
            double stepH = h / 2;
            for (int i = 0; i < 27; i++)
                for (int j = 0; j < stepW; j++)
                    for (int k = 0; k < h / 2; k++)
                        p.SetPixel((int)(i * stepW + j), k, colors[i]);
            for (int i = 27; i < 54; i++)
            {
                int gray = (int)(colors[i - 27].R * 0.3 + 0.59 * colors[i-27].G + 0.11 * colors[i - 27].B);
                for (int j = 0; j < stepW; j++)
                    for (int k = 0; k < h / 2; k++)
                        p.SetPixel((int)(i * stepW + j), k, Color.FromArgb(gray,gray,gray));
            }
            for (int i = 0; i < 27; i++)
            {
                int oneColor = colors[i].R / 3 + colors[i].G / 3 + colors[i].B / 3;
                for (int j = 0; j < stepW; j++)
                    for (int k = h / 2; k < h; k++)
                        p.SetPixel((int)(i * stepW + j), k, Color.FromArgb(oneColor, oneColor, oneColor));
            }
            for (int i = 27; i < 54; i++)
            {
                int min = Math.Min(colors[i - 27].R, Math.Min(colors[i - 27].G, colors[i - 27].B));
                int max = Math.Max(colors[i - 27].R, Math.Max(colors[i - 27].G, colors[i - 27].B));
                for (int j = 0; j < stepW; j++)
                    for (int k = h / 2; k < h; k++)
                        p.SetPixel((int)(i * stepW + j), k, Color.FromArgb((min + max) / 2, (min + max) / 2, (min + max) / 2));
            }
            return p;
        }
    }
}
