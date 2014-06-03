using System;

class PeaceOfCake
    {
        static void Main()
        {
            decimal A = decimal.Parse(Console.ReadLine());
            decimal B = decimal.Parse(Console.ReadLine());
            decimal C = decimal.Parse(Console.ReadLine());
            decimal D = decimal.Parse(Console.ReadLine());

            decimal total = (A / B) + (C / D);

            if (total >= 1)
            {
                Console.WriteLine(Math.Floor(total));
            }
            else
            {
                Console.WriteLine("{0:F22}", total);     
            }
            decimal denominator = (B * D);
            A *= denominator / B;
            C *= denominator / D;

            Console.WriteLine("{0}/{1}", A + C, denominator);
        }
}

