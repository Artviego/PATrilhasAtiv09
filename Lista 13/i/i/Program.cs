using System;
using System.Security.Principal;

namespace letra_i
{
    public class Agenda
    {
        List<string> nomes = new List<string>();
        List<string> numeros = new List<string>();

        // Constructor da Classe Agenda
        public Agenda(List<string> nome, List<string> numero)
        {
            this.nomes = nome;
            this.numeros = numero;
        }

        // Método que adiciona os dados do contato
        public void AdicionarContato()
        {
            Console.Write("Digite o nome do contato: ");
            string nome = Console.ReadLine().ToLower();
            nomes.Add(nome);
            
            Console.Write("Digite o número de telefone do contato: ");
            string numero = Console.ReadLine();
            numeros.Add(numero);
            
            Console.WriteLine("Contato adicionado com sucesso!");
        }

        // Método que remove o contato
        public void RemoverContato()
        {
            Console.Write("Digite o nome do contato: ");
            string nome = Console.ReadLine().ToLower();
            
            for (int i = 0; i < nomes.Count; i++)
            {
                if (nomes[i] == nome)
                {
                    nomes.RemoveAt(i);
                    numeros.RemoveAt(i);
                    Console.WriteLine("Contato removido com sucesso!");
                    return;
                }
            }
        }

        // Método que lista os contatos cadastrados
        public void ListarContatos()
        {
            Console.WriteLine("Lista de contatos: ");
            for (int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine(nomes[i] + " - " + numeros[i]);
            }
        }
        
        public void ExibirMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===Agenda===");
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("1 - Adicionar Contato");
                Console.WriteLine("2 - Remover Contato");
                Console.WriteLine("3 - Listar Contatos");
                Console.WriteLine("4 - Sair");
                Console.Write("Opção: ");
            
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarContato();
                        break;
                    case 2:
                        RemoverContato();
                        break;
                    case 3:
                        ListarContatos();
                        break;
                    case 4:
                        Console.WriteLine("Saindo...");
                        return;
                    default:
                        Console.WriteLine("Opção Inválida.");
                        break;
                }
            
                // Aguarda o usuário pressionar uma tecla para continuar
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey(true);
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Agenda agenda = new Agenda(new List<string>(), new List<string>());
            agenda.ExibirMenu();
        }
        
    }
}