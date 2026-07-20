using System;


class Program
{
    static double CalcularMedia(double[] notas)
    {
        double soma = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            soma += notas[i];
        }
        return soma / notas.Length;
    }


    static bool FrequenciaOk(int faltas, int totalAulas)
    {
        double percentualFaltas = (double)faltas / totalAulas;
        return percentualFaltas <= 0.25;
    }


    static string DefinirResultado(double media, bool frequenciaOk)
    {
        if (!frequenciaOk) return "Reprovado por falta";
        if (media >= 6) return "Aprovado";
        return "Reprovado por nota";
    }


    static void Main()
    {
        double[] notas = { 7, 8, 5, 6 };
        int faltas = 5;
        int totalAulas = 40;


        double media = CalcularMedia(notas);
        bool freq = FrequenciaOk(faltas, totalAulas);
        string resultado = DefinirResultado(media, freq);


        Console.WriteLine($"Média: {media}");
        Console.WriteLine($"Resultado: {resultado}");
    }
}
