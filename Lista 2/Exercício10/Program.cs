using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício10
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
            if (ano >= 1900 && ano <= 2100 && mes == 1 && dia > 0 && dia <= 31 ||
                ano >= 1900 && ano <= 2100 && mes == 2 && dia > 0 && dia <= 28 ||
                ano >= 1900 && ano <= 2100 && mes == 3 && dia > 0 && dia <= 31 ||
                ano >= 1900 && ano <= 2100 && mes == 4 && dia > 0 && dia <= 30 ||
                ano >= 1900 && ano <= 2100 && mes == 5 && dia > 0 && dia <= 31 ||
                ano >= 1900 && ano <= 2100 && mes == 6 && dia > 0 && dia <= 30 ||
                ano >= 1900 && ano <= 2100 && mes == 7 && dia > 0 && dia <= 31 ||
                ano >= 1900 && ano <= 2100 && mes == 8 && dia > 0 && dia <= 31 ||
                ano >= 1900 && ano <= 2100 && mes == 9 && dia > 0 && dia <= 30 ||
                ano >= 1900 && ano <= 2100 && mes == 10 && dia > 0 && dia <= 31 ||
                ano >= 1900 && ano <= 2100 && mes == 11 && dia > 0 && dia <= 30 ||
                ano >= 1900 && ano <= 2100 && mes == 12 && dia > 0 && dia <= 31)
                Console.WriteLine("A data informada é válida");
            else Console.WriteLine("A data informada não é válida");
        }
    }
}
