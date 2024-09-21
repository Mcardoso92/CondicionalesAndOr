using System;

namespace EJERCICIO5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si 
            //los mismos se encuentran ordenados de forma decreciente .

            int N1, N2, N3, N4;
            
            Console.WriteLine("Ingrese un Numero: ");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un Numero: ");
            N2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un Numero: ");
            N3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un Numero: ");
            N4 = int.Parse(Console.ReadLine());

            if ((N1 > N2) && (N2 > N3) && (N3 > N4))
                Console.WriteLine("Los numeros si ingresaron de manera decreciente");
            else
                Console.WriteLine("Los numeros estan desordenados");

        }
    }
}
