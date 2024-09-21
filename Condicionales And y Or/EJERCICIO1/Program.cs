using System;

namespace EJERCICIO1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite el ingreso de dos números y luego calcular:
            //-La resta si el primero es mayor que el segundo.
            //-La suma si son iguales.
            //-El producto si el primero es menor.
            //Se deberá emitir un cartel por pantalla con el resultado correspondiente.

            int N1 , N2, TOTAL = 0;

            Console.WriteLine("Ingrese un numeros");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            N2 = int.Parse(Console.ReadLine());

            if(N1 > N2){
                TOTAL = N1 - N2;
            }
            if(N1 == N2){
                TOTAL = N1 + N2;
            }
            if(N1 < N2){
                TOTAL = N1 * N2;
            }
            Console.WriteLine("Resultado: " + TOTAL);
        }
    }
}
