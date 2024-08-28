using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioDeBusqueda
{
    class ClaseNodo<Tipo>
    {
        private Tipo objetoConDatos;
        public Tipo ObjetoConDatos
        {
            get { return objetoConDatos; }
            set { objetoConDatos = value; }
        }

        private ClaseNodo<Tipo> hijoIzq;
        public ClaseNodo<Tipo> HijoIzq
        {
            get { return hijoIzq; }
            set { hijoIzq = value; }
        }
        private ClaseNodo<Tipo> hijoDer;
        public ClaseNodo<Tipo> HijoDer
        {
            get { return hijoDer; }
            set { hijoDer = value; }
        }
        ~ClaseNodo()
        {
            HijoDer = null;
            hijoIzq = null;
            objetoConDatos = default(Tipo);
        }
    }
}
