using System;

public class Teachers : Person
{
    public string Department;
    public string MainSubject;
    public decimal BaseSalary;
    public int ExperienceYears;

    public Teachers(string firstName, string lastName, int age, string email, string id,
                   string department, string mainSubject, decimal baseSalary, int experienceYears)
        : base(firstName, lastName, age, email, id)


    {
        this.Department = department;
        this.MainSubject = mainSubject;
        this.BaseSalary = baseSalary;
        this.ExperienceYears = experienceYears;
    }
    public void ShowTeacherInfo()
    {
        base.ShowBasicInfo();
        Console.WriteLine($"Department: {Department}");
        Console.WriteLine($"Main Subject: {MainSubject}");
        Console.WriteLine($"Experience Years: {ExperienceYears}");
    }

    public decimal CalculateSalary()
    {
        return BaseSalary + (ExperienceYears * 50);
    }
}