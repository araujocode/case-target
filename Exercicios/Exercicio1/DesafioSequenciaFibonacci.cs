using System;
using System.Linq;
using System.Collections.Generic;

public class DesafioSequenciaFibonacci
{
    public static void Main(string[] args)
    {
        int numero = 21;

        bool pertence = PertenceFibonacci(numero);
        string mensagem = pertence ? "O número faz parte da sequência de Fibonacci." : "O número não faz parte da sequência de Fibonacci.";

        Console.WriteLine(mensagem);
    }

    public static bool PertenceFibonacci(int numero)
    {
        return Fibonacci().TakeWhile(x => x <= numero).Contains(numero);
    }

    public static IEnumerable<int> Fibonacci()
    {
        int a = 0, b = 1;
        yield return a;
        yield return b;

        while (true)
        {
            int proximo = a + b;
            yield return proximo;
            a = b;
            b = proximo;
        }
    }
}
