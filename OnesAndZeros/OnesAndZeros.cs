using System;

class OnesAndZeros
{
    static void Main(string[] args)
    {
        string zeroTopBottom = "###";
        string zeroBody = "#.#";
        string oneTopBody = ".#.";
        string oneUnique = "##.";

        int inpute = int.Parse(Console.ReadLine());

        string binary = Convert.ToString(inpute, 2).PadLeft(32, '0');

        for (int row = 0; row < 5; row++)
        {
            for (int bit =16; bit < 32; bit++)
            {
                if (binary[bit] == '0')
                {
                    if (row == 0 || row == 4)
	                    {
		                Console.Write(zeroTopBottom); 
	                    }
                    else
	                    {
                        Console.Write(zeroBody);
	                    }
                }
                else
	                    {
                        if (row == 1)
	                        {
		                    Console.Write(oneUnique);
                            }
                        else if (row == 4)
                        {
                            Console.Write(zeroTopBottom);
                        }
                        else 
                        {
                            Console.Write(oneTopBody);
                        }
                }
                if (bit != binary.Length -1)
                {
                    Console.Write('.');  
                }
                
            }
            Console.WriteLine();
        }

    }
}

