public class Program
{
    public static void Main()
    {
        int[] numeros = new int[4];
        
        Console.WriteLine("\nNúmeros do vetor:");

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = i + 1;
        }

        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        Console.ReadKey(true);
    }
}