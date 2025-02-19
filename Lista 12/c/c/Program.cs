public class Program
{
    public static void Main()
    {
        List<int> inteiros = new List<int>();
        
        Console.WriteLine("Digite uma lista de números inteiros(digite sair para finalizar a lista):");

        while (true)
        {
            string entrada = Console.ReadLine(); 

            if (entrada.ToLower() == "sair") // Finaliza a sessão
            {
                break;
            }

            if (int.TryParse(entrada, out int numero)) // Converte a entrada para inteiro
            {
                inteiros.Add(numero);
            }
            else
            {
                Console.WriteLine("Por favor, insira um número inteiro válido ou 'sair' para finalizar.");
            }
        }
        
        // Exibe o maior número 
        if (inteiros.Count > 0)
        {
            int maiorNumero = EncontrarMaiorNumero(inteiros);
            Console.WriteLine($"O maior número da lista é {maiorNumero}");
        }
        else
        {
            Console.WriteLine("Nenhum número foi inserido.");
        }

        Console.ReadKey(true);
    }

    public static int EncontrarMaiorNumero(List<int> inteiros)
    {
        int maior = inteiros[0];

        foreach (int numero in inteiros)
        {
            if (numero > maior)
            {
                maior = numero;
            }
        }

        return maior;
    }
}