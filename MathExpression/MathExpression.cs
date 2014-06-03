using System;

class MathExpression
{
    static void Main(string[] args)
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal m = decimal.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());
        decimal trunc = Math.Truncate(m % 180);

        decimal nom = (n * n) + (1 / (m * p) + 1337);
        decimal denom = n - 128.253123123m * p;
        decimal result = (nom / denom) + (decimal)(Math.Sin((double) (trunc)));

        Console.WriteLine("{0:F6}", result);
    }
}

