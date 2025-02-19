using System;
using System.Globalization;
using System.Text;

namespace LivroApp
{
    public class Livro
    {
        public string Titulo { get; set;}
        public string Autor { get; set;}
        public string Editora { get; set;}
        public string Disponibilidade { get; set;}

        public string IsDisponivel()
        {
            if (Disponibilidade == "Disponível")
            {
                Disponibilidade = "diposnivel para empréstimo";
            }
            else
            {
                Disponibilidade = "indisponível para empréstimo";
            }
            return Disponibilidade;
        }
    }
    
    public class Letra_E()
    {
        public static void Main(string[] args)
        {
            Livro livro = new Livro();
            
            Console.Write("Digite o nome do livro: ");
            livro.Titulo = Console.ReadLine();  
            
            Console.Write("Digite o nome do autor: ");
            livro.Autor = Console.ReadLine();  
            
            Console.Write("Digite o nome da editora: ");
            livro.Editora = Console.ReadLine();  
            
            Console.Write("Digite a disponibilidade do livro: ");
            livro.Disponibilidade = Console.ReadLine().ToLower();  
            
            Console.WriteLine($"\nO livro {livro.Titulo} está {livro.IsDisponivel()}");
        }
    }
}