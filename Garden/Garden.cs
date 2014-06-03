using System;

class Garden
{
    static void Main()
    {
        decimal tomPrice = 1.60m;
        ....
        
        decimal tomseeds = decimal.Parse(Console.ReadLine());
        decimal tomarea = decimal.Parse(Console.ReadLine());
        decimal cocseeds = decimal.Parse(Console.ReadLine());
        decimal cocarea = decimal.Parse(Console.ReadLine());
        decimal carseeds = decimal.Parse(Console.ReadLine());
        decimal cararea = decimal.Parse(Console.ReadLine());
        decimal cabseeds = decimal.Parse(Console.ReadLine());
        decimal cabarea = decimal.Parse(Console.ReadLine());
        decimal beanseeds = decimal.Parse(Console.ReadLine());
        decimal beanarea = decimal.Parse(Console.ReadLine());

        decimal totalPrice = tomseeds*tomPrice + ...;

        Console.WriteLine("0:F2", totalPrice);

        decimal bean+rea = totalarea - tomarea - cocarea...;

        if (beanarea>0)
	{
		 Console.WriteLine("{0}", beanarea );
	}
        else if (beanarea==0)
	{
        Console.WriteLine("No area for beans");        
	}
        else (beanarea<0)
	{
        Console.WriteLine("nnnn" );        
	}

    }
}
