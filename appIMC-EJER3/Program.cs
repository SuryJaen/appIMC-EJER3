using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appIMC_EJER3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================");
            Console.WriteLine("=======INDICE DE MASA CORPORAL====");
            Console.WriteLine("==================================");
            Console.WriteLine("");
            Console.WriteLine("DIGITE EL PESO EN KILOGRAMOS");
            String digito = Console.ReadLine();
            float peso = float.Parse(digito);
            Console.WriteLine("DIGITE SU ALTURA EN METROS");
            String digite = Console.ReadLine();
            float altura = float.Parse(digite);

            double divisor = Math.Pow((altura / 100), 2);

            double calcular = peso / divisor;

            Console.WriteLine("SU INDICE DE MASA CORPORAL ES :" + calcular);

            Console.Read();            


        }
    }
}
