using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("a) 1, 3, 5, 7, " + (7 + 2));           // Sequência de números ímpares
        Console.WriteLine("b) 2, 4, 8, 16, 32, 64, " + (64 * 2)); // Sequência de potências de 2
        Console.WriteLine("c) 0, 1, 4, 9, 16, 25, 36, " + (7 * 7)); // Sequência de quadrados perfeitos
        Console.WriteLine("d) 4, 16, 36, 64, " + (10 * 10));     // Quadrados perfeitos pares
        Console.WriteLine("e) 1, 1, 2, 3, 5, 8, " + (8 + 5));    // Sequência de Fibonacci
        Console.WriteLine("f) 2, 10, 12, 16, 17, 18, 19, " + 20);  // Sequência com saltos e incrementos
    }
}