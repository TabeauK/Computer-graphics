using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK2
{
    public partial class Form1 : Form
    {
        public Grid Grid { get; set; }
        public int W { get; set; }
        public int H { get; set; }
        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel2.AutoScroll = true;
            buttonPickColor.BackColor = Color.Crimson;
            W = pictureBox1.Width;
            H = pictureBox1.Height;
            Grid = new Grid(10, 10, pictureBox1, Color.Crimson);
        }

        private void TextBoxX_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(textBoxX.Text,out int n))
            {
                if (n < 2)
                {
                    errorProviderX.SetError(textBoxX, "Must be greater than 1");
                    return;
                }
                Grid.RowSize = n;
                errorProviderX.SetError(textBoxX, "");
                Grid.Resize();
                return;
            }
            errorProviderX.SetError(textBoxX, "Not a number");
        }

        private void TextBoxY_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxY.Text, out int n))
            {
                if(n<2)
                {
                    errorProviderY.SetError(textBoxY, "Must be greater than 1");
                    return;
                }
                Grid.ColumnSize = n;
                errorProviderY.SetError(textBoxY, "");
                Grid.Resize();
                return;
            }
            errorProviderY.SetError(textBoxY, "Not a number");
        }
    }
}
