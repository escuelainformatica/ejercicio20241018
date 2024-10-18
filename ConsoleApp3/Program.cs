using ConsoleApp3.modelo;
using ConsoleApp3.servicio;

var cuenta = new CuentaBanco(1, "john", 4444);
var trans = new Transaccion(5444, "01/01/2010", "giro");
Console.WriteLine("inicial:");
CuentaBancoServicio.Mostrar(cuenta);

CuentaBancoServicio.AgregarBalance(cuenta, 100);
Console.WriteLine("Despues de agregar:");
CuentaBancoServicio.Mostrar(cuenta);

CuentaBancoServicio.RetiroBalance(cuenta, 100);
Console.WriteLine("Despues de retirar:");
CuentaBancoServicio.Mostrar(cuenta);

TransaccionServicio.ObtenerSingleTon().Mostrar(trans);