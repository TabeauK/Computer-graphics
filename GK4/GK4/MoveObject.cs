using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK4
{
    public partial class Form1 : Form
    {
        private void CheckBoxMove_CheckedChanged(object sender, EventArgs e)
        {
            bool cond = checkBoxMoveX.Checked || checkBoxMoveY.Checked || checkBoxMoveZ.Checked || checkBoxRotate.Checked;
            if (cond)
            {
                timerMove.Start();
                radioButtonCamera3.Enabled = true;
            }
            else
            {
                timerMove.Stop();
                radioButtonCamera3.Enabled = false;
                if (radioButtonCamera3.Checked)
                {
                    radioButtonCamera3.Checked = false;
                    radioButtonCamera1.Checked = true;
                }
            }
        }

        private void TimerMove1_Tick(object sender, EventArgs e)
        {
            Global.RotationCounter += 1;
            if (Global.RotationCounter == 200)
                Global.RotationCounter = 0;
            List<Vertex> list = new List<Vertex>();
            if (radioButtonCamera3.Checked)
            {
                foreach (var elem in Global.Objects3D)
                {
                    if (elem is Sphere)
                    {
                        list.Add((elem as Sphere).Center);
                        foreach (var elem2 in (elem as Sphere).Relations)
                            foreach (var v in elem2.vertices)
                                if (!list.Contains(v))
                                    list.Add(v);
                    }
                    else if (!(elem is RotatingPolyhedron))
                    {
                        list.Add((elem as Polyhedron).Center);
                        foreach (var elem2 in (elem as Polyhedron).Relations)
                            foreach (var v in elem2.vertices)
                                if (!list.Contains(v))
                                    list.Add(v);
                    }
                }
            }
            else
            {
                list.Add(Global.RPolyhedron.Center);
                foreach (var r in Global.RPolyhedron.Relations)
                {
                    if (r is RelationWithLight)
                    {
                        MoveVertex((r as RelationWithLight).Light);
                    }
                    foreach (var v in r.vertices)
                    {
                        if (!list.Contains(v))
                            list.Add(v);
                    }
                }
            }
            foreach (var v in list)
            {
                MoveVertex(v);
            }
            pictureBox1.UpdateAll(this, Global, buttonColorPick.BackColor);
        }
    }
}
