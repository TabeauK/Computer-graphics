using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Shapes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK1
{

    public partial class GK1 : Form
    {
        public GK1()
        {
            InitializeComponent();
            int w = mainPictureBox.Width;
            int h = mainPictureBox.Height;
            trackBarV.Value = 4;
            trackBarE.Value = 2;
            int b = 4;
            Poly poly = new Poly(2, new Vertex(w / 4, h / 4,b), new Vertex(w * 3 / 4, h / 4,b), new Vertex(w * 3 / 4, h * 3 / 4,b), new Vertex(w / 4, h * 3 / 4,b));
            Polygons.l = new List<Poly> { poly };
            poly.edges[0].CreateRelation(poly.edges[1], Relation.Perpendicular,mainPictureBox);
            mainPictureBox.DrawAll();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Polygons.SaveJson();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            Polygons.LoadJson(mainPictureBox);
            mainPictureBox.DrawAll();
        }
    }
}
