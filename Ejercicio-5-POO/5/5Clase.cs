using System;

namespace Ejercicio5Clases;

public class Cuenta_Bancaria
{
    public int montoActual;
    public int registrado = 0;

    public int depositar(int mont)
    {
        if (mont > 0)
        {
            return montoActual += mont;
        }
        else
        {
            Console.WriteLine("El monto ingresado a depositar es invalido.");
            return montoActual;
        }
    }
    public int extraer(int mont)
    {
        if (mont > 0)
        {
            return montoActual -= mont;
        }
        else
        {
            Console.WriteLine("El monto ingresado a retirar es invalido.");
            return montoActual;
        }
    }

    public void mostrarSaldo()
    {
        Console.WriteLine("El saldo actual es:" + montoActual);
    }

}

public class CajaDeAhorro : Cuenta_Bancaria
{
    

}

public class CuentaCorriente : Cuenta_Bancaria
{

}

public class Banco()
{
    public void agregarCuenta(Cuenta_Bancaria cuenta)
    {
        cuenta.registrado = 1;
        Console.WriteLine("La cuenta ha sido registrada.");
    }

    public void transferir(Cuenta_Bancaria origen, Cuenta_Bancaria destino, int monto)
    {
        if (origen.registrado == 1 && destino.registrado == 1)
        {
            origen.montoActual -= monto;
            destino.montoActual += monto;
        }
        else
        {
            Console.WriteLine("Una o ambas cuenta/s no esta/n registrada/s.");
        }
    }
}