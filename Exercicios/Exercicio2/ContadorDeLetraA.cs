using System;

public class ContadorDeLetraA
{
    public static void Main(string[] args)
    {
        string texto = "Ao primeiro verme a terra abre a tumba e a devora, fria e lívida, como o palor da cera...";

        int quantidade = ContarOcorrenciasDeA(texto);
        Console.WriteLine($"A letra 'a' aparece {quantidade} vezes.");
    }

    public static int ContarOcorrenciasDeA(string texto)
    {
        int contador = 0;
        foreach (char c in texto)
        {
            if (c == 'a' || c == 'A')
                contador++;
        }
        return contador;
    }
}
