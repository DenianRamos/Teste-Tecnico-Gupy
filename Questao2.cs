using System;
using System.Linq;

class Program
{
    static void Main()
    {
        
        string texto = "Abra a janela para entrar ar fresco =)"; 

        int quantidade = ContarOcorrenciasDeA(texto);

        if (quantidade > 0)
        {
            Console.WriteLine($"A letra 'a' aparece {quantidade} vezes na string.");
        }
        else
        {
            Console.WriteLine("A letra 'a' não aparece na string.");
        }
    }

    static int ContarOcorrenciasDeA(string texto)
    {
        return texto.Count(c => c == 'a' || c == 'A');
    }
}
