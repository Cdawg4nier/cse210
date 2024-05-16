using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Samuel Bennet", "Multiplication", "Section 7D-13", "Problems 21-34a,b,c");
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Samuel Bennet", "Rhetorical Analysis", "Once Upon a Time");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}