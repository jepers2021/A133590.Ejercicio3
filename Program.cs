using System;

namespace A133590.Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 3.");
            Console.WriteLine("El siguiente lee las teclas y finaliza al presionar la tecla \"x\".");
            while (Console.ReadKey().Key != ConsoleKey.X)
            {

            }
            Console.WriteLine("Presione cualquier tecla para salir..");
            Console.ReadKey();
        }
    }
}
