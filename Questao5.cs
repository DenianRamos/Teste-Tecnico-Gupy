using System;

class Program
{
    static void Main()
    {
        // Simula o problema dos interruptores e lâmpadas
        bool[] lampadas = new bool[3];     
        bool[] lampadasQuentes = new bool[3]; 

        // Passo 1: Ligue o primeiro interruptor e aguarde alguns minutos
        Console.WriteLine("Ligando o interruptor 1 e aguardando alguns minutos...");
        lampadas[0] = true; 
        lampadasQuentes[0] = true; 

        // Passo 2: Desligue o primeiro interruptor e ligue o segundo
        Console.WriteLine("Desligando o interruptor 1 e ligando o interruptor 2...");
        lampadas[0] = false; 
        lampadas[1] = true;  

        // Passo 3: Vá para a sala das lâmpadas e verifique o estado delas
        VerificarLampadas(lampadas, lampadasQuentes);
    }

    static void VerificarLampadas(bool[] lampadas, bool[] lampadasQuentes)
    {
        for (int i = 0; i < lampadas.Length; i++)
        {
            if (lampadas[i])
            {
                Console.WriteLine($"Lâmpada {i + 1}: Acesa - Controlada pelo Interruptor {i + 2}.");
            }
            else if (!lampadas[i] && lampadasQuentes[i])
            {
                Console.WriteLine($"Lâmpada {i + 1}: Apagada e Quente - Controlada pelo Interruptor {i + 1}.");
            }
            else
            {
                Console.WriteLine($"Lâmpada {i + 1}: Apagada e Fria - Controlada pelo Interruptor {i + 3}.");
            }
        }
    }
}