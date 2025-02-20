using System;

namespace c
{
    public class Triangulo
    {
        public double lado1 { get; set; }
        public double lado2 { get; set; }
        public double lado3 { get; set; }

        // Constructor
        public Triangulo(double lado1, double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        // Verifica o tipo do triângulo
        public string VerificaTriangulo()
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                return "É um triângulo equilátero.";
            }
            else if (lado1 == lado2 && lado1 != lado3)
            {
                return "É um triângulo isósceles.";;
            }
            else
            {
                return "É um triângulo escaleno.";
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {   
            Console.Write("Digite o valor do primeiro lado do triângulo: ");
            double lado1 = double.Parse(Console.ReadLine());
            
            Console.Write("Digite o valor do segundo lado: ");
            double lado2 = double.Parse(Console.ReadLine());
            
            Console.Write("Digite o valor do terceiro lado: ");
            double lado3 = double.Parse(Console.ReadLine());
            
            Triangulo triangulo = new Triangulo(lado1, lado2, lado3);

            string resultado = triangulo.VerificaTriangulo();
            Console.WriteLine(resultado);
        }
    }
}