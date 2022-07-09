using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi, raio, area1, Sarea, Sbase, Saltura, area3, base3mA, base3mN, altura3;
            int fgeometrica;
            pi = 3.14159265359;
            Console.WriteLine("FORMAS GEOMÉTRICAS");
            Console.WriteLine("1-Círculo 2-Triângulo 3-Trapézio");
            Console.WriteLine();
            Console.Write("Digite o código da figura geométrica:");
            fgeometrica = Convert.ToInt32(Console.ReadLine());
            switch (fgeometrica)
            {
                case 1:
                    Console.WriteLine("Digite o raio em cm: ");
                    raio = Convert.ToInt32(Console.ReadLine());
                    area1 = pi * (raio * raio);
                    Console.WriteLine("Área do círculo: " + area1 + "cm");
                    break;
                case 2:
                    Console.WriteLine("Digite a base em cm: ");
                    Sbase = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite a altura em cm: ");
                    Saltura = Convert.ToInt32(Console.ReadLine());
                    Sarea = (Sbase * Saltura) / 2;
                    Console.WriteLine("Área do Triângulo: " + Sarea + "cm");
                    break;
                case 3:
                    Console.Write("Digite a base menor em cm: ");
                    base3mN = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite a base maior em cm: ");
                    base3mA = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Digite a altura em cm: ");
                    altura3 = Convert.ToInt32(Console.ReadLine());
                    area3 = ((base3mA + base3mN) * altura3) / 2;
                    Console.WriteLine("Área do Trapézio: " + area3 + "cm");
                    break;
            }
            Console.ReadKey();
        }
    }
}
