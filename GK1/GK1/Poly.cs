using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GK1
{
    [DataContract]
    public class Poly
    {
        [DataMember]
        public List<Vertex> verticles;
        public List<Edge> edges;
        public Poly()
        {
            edges = new List<Edge>();
            verticles = new List<Vertex>();
        }
        public Poly(int edgeBoldness, params Vertex[] p)
        {
            edges = new List<Edge>();
            verticles = new List<Vertex>();
            foreach (var elem in p)
            {
                verticles.Add(elem);
            }
            for (int i = 0; i < verticles.Count - 1; i++)
            {
                edges.Add(new Edge(verticles[i], verticles[i + 1], edgeBoldness));
            }
            edges.Add(new Edge(verticles[verticles.Count - 1], verticles[0], edgeBoldness));
        }
    }
}
