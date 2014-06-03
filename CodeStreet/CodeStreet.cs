using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();
        int counter = 0;
        int sum = 0;
        int oddNums = 0;

        foreach (var letter in text)
        {
            if (counter % 2 == 1)
            {
                switch (letter)
                {
                    case '0':
                        sum += 0;
                        oddNums++;
                        break;

                    case '1':
                        sum += 1;
                        oddNums++;
                        break;

                    case '2':
                        sum += 2;
                        oddNums++;
                        break;
                    case '3':
                        sum += 3;
                        oddNums++;
                        break;

                    case '4':
                        sum += 4;
                        oddNums++;
                        break;

                    case '5':
                        sum += 5;
                        oddNums++;
                        break;

                    case '6':
                        sum += 6;
                        oddNums++;
                        break;

                    case '7':
                        sum += 7;
                        oddNums++;
                        break;

                    case '8':
                        sum += 8;
                        oddNums++;
                        break;

                    case '9':
                        sum += 9;
                        oddNums++;
                        break;


                    default:
                        break;
                }  
            }
            
            counter += 1;
        }
        Console.WriteLine("{0} {1}", oddNums, sum);
    }
}

