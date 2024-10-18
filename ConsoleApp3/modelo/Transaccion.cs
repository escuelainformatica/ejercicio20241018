using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.modelo
{
    internal class Transaccion
    {
        public int Cantidad { set; get; }
        public string Fecha { set; get; }
        public string Descripcion { set; get; }

        public Transaccion()
        {
        }

        public Transaccion(int cantidad, string fecha, string descripcion)
        {
            Cantidad = cantidad;
            Fecha = fecha;
            Descripcion = descripcion;
        }
    }
}
