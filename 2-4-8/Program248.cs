using System;

class Program248
{
    static void Main()
    {
       long a, b, c;
        a = long.Parse(Console.ReadLine());
        b = long.Parse(Console.ReadLine());
        c = long.Parse(Console.ReadLine());
        long r = 0;

        switch (b)
        {
            case 2:
                r = a % c;
                break;

            case 4:
                r = a + c;
                break;

            case 8:
                r = a * c;
                break;

            default:
                break;
        }

        if (r % 4 == 0)
        {
            Console.WriteLine(r / 4);  
        }

        else
        {
            Console.WriteLine(r % 4);  
        }
        Console.WriteLine(r);
    }
}



