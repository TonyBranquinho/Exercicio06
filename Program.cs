using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Console.WriteLine("Digite tres valores.");
            string[] vet = Console.ReadLine().Split(' ');
            double a = double.Parse(vet[0], CI);
            double b = double.Parse(vet[1], CI);
            double c = double.Parse(vet[2], CI);

            double areaTriagulo = ((a * c) / 2);
            double areaCirculo = (3.14159 * c * c);
            double areaTrapezio = (((a + b) * c) / 2);
            double areaQuadrado = (b * b);
            double areaRetangulo = (a * b);

            Console.WriteLine("TRIANGULO: " + areaTriagulo.ToString("F3", CI));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CI));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CI));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CI));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CI));

        }
    }
}