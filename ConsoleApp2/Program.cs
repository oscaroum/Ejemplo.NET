using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{ 
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Wirteline("Hola MUNDO!!!")
            int num1 = 5;
            int nuero2 = 6;
            double numero3 = 2.57;
            double suma;
            suma = num1 + numero3;

            Console.WriteLine(suma);
            string valor1 = Console.ReadLine();
            Console.WriteLine("El núnero introducido es: " + valor1);
            int valorint = Convert.ToInt32(valor1);
            Console.ReadKey();
        }
    }
}
