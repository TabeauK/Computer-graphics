using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK2
{
    public partial class Form1 : Form
    {
        private void RadioButtonRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRandom.Checked)
            {
                Random r = new Random();
                Grid.M = r.Next() % 101;
                Grid.Ks = r.Next() % 101;
                Grid.Kd = r.Next() % 101;
                trackBarM.Value = (int)Grid.M;
                trackBarKd.Value = (int)Grid.Kd;
                trackBarKs.Value = (int)Grid.Ks;
                Grid.UpdateAllGrid();
            }
        }

        private void RadioButtonCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCustom.Checked)
            {
                trackBarM.Enabled = true;
                trackBarKd.Enabled = true;
                trackBarKs.Enabled = true;
            }
            else
            {
                trackBarM.Enabled = false;
                trackBarKd.Enabled = false;
                trackBarKs.Enabled = false;
            }
        }

        private void TrackBarKd_Scroll(object sender, EventArgs e)
        {
            Grid.Kd = trackBarKd.Value;
            Grid.UpdateAllGrid();
        }

        private void TrackBarKss_Scroll(object sender, EventArgs e)
        {
            Grid.Ks = trackBarKs.Value;
            Grid.UpdateAllGrid();
        }

        private void TrackBarM_Scroll(object sender, EventArgs e)
        {
            Grid.M = trackBarM.Value;
            Grid.UpdateAllGrid();
        }
    }
}
