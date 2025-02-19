using System.Runtime.CompilerServices;

public class Program
{
    public static void Main()
    {
        List<string> strings = new List<string>();
        string entrada;

        Console.WriteLine("Digite uma lista de palavras(digite sair para finalizar):");

        while (true)
        {
            entrada = Console.ReadLine();
            
            if (entrada == "sair")
            {
                break;
            }

            if (entrada != null)
            {
                strings.Add(entrada);
            }
            else
            {
                Console.WriteLine("Por favor, insira uma palavra válida.");
            }
        }
        
        // Variável para armazenar a string mais longa
        string stringMaisLonga = string.Empty;
        
        // Usando foreach para verificar cada string na lista
        foreach (string str in strings)
        {
            if (str.Length > stringMaisLonga.Length)
            {
                stringMaisLonga = str;
            }
        }
        // Imprimindo a string mais longa
        Console.WriteLine($"\nA string mais longa é {stringMaisLonga}");
        Console.ReadKey(true);
    }
}