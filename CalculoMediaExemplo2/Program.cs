using System;


class Program
{
    static void Main()
    {
        int[] notas = { 8, 7, 9, 10 }
        int soma = 0;


        for (int i = 0; i <= notas.Length; i++)
        {
            soma += notas[i];
        }


        double media = soma / notas.Length;
        Console.WriteLine("A média é: " + media);
    }
}
