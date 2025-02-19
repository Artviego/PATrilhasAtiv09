using System;

public class Produto
{
    public string nome;
    public double precoUnitario;
    public int quantidade;

    // Retorna o cálculo do valor total do produto
    public double valorTotal()
    {
        return precoUnitario * quantidade;
    }
}



public class letra_c
{
    public static void Main()
    {
        Produto produto = new Produto(); // Cria uma instância da classe Produto
        
        // Recebe o nome do produto
        Console.Write("Digite o nome do produto: ");
        produto.nome = Console.ReadLine();
        
        // Recebe o preço unitário do produto
        Console.Write("Digite o preço unitário do produto: ");
        produto.precoUnitario = double.Parse(Console.ReadLine());
        
        // Recebe a quantidade do produto
        Console.Write("Digite a quantidade do produto: ");
        produto.quantidade = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"O valor total do produto é: {produto.valorTotal():C2}");
    }
}