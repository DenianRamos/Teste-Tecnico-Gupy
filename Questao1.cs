using System;

class Program
{
    static void Main()
    {
        // Número a ser verificado
        int numero = 21; // Pode ser substituído por qualquer número desejado
        
        if (PertenceAFibonacci(numero))
        {
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci");
        }
        else
        {
            Console.WriteLine($"{numero} NÃO pertence à sequência de Fibonacci");
        }
    }

    static bool PertenceAFibonacci(int numero)
    {
        if (numero < 0) return false; 

        int a = 0;
        int b = 1;
        
        while (a <= numero)
        {
            if (a == numero) return true;
            int temp = a;
            a = b;
            b = temp + b;
        }

        return false;
    }
}
