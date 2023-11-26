using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructuras
{
    public partial class Arbol : Form
    {
        private Nodo raiz;
        private class Nodo
        {
            public int dato;
            public Nodo Izquierda;
            public Nodo Derecha;
            public Nodo(int dato, Nodo izquierda, Nodo derecha)
            {
                this.dato = dato;
                Izquierda = izquierda;
                Derecha = derecha;
            }
        }
        public Arbol()
        {
            InitializeComponent();
            raiz = null;

        }

        private void CrearNodo(ref Nodo q, int dato)
        {
            q = new Nodo(dato, q, q);
            q.Izquierda = null;
            q.Derecha = null;
        }
        private void InsertarNodo(ref Nodo r, int dato)
        {
            Nodo t1 = null, t2 = null, t = null;
            if (r == null)
            {
                CrearNodo(ref r, dato);
            }
            else
            {
                t1 = t2 = r;
                while (t1 != null)
                {
                    t2 = t1;
                    if (dato < t2.dato)
                        t1 = t2.Izquierda;
                    else
                        t1 = t2.Derecha;
                }
                CrearNodo(ref t, dato);
                if (dato < t2.dato)
                    t2.Izquierda = t;
                else
                    t2.Derecha = t;
            }
        }
        private bool BuscarNodo(Nodo nodo, int dato)
        {
            if (nodo == null)
                return false;

            if (nodo.dato == dato)
                return true;
            else if (dato < nodo.dato)
                return BuscarNodo(nodo.Izquierda, dato);
            else
                return BuscarNodo(nodo.Derecha, dato);
        }


        private int Buscarmenor(Nodo nodo)
        {
            //nos aseguramos que el dato izquierdo siguiente no sea null y leugo comparamos los datos izquierdos siguientes con el dato actual en el que estamos 
            if (nodo.Izquierda != null && nodo.Izquierda.dato < nodo.dato)
            {
                return Buscarmenor(nodo.Izquierda);//si el dato siguiente es menor que el actual en el que estamos pasamos a ese dato siguiente recursivamente.
            }
            else
            {
                return nodo.dato;//una vez encontrado el dato lo retornamos
            }
        }

        private void Eliminarmenor(ref Nodo nodo, int menor)
        {
            if (nodo.dato == menor)//buscamos el dato hasta que sea igual que el de la variable menor
            {
                nodo = null;//eliminamos el nodo menor
                return;
            }
            else
                Eliminarmenor(ref nodo.Izquierda, menor);//lo buscamos recursivamente hasta que lo encontremos
        }

        private void Imprimir(Nodo nodo)
        {
            if (nodo != null)
            {
                Imprimir(nodo.Izquierda);
                Console.WriteLine("{0}", nodo.dato);
                Imprimir(nodo.Derecha);
            }
        }



       
        private int dato()
        {
            if (txtDato != null && !string.IsNullOrWhiteSpace(txtDato.Text) && int.TryParse(txtDato.Text, out int dato))
                return dato;

            return 0;
        }
        private void Imprimirtxt(Nodo nodo, int n)
        {
            if (nodo != null)
            {
                Imprimirtxt(nodo.Izquierda, n + 1);
                string espacio = new string(' ', n + 2);
                txtArbol.AppendText($"{espacio}{nodo.dato}\n");
                Imprimirtxt(nodo.Derecha, n + 1);
            }
        }
        private void Actualizar()
        {
            txtArbol.Clear();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int valor = dato();
            if (string.IsNullOrEmpty(txtDato.Text))
            {
                MessageBox.Show("Introduzca un valor valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                InsertarNodo(ref raiz, valor);
                Actualizar();
                txtDato.Clear();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (raiz != null)
            {
                int datom = Buscarmenor(raiz);
                Eliminarmenor(ref raiz, datom);
                MessageBox.Show($"El Dato menor es {datom} y se a Eliminado.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Actualizar();
            }
            else
            {
                MessageBox.Show("El árbol está Vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnImp_Click(object sender, EventArgs e)
        {
            int valor = dato();
            if (string.IsNullOrEmpty(txtDato.Text))
            {
                MessageBox.Show("El Arbol esta Vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Imprimirtxt(raiz, 0);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int datoB = dato();
            if (string.IsNullOrEmpty(txtDato.Text))
            {
                MessageBox.Show("Introduzca un valor valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (BuscarNodo(raiz, datoB))
                {
                    MessageBox.Show($"El dato {datoB} se encuentra en el árbol.", "Resultado de la búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"El dato {datoB} no se encuentra en el árbol.", "Resultado de la búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }



        private void txtDato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtArbol_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


    }

}
