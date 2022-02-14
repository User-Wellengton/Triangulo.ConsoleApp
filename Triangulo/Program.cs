using System;

namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string opcao;
            int a, b, c;

            while (true) { 

            Console.WriteLine("Digite 1 para verificar o tipo do triângulo");


            Console.WriteLine("Digite S para sair");

            opcao = Console.ReadLine();

            if (opcao != "1" && opcao != "s")
            {
                Console.WriteLine("Opção inválida, tente novamente");
                Console.ReadLine();
                continue;
            }

            if (opcao == "s")
            {
                break;
            }



            Console.WriteLine("Digite valor para A:");
            a =Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Digite valor para B:");
            b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Digite valor para C:");
            c = Convert.ToInt32(Console.ReadLine());



            if (a > b+c || b > a+c || c > a + b)
            {
                    Console.WriteLine("Triângulo inválido");
                        continue;
                }
             if (a != b && a != c && b != a && b != c)
                {
                    Console.WriteLine("Triângulo ESCALENO.");
                }
                else if (a ==b && a!=c  || b ==c && b!=a || a==c && a != b)
                {
                    Console.WriteLine("Triângulo ISÒCELES.");
                }
                else if(a ==b && b==c && c==a && a == c)
                {
                    Console.WriteLine("Triângulo EQUILÀTERO.");
                }
            



            }




        }


    }
}
