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
        float alpha = 0;

        private void RadioButtonCamera2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCamera2.Checked)
            {
                timerCamera.Start();
            }
            else
            {
                timerCamera.Stop();
            }
            RotateLightCheckBox.Enabled = radioButtonCamera2.Checked;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            alpha += 0.02f;
            pictureBox1.UpdateAll(this,Global, buttonColorPick.BackColor);
        }

        private void TrackBarFOV_Scroll(object sender, EventArgs e)
        {
            pictureBox1.UpdateAll(this,Global, buttonColorPick.BackColor);
        }


        private void RadioButtonCamera3_CheckedChanged(object sender, EventArgs e) //help
        {
            
        }
    }
}
