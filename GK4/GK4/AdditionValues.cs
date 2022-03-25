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

        private void CheckBoxShowLight_Click(object sender, EventArgs e)
        {
            Global.ShowLights = checkBoxShowLight.Checked;
        }

        private void RotateLightCheckBox_Click(object sender, EventArgs e)
        {
            Global.RotateLights = RotateLightCheckBox.Checked;
            pictureBox1.UpdateAll(this, Global, buttonColorPick.BackColor);
        }

        private void TrackBarKs_Scroll(object sender, EventArgs e)
        {
            Global.Ks = trackBarKs.Value;
            pictureBox1.UpdateAll(this, Global, buttonColorPick.BackColor);
        }

        private void TrackBarKd_Scroll(object sender, EventArgs e)
        {
            Global.Kd = trackBarKd.Value;
            pictureBox1.UpdateAll(this, Global, buttonColorPick.BackColor);
        }

        private void TrackBarKa_Scroll(object sender, EventArgs e)
        {
            Global.Ka = trackBarKa.Value;
            pictureBox1.UpdateAll(this, Global, buttonColorPick.BackColor);
        }

        private void TrackBarK_Scroll(object sender, EventArgs e)
        {
            foreach (var s in Global.Objects3D)
            {
                if (s is Sphere)
                {
                    Global.Objects3D.Remove(s);
                    break;
                }
            }
            AddObjects.AddSphere1(this, Global, trackBarK.Value);
            pictureBox1.UpdateAll(this, Global, buttonColorPick.BackColor);
        }

        private void TrackBarN_Scroll(object sender, EventArgs e)
        {
            Global.n = trackBarN.Value;
            pictureBox1.UpdateAll(this, Global, buttonColorPick.BackColor);
        }
    }
}
