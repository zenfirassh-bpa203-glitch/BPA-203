using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Object__Class__Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //students 
            Students s1 = new Students("Zema", "Sireliyeva", 19, "sirelyva06@example.com", "s1", "123456", "IT", 88.5, 3);
            Students s2 = new Students("Elyana", "Alizadeh", 20, "alizadeh@example.com", "s2", "654321", "CS", 92.0, 24);
            Students s3 = new Students("Aytac", "Qeribova", 21, "qeribova@example.com", "s3", "112233", "Math", 68.5, 2);

            //teachers
            Teachers t1 = new Teachers("Seid", "Nuraliyev", 35, "nuraliyev@example.com", "t1", "IT", "Programming", 800, 15);
            Teachers t2 = new Teachers("Resad", "Memmedli", 24, "resad@example.com", "t2", "IT", "Programming", 750, 8);

            //administrator
            Administrator admin = new Administrator("Rashid", "Ibrahimov", 50, "rashid@example.com", "a1", "Dekan", "IT", 5);


            Console.WriteLine("Students");
            Students[] students = { s1, s2, s3 };
            double totalScholarship = 0;

            foreach (var student in students)
            {
                student.ShowStudentInfo();
                double scholarship = student.CalculateScholarship();
                Console.WriteLine($"Scholarship: {scholarship} AZN\n");
                totalScholarship += scholarship;
            }

            Console.WriteLine("Teachers");
            Teachers[] teachers = { t1, t2 };
            decimal totalSalary = 0;

            foreach (var teacher in teachers)
            {
                teacher.ShowTeacherInfo();
                decimal salary = teacher.CalculateSalary();
                Console.WriteLine($"Salary: {salary} AZN\n");
                totalSalary += salary;
            }
            Console.WriteLine("Administrator");
            admin.ShowAdminInfo();

            Console.WriteLine("Statistics");
            Console.WriteLine($"Total Scholarship Expense: {totalScholarship} AZN");
            Console.WriteLine($"Total Salary Expense: {totalSalary} AZN");
        }
    }
    }
