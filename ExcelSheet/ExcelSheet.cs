using System;
using System.Collections.Generic;

    class ExcelSheet
    {
        static void Main()
        {
            char[] alphabet = "1ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            int number = int.Parse(Console.ReadLine());

            string alphas = string.Empty;

            for (int i = 0; i < number; i++)
            {
                alphas += Console.ReadLine();
            }

            int pow = number - 1;   

            double result = 0;

            for (int j = 0; j < alphas.Length; j++)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (alphas[j] == alphabet[i])
                    {
                        result += i * Math.Pow(26, pow);
                        //C==3 E==5 C==3 A==1  
                        //result = 3*26^3 + 5*26^2 + 3*26^1 + 1*26^0 
                        break;
                    }
                    
                }
                pow--;
            }
            Console.WriteLine(result);
        }
    }

