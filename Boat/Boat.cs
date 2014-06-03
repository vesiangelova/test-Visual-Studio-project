using System;

class Boat
{
    static void Main()
    {
        int upWater = int.Parse(Console.ReadLine());
        int width = upWater * 2 -1;
        int height = 6 + ((upWater - 3) / 2) * 3;
        int sails = 2 * height / 3;
        int basE = height / 3;
        int counter = upWater;

        for (int col = 0; col < upWater; col++)
        {
            for (int row = 0; row < upWater; row++)
            {
                if (row == counter)
                {
                    Console.Write('*'); 
                }
                else
                {
                    Console.Write('.');
                }

            }
            Console.Write('*');
            for (int row = upWater -1; row >= 0; row--)
            {
                if (row == counter)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
            counter--;
        }
        for (int i = 0; i < width + 2; i++)
        {
            Console.Write('*');
        }
        counter++;
        Console.WriteLine();

        for (int i = 0; i < basE-1; i++)
        {
            for (int row = 0; row < upWater; row++)
            {
                if (row == counter)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }

            }
            Console.Write('*');
            for (int row = upWater - 1; row >= 0; row--)
            {
                if (row == counter)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
            counter++;  
        }
        string lastRowDots = new string('.', (width - upWater) / 2 +1);
        string lastRowStars = new string('*', upWater);
        Console.WriteLine("{0}{1}{0}", lastRowDots, lastRowStars);
    }
}

