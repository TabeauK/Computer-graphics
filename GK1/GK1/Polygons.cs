using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;

namespace GK1
{
    [DataContract]
    static public partial class Polygons
    {
        [DataMember]
        static public List<Poly> l;
        static public Poly FindFocus()
        {
            return l.Find(x => x.edges.Contains(Focuss.Object) || x.verticles.Contains(Focuss.Object));
        }
        static public void RefreshEdges()
        {
            foreach (var elem in l)
            {
                foreach (var elem2 in elem.edges)
                {
                    elem2.AddPoints();
                }
            }
        }

        static public void UpdateLabels()
        {
            foreach (var elem in l)
            {
                foreach (var elem2 in elem.edges)
                {
                    if (elem2.label != null)
                        elem2.label.Location = new Point((elem2.from.x + elem2.to.x + elem2.boldness * 4) / 2, (4 * elem2.boldness + elem2.from.y + elem2.to.y) / 2);
                }
            }
        }

        static public void DisposeLabels()
        {
            foreach (var elem in l)
            {
                foreach (var elem2 in elem.edges)
                {
                    if (elem2.label != null)
                        elem2.label.Dispose();
                }
            }
        }
    }
}
