using System;

class Program
{
    static void Main()
    {
        int INDICE = 12, SOMA = 0, K = 1;

      
        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
        }

        
        Console.WriteLine($"O valor de SOMA é: {SOMA}");
    }
}