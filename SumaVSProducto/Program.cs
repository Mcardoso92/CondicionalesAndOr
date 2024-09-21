using System;

namespace EJERCICIO4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio 
            //si la suma de los dos primeros es mayor al producto del segundo con el tercero.

            int N1, N2, N3;
            
            Console.WriteLine("Ingrese un Numero: ");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un Numero: ");
            N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un Numero: ");
            N3 = int.Parse(Console.ReadLine());

            if((N1+N2) > (N2*N3))
                Console.WriteLine("La Suma de num 1 y num 2 es mayor al producto de num 2 y num 3");
            else
                Console.WriteLine("La Suma de num 1 y num 2 'no' es mayor al producto de num 2 y num 3");

        }
    }
}
