using System;
 public class Students : Person
{
    public string StudentNumber;
    public string Faculty;
    public double GPA;
    public int Year;

    public Students(string firstName, string lastName, int age, string email, string id,
        string studentNumber, string faculty, double gpa, int year)
        : base(firstName, lastName, age, email, id)
    {
        this.StudentNumber = studentNumber;
        this.Faculty = faculty;
        this.GPA = gpa;
        this.Year = year;
    }
    public void ShowStudentInfo()
    {
        base.ShowBasicInfo();
        Console.WriteLine($"Student Number: {StudentNumber}");
        Console.WriteLine($"Faculty: {Faculty}");
        Console.WriteLine($"GPA: {GPA}");
        Console.WriteLine($"Year: {Year}");
    }

    public double CalculateScholarship()
    {
        if (GPA >= 90)
            return 500;
        else if (GPA >= 80)
            return 350;
        else if (GPA >= 70)
            return 200;
        else
            return 0;
    }
}

