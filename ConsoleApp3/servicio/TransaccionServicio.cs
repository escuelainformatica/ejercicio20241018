using ConsoleApp3.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.servicio
{
    internal class TransaccionServicio
    {
        private static TransaccionServicio singleton=new TransaccionServicio();

        public static TransaccionServicio ObtenerSingleTon()
        {
            return singleton;
        }


        public  void Mostrar(Transaccion tr)
        {
            Console.WriteLine($"#{tr.Descripcion},{tr.Fecha}, ${tr.Cantidad}");
        }
    }
}
