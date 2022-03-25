using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK1
{
    public partial class GK1 : Form
    {
        public void MoveLabel(Edge e)
        {
            if (e.relation != Relation.NoRelation)
            {
                e.label.Location = new Point((e.from.x + e.to.x + trackBarE.Value * 4) / 2, (e.from.y + e.to.y + trackBarE.Value * 4) / 2);
            }
        }

        private void DeleteRelationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (Focuss.Object as Edge).DeleteRelation();
        }

        private void ContextMenuStripE_Opening(object sender, CancelEventArgs e)
        {
            if ((Focuss.Object as Edge).relation == Relation.NoRelation)
            {
                addRelationToolStripMenuItem1.Visible = true;
                deleteRelationToolStripMenuItem.Visible = false;
            }
            else
            {
                addRelationToolStripMenuItem1.Visible = false;
                deleteRelationToolStripMenuItem.Visible = true;
            }
        }

        private void EqualEdgesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelationClicked(Relation.Equal);
        }

        private void PerpendicularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelationClicked(Relation.Perpendicular);
        }

        public void RelationClicked(Relation r)
        {
            Action.relating = true;
            CreatingRelation.edge = Focuss.Object as Edge;
            CreatingRelation.relation = r;
            mainPictureBox.DrawAll();
            mainPictureBox.MouseDown -= MainPictureBox_MouseDown;
            mainPictureBox.MouseUp -= MainPictureBox_MouseUp;
            mainPictureBox.MouseDown += MainPictureBox_MouseDownR;
            mainPictureBox.MouseUp += MainPictureBox_MouseUpR;
        }



        private void MainPictureBox_MouseDownR(object sender, MouseEventArgs e)
        {
            if (Focuss.Object is Edge edge && edge != CreatingRelation.edge && edge.relation == Relation.NoRelation)
            {
                CreatingRelation.edge.CreateRelation(edge, CreatingRelation.relation, mainPictureBox);
            }
        }

        private void MainPictureBox_MouseUpR(object sender, MouseEventArgs e)
        {
            if (CreatingRelation.edge.related != null || !Action.relating)
            {
                Action.relating = false;
                mainPictureBox.MouseDown -= MainPictureBox_MouseDownR;
                mainPictureBox.MouseUp -= MainPictureBox_MouseUpR;
                mainPictureBox.MouseDown += MainPictureBox_MouseDown;
                mainPictureBox.MouseUp += MainPictureBox_MouseUp;
                mainPictureBox.DrawAll();
            }
        }
    }
}
