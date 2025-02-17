using System;
using System.Collections.Generic;

class Banco
{
    public string NomeBanco { get; set; }
    private Dictionary<int, Conta> contas;

    public Banco(string nomeBanco)
    {
        NomeBanco = nomeBanco;
        contas = new Dictionary<int, Conta>();
    }

    public void AbrirConta(int numeroConta, string titular)
    {
        if (!contas.ContainsKey(numeroConta))
        {
            Conta novaConta = new Conta(numeroConta, titular);
            contas.Add(numeroConta, novaConta);
            Console.WriteLine($"Conta {numeroConta} aberta com sucesso para {titular}.");
        }
        else
        {
            Console.WriteLine($"A conta {numeroConta} já existe.");
        }
    }

    public void FecharConta(int numeroConta)
    {
        if (contas.ContainsKey(numeroConta))
        {
            contas.Remove(numeroConta);
            Console.WriteLine($"Conta {numeroConta} fechada com sucesso.");
        }
        else
        {
            Console.WriteLine($"Conta {numeroConta} não encontrada.");
        }
    }

    public void Depositar(int numeroConta, decimal valor)
    {
        if (contas.ContainsKey(numeroConta))
        {
            contas[numeroConta].Depositar(valor);
            Console.WriteLine($"Depósito de {valor:C} realizado na conta {numeroConta}.");
        }
        else
        {
            Console.WriteLine($"Conta {numeroConta} não encontrada.");
        }
    }

    public void Sacar(int numeroConta, decimal valor)
    {
        if (contas.ContainsKey(numeroConta))
        {
            contas[numeroConta].Sacar(valor);
            Console.WriteLine($"Saque de {valor:C} realizado na conta {numeroConta}.");
        }
        else
        {
            Console.WriteLine($"Conta {numeroConta} não encontrada.");
        }
    }

    public void ExibirSaldo(int numeroConta)
    {
        if (contas.ContainsKey(numeroConta))
        {
            decimal saldo = contas[numeroConta].Saldo;
            Console.WriteLine($"O saldo da conta {numeroConta} é {saldo:C}.");
        }
        else
        {
            Console.WriteLine($"Conta {numeroConta} não encontrada.");
        }
    }
}

class Conta
{
    public int NumeroConta { get; set; }
    public string Titular { get; set; }
    public decimal Saldo { get; private set; }

    public Conta(int numeroConta, string titular)
    {
        NumeroConta = numeroConta;
        Titular = titular;
        Saldo = 0;
    }

    public void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
        }
        else
        {
            Console.WriteLine("Valor de depósito deve ser positivo.");
        }
    }

    public void Sacar(decimal valor)
    {
        if (valor > 0 && valor <= Saldo)
        {
            Saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente ou valor inválido.");
        }
    }
}

class Program
{
    static void Main()
    {
        Banco banco = new Banco("Banco Central");

        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1. Abrir Conta");
            Console.WriteLine("2. Fechar Conta");
            Console.WriteLine("3. Depósito");
            Console.WriteLine("4. Saque");
            Console.WriteLine("5. Exibir Saldo");
            Console.WriteLine("6. Sair");
            Console.Write("Escolha uma opção (1-6): ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AbrirConta(banco);
                    break;

                case "2":
                    FecharConta(banco);
                    break;

                case "3":
                    Depositar(banco);
                    break;

                case "4":
                    Sacar(banco);
                    break;

                case "5":
                    ExibirSaldo(banco);
                    break;

                case "6":
                    Console.WriteLine("Saindo...");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void AbrirConta(Banco banco)
    {
        Console.Write("Digite o número da conta: ");
        int numeroConta = int.Parse(Console.ReadLine());

        Console.Write("Digite o nome do titular: ");
        string titular = Console.ReadLine();

        banco.AbrirConta(numeroConta, titular);
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }

    static void FecharConta(Banco banco)
    {
        Console.Write("Digite o número da conta para fechar: ");
        int numeroConta = int.Parse(Console.ReadLine());

        banco.FecharConta(numeroConta);
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }

    static void Depositar(Banco banco)
    {
        Console.Write("Digite o número da conta para depósito: ");
        int numeroConta = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor do depósito: ");
        decimal valor = decimal.Parse(Console.ReadLine());

        banco.Depositar(numeroConta, valor);
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }

    static void Sacar(Banco banco)
    {
        Console.Write("Digite o número da conta para saque: ");
        int numeroConta = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor do saque: ");
        decimal valor = decimal.Parse(Console.ReadLine());

        banco.Sacar(numeroConta, valor);
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }

    static void ExibirSaldo(Banco banco)
    {
        Console.Write("Digite o número da conta para exibir o saldo: ");
        int numeroConta = int.Parse(Console.ReadLine());

        banco.ExibirSaldo(numeroConta);
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }
}