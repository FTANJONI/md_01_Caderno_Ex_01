using System;

namespace md01_CadernoExercicios_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Faça um algoritmo para calcular a área de uma circunferência, considerando a fórmula ÁREA = π *
            RAIO2
            Utilize as variáveis AREA e RAIO, a constante π (pi = 3,14159) e os operadores aritméticos de
            multiplicação.
            */
            double area , raio, pi = 3.14159;
            //fórumla --> A = TT.R2
            Console.WriteLine("Informe o tamanho do raio: ");
            raio = Convert.ToDouble(Console.ReadLine());

            area = pi * (raio * raio);
            Console.WriteLine("A área da circunferecnia é igual a: {0}", area.ToString("0.00"));

        }
    }
}
