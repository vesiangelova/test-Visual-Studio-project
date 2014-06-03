using System;

    class WorkHours
    {
        static void Main()
        {
            double h = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            double workDays = d - (d * 10 / 100);
            double workHours = (workDays * 12);
            double productivity = Math.Truncate((workHours * p) / 100);

            double difference = (productivity - h);
           
            if (difference >= 0)
            {
                Console.WriteLine("Yes"); 
            }
            else Console.WriteLine("No");
            Console.WriteLine(difference);

        }
    }

