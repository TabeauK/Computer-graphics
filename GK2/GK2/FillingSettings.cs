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
        private void RadioButtonInterpol_CheckedChanged(object sender, EventArgs e)
        {
            Grid.fillingType = FillingType.Interpolated;
            Grid.UpdateAllGrid();
        }

        private void RadioButtonFullFilling_CheckedChanged(object sender, EventArgs e)
        {
            Grid.fillingType = FillingType.Standard;
            Grid.UpdateAllGrid();
        }

        private void RadioButtonHybrid_CheckedChanged(object sender, EventArgs e)
        {
            Grid.fillingType = FillingType.Hybrid;
            Grid.UpdateAllGrid();
        }
    }
}
