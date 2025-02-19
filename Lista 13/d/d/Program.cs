// Classe do Aluno
public class Aluno
{
    public string Nome { get; set; }
    public float[] notas = new float[4];
    public float media { get; set; }
    public float soma = 0;

    public float CalculoMedia()
    {
        return media = soma / 4; // Calcula a média com base na soma das notas
    }

    public string VerificaAluno()
    {
        return media >= 7 ? "Aprovado" : "Reprovado"; // Verifica se o aluno foi aprovado ou reprovado.
    }
}

public class letra_d
{
    public static void Main(string[] args)
    {
        Aluno aluno = new Aluno();
        aluno.soma = 0;
        int i;
        
        Console.Write("Digite o nome do aluno: ");
        aluno.Nome = Console.ReadLine();
        
        Console.WriteLine("Digite as 4 notas do aluno:");
        for (i = 0; i < 4; i++)
        {
            aluno.notas[i] = float.Parse(Console.ReadLine());
            aluno.soma += aluno.notas[i];
        }
        
        Console.WriteLine($"A média deste aluno é {aluno.CalculoMedia()}. {aluno.VerificaAluno()}");
    }
}