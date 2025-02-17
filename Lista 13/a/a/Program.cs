﻿using System;

namespace CalculadoraApp
{
    public class Calculadora
    {
        // Método para somar dois números
        public double Somar(double num1, double num2)
        {
            return num1 + num2;
        }

        // Método para subtrair dois números
        public double Subtrair(double num1, double num2)
        {
            return num1 - num2;
        }

        // Método para multiplicar dois números
        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        // Método para dividir dois números
        public double Dividir(double num1, double num2)
        {
            // Verifica se o divisor não é zero
            if (num2 == 0)
            {
                Console.WriteLine("Erro: Divisão por zero!");
                return double.NaN; // Retorna 'Not-a-Number' em caso de erro
            }
            return num1 / num2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            
            // Exibe o menu para o usuário
            Console.WriteLine("Escolha a operação desejada:");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            
            // Solicita ao usuário a escolha da operação
            Console.Write("Digite o número da operação: ");
            int operacao = int.Parse(Console.ReadLine());

            // Solicita os dois números para a operação
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            // Realiza a operação escolhida
            double resultado = 0;
            bool operacaoValida = true;

            switch (operacao)
            {
                case 1:
                    resultado = calc.Somar(num1, num2);
                    Console.WriteLine($"Resultado da soma: {num1} + {num2} = {resultado}");
                    break;
                case 2:
                    resultado = calc.Subtrair(num1, num2);
                    Console.WriteLine($"Resultado da subtração: {num1} - {num2} = {resultado}");
                    break;
                case 3:
                    resultado = calc.Multiplicar(num1, num2);
                    Console.WriteLine($"Resultado da multiplicação: {num1} * {num2} = {resultado}");
                    break;
                case 4:
                    resultado = calc.Dividir(num1, num2);
                    if (!double.IsNaN(resultado))
                    {
                        Console.WriteLine($"Resultado da divisão: {num1} / {num2} = {resultado}");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    operacaoValida = false;
                    break;
            }

            if (operacaoValida)
            {
                Console.WriteLine("Operação concluída com sucesso.");
            }
            else
            {
                Console.WriteLine("Tente novamente com uma opção válida.");
            }
        }
    }
}