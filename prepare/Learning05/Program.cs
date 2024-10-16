using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assgn1 = new Assignment("Samuel Bennett", "- Multiplication");
        Console.WriteLine(assgn1.GetSummary());

        MathAssignment mathassgn = new MathAssignment("Roberto Rodriguez", " - Fractions", "7.3", "8-19");
        Console.WriteLine(mathassgn.GetSummary());
        Console.WriteLine(mathassgn.GetHomeWorkList());

        WritingAssignment writeassign = new WritingAssignment("Mary Waters", " - European History", "The Causes of World War II");
        Console.WriteLine(writeassign.GetSummary());
        Console.WriteLine(writeassign.GetWritingInformation());
    }
}