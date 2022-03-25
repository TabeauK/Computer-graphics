using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK2
{
    public partial class Form1 : Form
    {
        private void RadioButtonNormalMap_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNormalMap.Checked)
            {
                if(Grid.NormalMap!=null)
                {
                    Grid.UsingNormalMap = true;
                }
                buttonNormalMap.Enabled = true;
            }
            else
            {
                buttonNormalMap.Enabled = false;
            }
        }

        private void RadioButtonConst_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonConst.Checked)
            {
                Grid.UsingNormalMap = false;
                Grid.UpdateAllGrid();
            }
        }

        private void ButtonNormalMap_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Title = "Open Image",
                Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (Bitmap bmp = new Bitmap(dialog.FileName))
                    Grid.NormalMap = new DirectBitmap(new Bitmap(bmp, Grid.DB.Width, Grid.DB.Height));
                Grid.UsingNormalMap = true;
                Grid.UpdateAllGrid();
            }
        }
    }
}
