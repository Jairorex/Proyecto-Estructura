using System;
using Estructuras;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructuras
{
    public partial class Grafo : Form
    {
        private GrafoAdyacencia grafos;
        public Grafo()
        {
            InitializeComponent();
        }
        public int vertice;
        public List<int>[] lista;


        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                int vertices = int.Parse(txtVertice.Text);
                grafos = new GrafoAdyacencia(vertices);
                MessageBox.Show("El Grafo se creo Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Valor no permitido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (grafos == null)
            {
                MessageBox.Show("Grafo no Existe, Cree un Grafo antes de agregar aristas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int origen = int.Parse(txtOrigen.Text);
                int destino = int.Parse(txtDestino.Text);

                if (grafos.ValidarVertice(origen) && grafos.ValidarVertice(destino))
                {
                    grafos.AgregarArista(origen, destino);
                    txtOrigen.Clear();
                    txtDestino.Clear();
                }
                else
                {
                    MessageBox.Show("Vértices no Existe Ingrese Vértices Válidos para la Arista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese números válidos para el origen y el destino.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int verticeAEliminar = int.Parse(txtEliminar.Text);

                if (grafos != null && grafos.ValidarVertice(verticeAEliminar) && grafos.Sumidero(verticeAEliminar))
                {
                    grafos.EliminarVertice(verticeAEliminar);
                    MessageBox.Show($"Se Eliminó la Aristas {verticeAEliminar}   de los demas vertices.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ingrese un vértice válido que sea Sumidero para poder eliminar sus aristas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un número válido para el vértice a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                txtImprimir.Clear();
                int verticeABuscar = int.Parse(txtVerticead.Text);
                BuscarNodoAdyacente(verticeABuscar);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un número válido para el vértice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (grafos == null)
            {
                MessageBox.Show("El Grafo esta Vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Imprimir();
            }
        }
        private void Imprimir()
        {
            txtImprimir.Clear();
            txtImprimir.AppendText("\nResultado del Grafo \n");
            for (int i = 0; i < grafos.vertice; i++)
            {
                txtImprimir.AppendText($"Vertice {i}-->\n");
                foreach (var grafo in grafos.lista[i])
                {
                    txtImprimir.AppendText($"{grafo} \n");
                }
                txtImprimir.AppendText("\n");
            }
        }
        private void BuscarNodoAdyacente(int v)
        {
            if (grafos == null)
            {
                MessageBox.Show("Ingrese un dato para poder mostrar sus nodos adyacentes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (v < 0 || v >= grafos.vertice)
            {
                MessageBox.Show("El dato supera el vertice definido con anterioridad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            txtImprimir.AppendText($"Los Nodos Adyacentes de {v} son \n");
            foreach (var nodo in grafos.lista[v])
            {
                txtImprimir.AppendText($"{nodo}  ");
            }
            txtImprimir.AppendText("\n");
        }



        private void txtVertice_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
        }




    }
}
