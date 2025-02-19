using System;

namespace CalculadoraApp
{
    public class Calculadora
    {
        // Método para somar
        public double Somar(double a, double b)
        {
            return a + b;
        }

        // Método para subtrair
        public double Subtrair(double a, double b)
        {
            return a - b;
        }

        // Método para multiplicar
        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        // Método para dividir
        public double Dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Erro: Divisão por zero!");
                return double.NaN; // Retorna 'NaN' para indicar erro
            }
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            while (true)
            {
                // Exibe o menu para o usuário
                Console.Clear();
                Console.WriteLine("=== Calculadora ===");
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Sair");
                Console.Write("Opção: ");
                int opcao = int.Parse(Console.ReadLine());

                // Se o usuário escolher sair
                if (opcao == 5)
                {
                    break;
                }

                // Solicita os valores
                Console.Write("Digite o primeiro número: ");
                double numero1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                double numero2 = double.Parse(Console.ReadLine());

                double resultado = 0;

                // Realiza a operação com base na escolha do usuário
                switch (opcao)
                {
                    case 1:
                        resultado = calculadora.Somar(numero1, numero2);
                        Console.WriteLine($"Resultado: {numero1} + {numero2} = {resultado}");
                        break;
                    case 2:
                        resultado = calculadora.Subtrair(numero1, numero2);
                        Console.WriteLine($"Resultado: {numero1} - {numero2} = {resultado}");
                        break;
                    case 3:
                        resultado = calculadora.Multiplicar(numero1, numero2);
                        Console.WriteLine($"Resultado: {numero1} * {numero2} = {resultado}");
                        break;
                    case 4:
                        resultado = calculadora.Dividir(numero1, numero2);
                        if (!double.IsNaN(resultado))
                        {
                            Console.WriteLine($"Resultado: {numero1} / {numero2} = {resultado}");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }

                // Espera o usuário pressionar uma tecla para continuar
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}