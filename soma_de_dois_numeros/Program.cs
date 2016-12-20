using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soma_de_dois_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            //variáveis
            int n1 = 0;
            int n2 = 0;
            int soma = 0;
            Console.Write("Digite o primeiro número: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            soma = n1 + n2;

            Console.Write("A soma dos números é: ");
            Console.Write(soma);

            Console.ReadKey();

        }
    }
}
