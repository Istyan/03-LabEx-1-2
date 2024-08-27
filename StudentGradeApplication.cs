using System;

class frmStudentGradeProgram
{
    static void Main(string[] args)
    {
        Console.Write("Enter your Name: ");
        string fullName = Convert.ToString(Console.ReadLine());

        Console.Write("Enter your grade in Math: ");
        double gradeMath = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your grade in English: ");
        double gradeEng= Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your grade in Science: ");
        double gradeSci = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your grade in Filipino: ");
        double gradeFil = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your grade in History: ");
        double gradeHistory = Convert.ToDouble(Console.ReadLine());

        double sumGrades = gradeMath + gradeEng + gradeSci + gradeFil + gradeHistory;

        double aveGrade = sumGrades / 5;

        double passingGrade = 75.00;
        string results = aveGrade >= 75.00 ? "The Student Passed!" : "The Student Failed!";

        Console.Write(results);

    }
}

