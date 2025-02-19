using System;

public class Retangulo
{
    public float Base { get; set; }
    public float Altura { get; set; }

    // Retorna a área
    public float Area()
    {
        return Base * Altura;
    }

    // Retorna o perímetro
    public float Perimetro()
    {
        return 2 * (Base + Altura);
    }
}

public class Letra_D
{
    public static void Main()
    {
        Retangulo r = new Retangulo();
        
        Console.Write("Digite o valor da base do retângulo: ");
        r.Base = float.Parse(Console.ReadLine());
        
        Console.Write("Digite o valor da altura do retângulo: ");
        r.Altura = float.Parse(Console.ReadLine());
        
        Console.WriteLine($"\nA área deste triângulo é: {r.Area()}");
        Console.WriteLine($"nO perímetro deste retângulo é: {r.Perimetro()}");
    }
}