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
        private void RadioButtonPickColor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPickColor.Checked == true)
            {
                buttonPickColor.Enabled = true;
                Grid.ColorFill = true;
                Grid.UpdateAllGrid();
            }
            else
            {
                buttonPickColor.Enabled = false;
            }
        }

        private void ButtonPickColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Grid.color = dialog.Color;
                buttonPickColor.BackColor = dialog.Color;
                Grid.UpdateAllGrid();
            }
        }

        private void RadioButtonPickFile_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPickFile.Checked == true)
            {
                buttonPickFile.Enabled = true;
                if (Grid.background != null)
                {
                    Grid.ColorFill = false;
                    Grid.UpdateAllGrid();
                }
            }
            else
            {
                buttonPickFile.Enabled = false;
            }
        }

        private void ButtonPickFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Title = "Open Image",
                Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (Bitmap bmp = new Bitmap(dialog.FileName))
                    Grid.background = new DirectBitmap(new Bitmap(bmp, Grid.DB.Width, Grid.DB.Height));
                Grid.ColorFill = false;
                Grid.UpdateAllGrid();
            }
        }
    }
}
