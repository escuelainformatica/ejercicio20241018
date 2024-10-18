# ejercicio20241018

## modelo

```csharp
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
```
## servicio

```csharp
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
```

