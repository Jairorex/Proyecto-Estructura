using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras
{
    internal class GrafoAdyacencia
    {

        public int vertice;
        public List<int>[] lista;

        public GrafoAdyacencia(int vertices)
        {
            vertice = vertices;
            lista = new List<int>[vertices];
            for (int i = 0; i < vertices; i++)
            {
                lista[i] = new List<int>();
            }
        }
        public void EliminarVertice(int vertice)
        {
            for (int i = 0; i < this.vertice; i++)
            {
                lista[i].Remove(vertice);
            }
        }

        public void AgregarArista(int origen, int destino)
        {
            lista[origen].Add(destino);
        }

        public bool ValidarVertice(int vertice)
        {
            return vertice >= 0 && vertice < this.vertice;
        }

        public bool Sumidero(int vertice)
        {
            return lista[vertice].Count == 0;
        }



    }
}



