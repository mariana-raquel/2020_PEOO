using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
            string[] data = Console.ReadLine().Split('/');
            int dia = int.Parse(data[0]);
            int mes = int.Parse(data[1]);
            int ano = int.Parse(data[2]);
            if (mes == 1)
                Console.WriteLine($"A data é {dia} de janeiro de {ano}");
            if (mes == 2)
                Console.WriteLine($"A data é {dia} de fevereiro de {ano}");
            if (mes == 3)
                Console.WriteLine($"A data é {dia} de março de {ano}");
            if (mes == 4)
                Console.WriteLine($"A data é {dia} de abril de {ano}");
            if (mes == 5)
                Console.WriteLine($"A data é {dia} de maio de {ano}");
            if (mes == 6)
                Console.WriteLine($"A data é {dia} de junho de {ano}");
            if (mes == 7)
                Console.WriteLine($"A data é {dia} de julho de {ano}");
            if (mes == 8)
                Console.WriteLine($"A data é {dia} de agosto de {ano}");
            if (mes == 9)
                Console.WriteLine($"A data é {dia} de setembro de {ano}");
            if (mes == 10)
                Console.WriteLine($"A data é {dia} de outubro de {ano}");
            if (mes == 11)
                Console.WriteLine($"A data é {dia} de novembro de {ano}");
            if (mes == 11)
                Console.WriteLine($"A data é {dia} de dezembro de {ano}");
        }
    }
}
