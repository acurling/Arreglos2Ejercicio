using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // matrices

            int[] notas = new int[4];
            float promedio = 0f;
            int cont = 0;
            //// primera parte:Solicitar las notas y sacar el promedio

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Digite su nota {0}: ", i +1);
                notas[i] = int.Parse(Console.ReadLine());
                promedio += notas[i];
            }
            promedio/=notas.Length;
            Console.WriteLine($"El promedio es de {promedio}");

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i]>promedio)
                {
                    cont++;
                }

            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("**************************************");
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine($"Los estudiantes con notas mayores al promedio son: {cont}");
            Console.ReadLine();
        }
    }
}
