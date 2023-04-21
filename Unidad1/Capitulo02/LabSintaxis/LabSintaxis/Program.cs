using System;

namespace LabSintaxisCap02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un texto");
            String inputTexto = Console.ReadLine();


            if (inputTexto == string.Empty) {
           
                    Console.WriteLine("No se ingreso un tipo de dato String");
               
            }
            else
            {
                Console.WriteLine("Ingrese un numero de opcion");
                Console.WriteLine("1. Para mostrar la frase en Mayuscula");
                Console.WriteLine("2. Para mostrar la frase en Minuscula");
                Console.WriteLine("3. Mostrar la cantidad de caracteres");
                
                ConsoleKeyInfo key = Console.ReadKey();
                string opcion = Console.ReadLine();
                int opc;
                if (opcion == "1")
                {
                    opc = 1;
                }else if (opcion == "2")
                {
                    opc= 2;

                }else if(opcion == "3")
                {
                    opc = 3;
                }
            }
            Console.WriteLine(inputTexto);
        }
    }
}

