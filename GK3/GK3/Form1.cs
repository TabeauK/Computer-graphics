using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK3
{
    public partial class Form1 : Form
    {
        public enum Version {none ,v1, v2, gray}
        Version current;
        double d;
        public Form1()
        {
            d = 1.2;
            current = Version.none;
            InitializeComponent();
            buttonV1.Text = $"Reduce to {(int)Math.Pow(d, trackBar1.Value)} colors (v1)";
            buttonV2.Text = $"Reduce to {(int)Math.Pow(d, trackBar1.Value)} colors (v2)";

            Label label = new Label()
            {
                Text = $"Right click here to add photo, left click here to add photo from lab",
                TextAlign = ContentAlignment.MiddleCenter,
                Width = this.Width,
                Height = this.Height-200,
                Parent = pictureBox
            };
            pictureBox.Tag = label;
            label.Click += PictureBox_Click;
            Controls.Add(label);
            label.BringToFront();
        }
    }
}
