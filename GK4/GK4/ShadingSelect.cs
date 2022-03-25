using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK4
{
    public partial class Form1 : Form
    {
        private void RadioButtonGouraud_Click(object sender, EventArgs e)
        {
            Global.Shading = Shading.Gourauds;
            pictureBox1.UpdateAll(this, Global, buttonColorPick.BackColor);
        }

        private void RadioButtonPhong_Click(object sender, EventArgs e)
        {
            Global.Shading = Shading.Phongs;
            pictureBox1.UpdateAll(this, Global, buttonColorPick.BackColor);
        }

        private void RadioButtonNormal_Click(object sender, EventArgs e)
        {
            Global.Shading = Shading.Normal;
            pictureBox1.UpdateAll(this, Global, buttonColorPick.BackColor);
        }
    }
}
