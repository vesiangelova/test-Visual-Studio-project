using System;

class Sand_Glass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int stars = n;
        int dots = 0;

        while (true)
        {
            DrawLine(stars, dots);
            stars = stars - 2;
            dots++;
            Console.WriteLine();
            if (stars == -1)
            {
                break;
            }

        }

        stars = 3;
        dots = (n - stars) / 2;

        while (true)
        {
            DrawLine(stars, dots);
            stars = stars + 2;
            dots--;
            Console.WriteLine();
            if (dots == -1)
            {
                break;
            }
        }
    }

    private static void DrawLine(int stars, int dots)
    {
        for (int i = 0; i < dots; i++)
        {
            Console.Write('.');
        }
        for (int i = 0; i < stars; i++)
        {
            Console.Write('*');
        }
        for (int i = 0; i < dots; i++)
        {
            Console.Write('.');
        }
    }
}
   

    
