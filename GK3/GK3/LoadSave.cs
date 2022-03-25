using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK3
{
    public partial class Form1 : Form
    {
        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (pictureBox.Tag != null)
            {
                (pictureBox.Tag as Label).Dispose();
                pictureBox.Tag = null;
            }
            if ((e as MouseEventArgs).Button == MouseButtons.Right)
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.Title = "Open Image";
                    dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        var b = new Bitmap(dlg.FileName);
                        pictureBox.Width = b.Width;
                        pictureBox.Height = b.Height;
                        this.Width = b.Width + 20;
                        this.Height = b.Height + 170;
                        pictureBox.Image = b;
                        pictureBox1.Image = b.Clone() as Bitmap;
                        pictureBox.Refresh();
                    }
                }
            else
            {
                Bitmap bitmap = CreateImage(600, 600);
                pictureBox.Width = bitmap.Width;
                pictureBox.Height = bitmap.Height;
                this.Width = bitmap.Width + 20;
                this.Height = bitmap.Height + 170;
                pictureBox.Image = bitmap;
                pictureBox1.Image = bitmap.Clone() as Bitmap;
            }

            BringToFront();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                using (SaveFileDialog savefile = new SaveFileDialog())
                {
                    savefile.FileName = "unknown.txt";
                    savefile.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|TIF files (*.tif)|*.tif|All files (*.*)|*.*";
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        switch (savefile.FileName.Substring(savefile.FileName.Length - 3))
                        {
                            case "jpg":
                                {
                                    pictureBox.Image.Save(savefile.FileName, ImageFormat.Jpeg);
                                    break;
                                }
                            case "bmp":
                                {
                                    pictureBox.Image.Save(savefile.FileName, ImageFormat.Bmp);
                                    break;
                                }
                            case "tif":
                                {
                                    pictureBox.Image.Save(savefile.FileName, ImageFormat.Tiff);
                                    break;
                                }
                            case "png":
                                {
                                    pictureBox.Image.Save(savefile.FileName, ImageFormat.Png);
                                    break;
                                }
                            default:
                                pictureBox.Image.Save(savefile.FileName);
                                break;
                        }
                    }
                }
            }
        }
    }
}
