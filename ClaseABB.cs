using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioDeBusqueda
{
    class ClaseABB<Tipo> where Tipo: IEquatable<Tipo>, IComparable<Tipo>
    {
        private ClaseNodo<Tipo> raiz;
        public ClaseNodo<Tipo> Raiz
        {
            get { return raiz; }
            private set { raiz = value; }
        }

        public ClaseABB()
        {
            Raiz = null;
        }

        public bool Vacio
        {
            get
            {
                if(Raiz == null) {return true;}
                return false;
            }
        }

        public void AgregarNodo(Tipo objeto)
        {
            ClaseNodo<Tipo> NodoNuevo = new ClaseNodo<Tipo>();
            NodoNuevo.ObjetoConDatos = objeto;
            if (Vacio)
            {
                Raiz = NodoNuevo;
            }
            else
            {
                AgregarNodo(Raiz, NodoNuevo);
            }
        }

        private void AgregarNodo(ClaseNodo<Tipo> nodoActual, ClaseNodo<Tipo> nodoNuevo)
        {
            if (nodoNuevo.ObjetoConDatos.CompareTo(nodoActual.ObjetoConDatos) == 1)
            {
                if (nodoActual.HijoDer == null)
                {
                    nodoActual.HijoDer = nodoNuevo;
                }
                else
                {
                    AgregarNodo(nodoActual.HijoDer, nodoNuevo);
                }
            }
            else if (nodoNuevo.ObjetoConDatos.CompareTo(nodoActual.ObjetoConDatos) == -1)
            {
                if (nodoActual.HijoIzq == null)
                {
                    nodoActual.HijoIzq = nodoNuevo;
                }
                else
                {
                    AgregarNodo(nodoActual.HijoIzq, nodoNuevo);
                }
            }
            else
            {
                throw new Exception("No se permiten duplicados");
            }
        }

        public void EliminarNodo(Tipo objeto)
        {

        }

        public void BuscarNodo(Tipo objeto)
        {

        }
    }
}
