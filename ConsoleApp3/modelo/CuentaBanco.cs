using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.modelo
{
    internal class CuentaBanco
    {
        public int Numero { set; get; }
        public string Propietario { set; get; }
        public int Balance { set; get; }

        public CuentaBanco()
        {
        }

        public CuentaBanco(int numero, string propietario, int balance)
        {
            Numero = numero;
            Propietario = propietario;
            Balance = balance;
        }
    }
}
