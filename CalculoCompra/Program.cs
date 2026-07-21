using System;

class Program
{
    static double CalcularTotal(double subtotal, double desconto, double frete)
    {
        double totalComDesconto = subtotal - desconto;
        return totalComDesconto + frete;
    }

    static void Main()
    {
        double subtotal = 200;
        double desconto = 10; // desconto de 10%
        double frete = 15;

        double total = CalcularTotal(subtotal, desconto, frete);
        Console.WriteLine($"Total a pagar: {total}");
    }
}