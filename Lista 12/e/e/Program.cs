public class Program
{
    public static void Main()
    {
        List<int> numeros = new List<int>();
        
        Console.WriteLine("Digite uma lista de números inteiros(Digite 'sair' para finalizar");

        while (true)
        {
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int numero))
            {
                numeros.Add(numero);
            }
            else
            {
                Console.WriteLine("Entrada inválida! Por favor, tente novamente");
                break;
                Console.Clear();
            }
        }
        
        double media = ((double)numeros.Sum() / numeros.Count);
        Console.WriteLine($"\nA média dos números é: {media}");

        Console.ReadKey(true);
    }
}