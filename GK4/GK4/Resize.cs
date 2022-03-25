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
        private void Form1_Resize(object sender, EventArgs e)
        {
            if(Global!=null)
            pictureBox1.UpdateAll(this,Global, buttonColorPick.BackColor);
        }
    }
}
