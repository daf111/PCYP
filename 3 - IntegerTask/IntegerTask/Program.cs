using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IntegerTask
{
    /// <summary>
    /// Explicar Generic
    /// </summary>
    internal class Program
    {
        private static int Calculo(string cadena, string cadena2)
        {
            return cadena2.Length;
        }

        private static void Main(string[] args)
        {

            /*
            var taskA = Task<int>.Factory.StartNew(
                val => ((string)val).Length, 
                "Parallel Programming in Visual Studio."
                );
            */
            string cadena = "Pepe";
            string cadena2 = "Carlos";
            //var taskA = new Task<int>(val => Calculo((string)val), cadena);
            var taskA = new Task<int>(() => Calculo(cadena, cadena2));
            taskA.Start();

            taskA.Wait();
            Console.WriteLine(taskA.Result);

            Console.WriteLine("Presione enter para salir");
            Console.ReadLine();

        }
    }
}
