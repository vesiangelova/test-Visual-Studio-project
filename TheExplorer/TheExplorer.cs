using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string firstline = new string('-', n / 2) + "*" + new string('-', n / 2);
        Console.WriteLine(firstline);
        for (int i = 0; i < n / 2; i++)
        {
            string firstend = new string('-', n / 2 - 1 - i);
            string middle = new string('-', 1 + 2 * i);
            Console.WriteLine("{0}*{1}*{0}", firstend, middle);
        }
        for (int i = 0; i < n / 2 - 1; i++)
        {
            string firstend = new string('-', i + 1);
            string middle = new string('-', n - 4 - 2 * i);
            Console.WriteLine("{0}*{1}*{0}", firstend, middle);
        }
        Console.WriteLine(firstline);
        //Console.ReadKey();
    }
}
