using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_DirectoryStreamReaderStreamWriterSerializationDeserialization.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        public Student(int id, string name, string surname, int age, double grade)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
            Grade = grade;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Surname: {Surname}, Age: {Age}, Grade: {Grade}");
        }
        public override string ToString()
        {
            return $"{Id},{Name},{Surname},{Age},{Grade}";
        }
    }
}
