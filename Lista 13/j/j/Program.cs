using System;

namespace letra_j
{
    public class CarrinhoDeCompras
    {
        private List<string> produtos { get; set; }
        private List<int> quantidade { get; set; }
        private List<double> valores { get; set; }

        // Constructor da classe CarrinhoDeCompras
        public CarrinhoDeCompras(List<string> produto, List<int> quantidade, List<double> valor)
        {
            this.produtos = produto;
            this.quantidade = quantidade;
            this.valores = valor;
        }

        public void AdicionarProduto()
        {
            Console.Write("Digite o produto que deseja adicionar: ");
            string produto = Console.ReadLine();
            produtos.Add(produto);
            
            Console.Write("Digite a quantidade do produto: ");
            int quantidadeProduto = int.Parse(Console.ReadLine());
            quantidade.Add(quantidadeProduto);
            
            Console.Write("Digite o valor do produto: ");
            double valor = double.Parse(Console.ReadLine());
            valores.Add(valor);
            
            Console.WriteLine("Produto adicionado com sucesso!");
        }

        public void RemoverProduto()
        {
            Console.Write("Digite o produto que deseja remover: ");
            string produto = Console.ReadLine();
            for (int i = 0; i < produtos.Count; i++)
            {
                if (produtos[i] == produto)
                {
                    produtos.RemoveAt(i);
                    quantidade.RemoveAt(i);
                    valores.RemoveAt(i);
                    Console.WriteLine("Produto removido com sucesso!");
                    return;
                }
            }
        }

        public void ListarProdutos()
        {
            Console.WriteLine("Produtos: ");
            for (int i = 0; i < produtos.Count; i++)
            {
                Console.WriteLine(produtos[i]);
            }
        }

        public void CalcularTotal()
        {
            double total = 0;
            for (int i = 0; i < produtos.Count; i++)
            {
                total += quantidade[i] * valores[i];
            }
            Console.WriteLine($"Valor total: {total:C}");
        }

        public void ExibirMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===Carrinho de Compras===");
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("1 - Adicionar Produto");
                Console.WriteLine("2 - Remover Produto");
                Console.WriteLine("3 - Listar Produtos");
                Console.WriteLine("4 - Valor Total");
                Console.WriteLine("5 - Sair");
                Console.Write("Opção: ");
                
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        AdicionarProduto();
                        break;
                    case 2:
                        RemoverProduto();
                        break;
                    case 3:
                        ListarProdutos();
                        break;
                    case 4:
                        CalcularTotal();
                        break;
                    case 5:
                        Console.WriteLine("Saindo...");
                        return;
                    default:
                        Console.WriteLine("Opção Inválida.");
                        break;
                }
                
                // Aguarda o usuário inserir uma tecla para continuar
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey(true);
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras(new List<string>(), new List<int>(), new List<double>());
            carrinho.ExibirMenu();
        }
    }
}