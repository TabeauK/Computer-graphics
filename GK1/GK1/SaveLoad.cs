using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace GK1
{
    static public partial class Polygons
    {
        static public void SaveJson()
        {
            StringBuilder json = new StringBuilder();
            json.Append("{polygons:[");
            foreach (var elem in l)
            {
                json.Append("{points:[");
                foreach (var elem2 in elem.verticles)
                {
                    json.Append("{x:" + elem2.x.ToString() + ",y:" + elem2.y.ToString() + "}");
                    if(elem2 != elem.verticles.Last())
                    {
                        json.Append(",");
                    }
                }
                json.Append("],relations:[");
                foreach (var elem2 in elem.edges)
                {
                    if (elem2.relation != Relation.NoRelation && elem.edges.Contains(elem2.related))
                    {
                        int index1 = elem.edges.FindIndex(x => x == elem2);
                        int index2 = elem.edges.FindIndex(x => x == elem2.related);
                        int type = elem2.relation == Relation.Equal ? 0 : 2;
                        if (index1 < index2)
                        {
                            json.Append("{e1:" + index1.ToString() + ",e2:" + index2.ToString() + ",type:" + type.ToString() + "}");
                            if (elem2 != elem.edges.Last())
                            {
                                json.Append(",");
                            }
                        }
                    }
                }
                json.Append("]}");
                if (elem != l.Last())
                {
                    json.Append(",");
                }
            }
            json.Append("]}");
            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                Stream myStream;
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog1.OpenFile()) != null)
                    {
                        using (System.IO.StreamWriter writer = new System.IO.StreamWriter(myStream))
                        {
                            writer.WriteLine(json.ToString());
                        }
                        myStream.Close();
                    }
                }
            }
        }

        static public void LoadJson(PictureBox pictureBox)
        {
            var fileContent = string.Empty;
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "txt files (.txt)|*.txt";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var fileStream = dialog.OpenFile();
                    using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            if (fileContent == string.Empty)
            {
                return;
            }
            DisposeLabels();
            l = new List<Poly>();
            var s = fileContent.Split('{', '}');
            s = s.Select(x => x).Where(x => x!="" && x!=" " && x!=",").ToArray();
            int i = 0;
            while (i<s.Length && !s[i].Contains("points"))
            {
                i++;
            }
            while (i < s.Length)
            {
                List<Vertex> list = new List<Vertex>();
                i++;
                while (!s[i].Contains("relations"))
                {
                    var xy = s[i].Split(':', ',');
                    int.TryParse(xy[1], out int x);
                    int.TryParse(xy[3], out int y);
                    list.Add(new Vertex(x, y, 4));
                    i++;
                }
                i++;
                Poly poly = new Poly(2, list.ToArray());
                l.Add(poly);
                while (s[i].Contains("type:"))
                {
                    var er = s[i].Split(',', ':');
                    int.TryParse(er[1], out int e1);
                    int.TryParse(er[3], out int e2);
                    int.TryParse(er[5], out int type);
                    poly.edges[e1].CreateRelation(poly.edges[e2], type == 0 ? Relation.Equal : Relation.Perpendicular, pictureBox);
                    i++;
                }
                while (i < s.Length && !s[i].Contains("points"))
                {
                    i++;
                }
            }
        }
    }
}
