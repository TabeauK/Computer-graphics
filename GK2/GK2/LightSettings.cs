using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace GK2
{
    public partial class Form1 : Form
    {
        private void ButtonLightColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Grid.lightColor = dialog.Color;
                buttonLightColor.BackColor = dialog.Color;
                Grid.UpdateAllGrid();
            }
        }

        private void RadioButtonLightVector_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLightVector.Checked == true)
            {
                Grid.LightVersor = new Vector3D(0, 0, 1);
                Grid.UpdateAllGrid();
            }
        }

        private void RadioButtonLightAnimate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLightAnimate.Checked)
            {
                timerAnimation.Start();
                Time = 0;
            }
            else
            {
                timerAnimation.Stop();
            }
        }
    }
}
