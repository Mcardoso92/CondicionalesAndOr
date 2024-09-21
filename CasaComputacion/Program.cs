using System;

namespace EJERCICIO3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Una importante marca de computadoras permite elegir cierta 
            //configuración del equipo a comprar. Para ello existe la siguiente escala de precios:
            //              i5 (1)	    i7 (2)	    i9 (3)
            //8 RAM (1)	    USD 800	    USD 900	    USD 1200
            //16 RAM (2)	USD 900	    USD 1000	USD 1400
            //32 RAM (3)	USD 1000	USD 1400	USD 2000
            //Además, el equipo viene con un disco que permite almacenar 500 GB de información y 
            //que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. 
            //Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, y si extiende 
            //el disco o no (ingresa 1 para extender y 0 para no extender) y calcule y emita por pantalla el 
            //monto de la máquina seleccionada.

            int proc, memo, extender, precio = 0;

            Console.WriteLine("Elija la Opcion de procesador: ");
            Console.WriteLine("I5 = 1");
            Console.WriteLine("I7 = 2");
            Console.WriteLine("I9 = 3");
            proc = int.Parse(Console.ReadLine());

            Console.WriteLine("Elija la Opcion de memoria: ");
            Console.WriteLine("8GB RAM = 1");
            Console.WriteLine("16GB RAM = 2");
            Console.WriteLine("32GB RAM = 3");
            memo = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Extiende disco duro?");
            Console.WriteLine("SI = 1");
            Console.WriteLine("NO = 0");
            extender = int.Parse(Console.ReadLine());

            switch (proc)
            {
                case 1:
                if(memo == 1)
                    precio = 800;
                else if (memo == 2)
                    precio = 900;
                else if (memo == 3)
                    precio = 1000;
                else
                    Console.WriteLine("Opcion incorrecta.");
                break;
                case 2:
                if(memo == 1)
                    precio = 800;
                else if(memo == 2)
                    precio = 900;
                else if(memo == 3)
                    precio = 1000;
                else
                    Console.WriteLine("Opcion incorrecta.");
                break;
                case 3:
                if(memo == 1)
                    precio = 800;
                else if(memo == 2)
                    precio = 900;
                else if(memo == 3)
                    precio = 1000;
                else
                    Console.WriteLine("Opcion incorrecta.");
                break;
                default:
                Console.WriteLine("Las opciones no son correctas");
                break;
            }
            if(extender==1)
                precio +=300;
            
            Console.WriteLine("El precio final es: " + precio);

        }
    }
}
