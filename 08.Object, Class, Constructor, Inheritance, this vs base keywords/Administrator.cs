using System;

public class Administrator : Person
{
    public string Position;
    public string Department;
    public int AccessLevel;

    public Administrator(string firstName, string lastName, int age, string email, string id,
                         string position, string department, int accessLevel)
        : base(firstName, lastName, age, email, id)
    {
        this.Position = position;
        this.Department = department;
        this.AccessLevel = accessLevel;
    }

    public void ShowAdminInfo()
    {
        base.ShowBasicInfo();
        Console.WriteLine($"Position: {Position}");
        Console.WriteLine($"Department: {Department}");
        Console.WriteLine($"Access Level: {AccessLevel}");
    }
    public void GrantAccess(Students student)
    {
        Console.WriteLine($"\nAccess granted to student {student.GetFullName()} (ID: {student.Id})");
    }

}