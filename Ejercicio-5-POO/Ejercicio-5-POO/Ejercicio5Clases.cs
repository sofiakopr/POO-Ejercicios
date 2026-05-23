using System;

namespace Ejercicio5Clases;

public class Cuenta_Bancaria
{
    protected int montoActual;
    public bool registrado = false;

    public virtual void depositar(int mont)
    {
        if (mont > 0)
        {
            montoActual += mont;
            Console.WriteLine("El monto ha sido depositado.");
        }
        else
        {
            Console.WriteLine("El monto ingresado a depositar es invalido.");
        }
    }
    public virtual bool extraer(int mont)
    {
        if (mont > 0)
        {
            montoActual -= mont;
            Console.WriteLine("Extraccion  exitosa.");
            return true;
        }
        else
        {
            Console.WriteLine("El monto ingresado a retirar es invalido.");
            return false;
        }
    }

    public void mostrarSaldo()
    {
        Console.WriteLine("El saldo actual es:" + montoActual);
    }

}

public class CajaDeAhorro : Cuenta_Bancaria
{
    public override bool extraer(int mont)
    {
        if (mont <= 0)
        {
            Console.WriteLine("El monto ingresado a retirar es invalido.");
            return false;
        }
        if (mont > montoActual)
        {
            Console.WriteLine("Saldo insuficiente, no se puede realizar la operación.");
            return false;
        }
        montoActual -= mont;
        Console.WriteLine("Extraccion realizada.");
        return true;
    }

}

public class CuentaCorriente : Cuenta_Bancaria
{
    private int limiteDescubierto;

    public CuentaCorriente(int descubierto)
    {
        this.limiteDescubierto = descubierto;
    }

    public override bool extraer(int mont)
    {
        if (mont <= 0)
        {
            Console.WriteLine("El monto ingresado a retirar es invalido.");
            return false;
        }

        if (montoActual - mont < -limiteDescubierto)
        {
            Console.WriteLine("Se supera el limite de descubierto. Operacion rechazada.");
            return false;
        }

        montoActual -= mont;
        Console.WriteLine("Extraccion realizada.");
        return true;
    }
}

public class Banco()
{
    private List<Cuenta_Bancaria> cuentas = new List<Cuenta_Bancaria>();

    public void agregarCuenta(Cuenta_Bancaria cuenta)
    {
        cuentas.Add(cuenta);
        cuenta.registrado = true;
        Console.WriteLine("La cuenta ha sido registrada.");
    }

    public void transferir(Cuenta_Bancaria origen, Cuenta_Bancaria destino, int monto)
    {
        if (origen.registrado == true && destino.registrado == true)
        {
            if (monto > 0)
            {
                if (origen.extraer(monto))
                {
                    destino.depositar(monto);
                    Console.WriteLine("Transferencia realizada con exito.");
                }

            }
            else
            {
                Console.WriteLine("El monto ingresado es invalido.");
            }
        }
        else
        {
            Console.WriteLine("Una o ambas cuenta/s no esta/n registrada/s.");
        }
    }
}