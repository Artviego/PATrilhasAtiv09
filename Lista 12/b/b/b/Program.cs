public class Program
{
    public static void Main()
    {
        List<string> lista = new List<string>
        {
            "Olá, mundo!",
            "Bem-vindo ao C# 13.0",
            "Exemplo com foreach",
            "Fim da lista"
        };
        
        Console.WriteLine("Mensagens do vetor:");
        // Use foreach para imprimir cada elemento na tela
        foreach (string mensagem in lista)
        {
            Console.WriteLine(mensagem);
        }

        Console.ReadKey(true);
    }
}
