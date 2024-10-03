using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction test = new Fraction(); 
        Console.WriteLine(test.GetFractionString());
        Console.WriteLine(test.GetDecimalValue());

        Fraction test1 = new Fraction(5);
        Console.WriteLine(test1.GetFractionString());
        Console.WriteLine(test1.GetDecimalValue());

        Fraction test2 = new Fraction(3, 4);
        Console.WriteLine(test2.GetFractionString());
        Console.WriteLine(test2.GetDecimalValue());
        
        test2.SetTop(1);
        test2.SetBottom(3);
        Console.WriteLine(test2.GetFractionString());
        Console.WriteLine(test2.GetDecimalValue());

    }
}
    }
}