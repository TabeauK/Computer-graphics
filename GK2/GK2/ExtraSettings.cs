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
        double Time;
        private void TimerAnimation_Tick(object sender, EventArgs e)
        {
            Time += 0.1;
            Grid.LightVersor.X = Math.Cos(Time);
            Grid.LightVersor.Y = Math.Sin(Time);
            Grid.LightVersor.Z = 1;
            Grid.LightVersor = Grid.LightVersor / Grid.LightVersor.Length;
            Grid.UpdateAllGrid();
        }
        private void CheckBoxNet_CheckedChanged(object sender, EventArgs e)
        {
            Grid.EditingNet = !checkBoxNet.Checked;
            Grid.UpdateAllGrid();
        }
    }
}
