using System;
using System.Collections.Generic;

namespace BancoApp
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0; // Saldo inicial da conta é zero
        }

        // Método para realizar depósito
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de {valor:C} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido.");
            }
        }

        // Método para realizar saque
        public void Sacar(double valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Valor de saque inválido ou saldo insuficiente.");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual da conta: {Saldo:C}");
        }
    }

    public class Banco
    {
        private List<Conta> contas;

        public Banco()
        {
            contas = new List<Conta>();
        }

        // Método para abrir uma conta
        public void AbrirConta()
        {
            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular: ");
            string titular = Console.ReadLine();

            // Verifica se a conta já existe
            if (contas.Exists(c => c.Numero == numero))
            {
                Console.WriteLine("Erro: Já existe uma conta com esse número.");
            }
            else
            {
                Conta novaConta = new Conta(numero, titular);
                contas.Add(novaConta);
                Console.WriteLine($"Conta aberta com sucesso para {titular}. Número da conta: {numero}");
            }
        }

        // Método para fechar uma conta
        public void FecharConta()
        {
            Console.Write("Digite o número da conta para fechar: ");
            int numero = int.Parse(Console.ReadLine());

            var conta = contas.Find(c => c.Numero == numero);

            if (conta != null)
            {
                if (conta.Saldo == 0)
                {
                    contas.Remove(conta);
                    Console.WriteLine($"Conta {numero} fechada com sucesso.");
                }
                else
                {
                    Console.WriteLine("Não é possível fechar a conta, pois ainda há saldo.");
                }
            }
            else
            {
                Console.WriteLine("Conta não encontrada.");
            }
        }

        // Método para realizar operações na conta
        public void RealizarOperacoes()
        {
            Console.Write("Digite o número da conta para realizar operações: ");
            int numero = int.Parse(Console.ReadLine());

            var conta = contas.Find(c => c.Numero == numero);

            if (conta != null)
            {
                Console.WriteLine("\nEscolha a operação desejada:");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Sacar");
                Console.WriteLine("3 - Ver Saldo");
                Console.WriteLine("4 - Voltar");
                Console.Write("Opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o valor para depósito: ");
                        double valorDeposito = double.Parse(Console.ReadLine());
                        conta.Depositar(valorDeposito);
                        break;

                    case 2:
                        Console.Write("Digite o valor para saque: ");
                        double valorSaque = double.Parse(Console.ReadLine());
                        conta.Sacar(valorSaque);
                        break;

                    case 3:
                        conta.ExibirSaldo();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Conta não encontrada.");
            }
        }

        // Exibe o menu principal
        public void ExibirMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Banco ===");
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("1 - Abrir Conta");
                Console.WriteLine("2 - Fechar Conta");
                Console.WriteLine("3 - Realizar Operações");
                Console.WriteLine("4 - Sair");
                Console.Write("Opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AbrirConta();
                        break;

                    case 2:
                        FecharConta();
                        break;

                    case 3:
                        RealizarOperacoes();
                        break;

                    case 4:
                        Console.WriteLine("Saindo... Até logo!");
                        return;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                // Aguarda o usuário pressionar uma tecla para continuar
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();
            banco.ExibirMenu();
        }
    }
}