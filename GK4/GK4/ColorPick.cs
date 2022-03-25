using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK4
{
    public partial class Form1 : Form
    {
        private void ButtonColorPick_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                buttonColorPick.BackColor = dialog.Color;
                buttonColorPick.ForeColor = Color.FromArgb((dialog.Color.R + 128) % 256, (dialog.Color.G + 128) % 256, (dialog.Color.B + 128) % 256);
                pictureBox1.UpdateAll(this, Global, buttonColorPick.BackColor);
            }
            dialog.Dispose();
        }

        private void StableLightColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                StableLightColorButton.BackColor = dialog.Color;
                StableLightColorButton.ForeColor = Color.FromArgb((dialog.Color.R + 128) % 256, (dialog.Color.G + 128) % 256, (dialog.Color.B + 128) % 256);
                foreach (var elem in Global.Lights)
                    if (elem.parent != null)
                        elem.Color = dialog.Color;
                pictureBox1.UpdateAll(this, Global, buttonColorPick.BackColor);
            }
            dialog.Dispose();
        }

        private void MovingLightColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                MovingLightColorButton.BackColor = dialog.Color;
                MovingLightColorButton.ForeColor = Color.FromArgb((dialog.Color.R + 128) % 256, (dialog.Color.G + 128) % 256, (dialog.Color.B + 128) % 256);
                foreach (var elem in Global.Lights)
                    if (elem.parent == null)
                        elem.Color = dialog.Color;
                pictureBox1.UpdateAll(this, Global, buttonColorPick.BackColor);
            }
            dialog.Dispose();
        }
    }
}
