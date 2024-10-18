using ConsoleApp3.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.servicio
{
    internal static class CuentaBancoServicio
    {
        public static void AgregarBalance(CuentaBanco cuenta,int aumento)
        {
            cuenta.Balance = cuenta.Balance  + aumento;
        }
        public static void RetiroBalance(CuentaBanco cuenta, int aumento)
        {
            cuenta.Balance = cuenta.Balance - aumento;
        }
        public static void Mostrar(CuentaBanco cuenta)
        {
            Console.WriteLine($"#{cuenta.Numero}, Propietario:{cuenta.Propietario}, ${cuenta.Balance}");
        }
    }
}
