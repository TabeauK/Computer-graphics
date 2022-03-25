using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace GK4
{
    public partial class Form1 : Form
    {
        Global Global;

        public Form1()
        {
            InitializeComponent();
            Global = new Global()
            {
                Objects3D = new List<IObject3D>(),
                Lights = new List<LightSource>(),
                Shading = Shading.Normal,
                Moving = false,
                RotationCounter = 0,
                V = new Vector3(0, 0, 1),
                Ka = 5,
                Ks = 5,
                Kd = 5,
                n = 1,
                RotateLights = false,
                ShowLights = false
            };
            AddObjects.Script(this, Global,3);
            Global.RPolyhedron = Global.Objects3D.First(x => x is RotatingPolyhedron) as RotatingPolyhedron;
            Global.Lights.Add(new LightSource(new Vector4(0, -1, 1, 1), Color.White));

            pictureBox1.UpdateAll(this, Global, buttonColorPick.BackColor);
        }


    }
}
