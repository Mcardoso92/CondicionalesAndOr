using System;

namespace AND_Y_OR
{
    class Program
    {
        static void Main(string[] args)
        {
            //AND Y OR..... NOT
            //AND [y] Operador: &&
            //OR [o] Operador: ||
            //NOT operador: !
            
            int edad = 21;
            char inicial = 'H';
            //AND
            if(edad > 20 && inicial == 'H')
                Console.WriteLine("21 OFF...");
            //OR
            if(edad > 20 || inicial == 'H')
                Console.WriteLine("21 OFF...");
            //COMBINADA
            if(edad > 20 || inicial == 'H' && inicial == 'J')
                Console.WriteLine("21 OFF...");


            

            
        }
    }
}
