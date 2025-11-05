using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _17_DirectoryStreamReaderStreamWriterSerializationDeserialization.Models
{
    public class FileManager
    {
        public string FolderPath { get; set; }
        public string TextFilePath { get; set; }
        public string JsonFilePath { get; set; }

        public FileManager()
        {
            FolderPath = "StudentData";
            TextFilePath = Path.Combine(FolderPath, "students.txt");
            JsonFilePath = Path.Combine(FolderPath, "students.json");

        }
        public void CreateFolder()
        {
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
                Console.WriteLine($"Qovluq yaradıldı: {FolderPath}");
            }
        }
        public void DeleteFolder()
        {
            if (Directory.Exists(FolderPath))
            {
                Directory.Delete(FolderPath, true);
                Console.WriteLine($"Qovluq silindi: {FolderPath}");
            }
        }
        public bool CheckFolderExists()
        {
            return Directory.Exists(FolderPath);
        }


        public void WriteStudentToFile(Student student)
        {
            using (StreamWriter writer = new StreamWriter(TextFilePath, true))
            {
                writer.WriteLine(student.ToString());
            }
            Console.WriteLine($"Tələbə fayla yazıldı: {student.Name}");
        }

        public void WriteAllStudentsToFile(List<Student> students)
        {
            File.WriteAllText(TextFilePath, string.Empty);

            using (StreamWriter writer = new StreamWriter(TextFilePath))
            {
                foreach (var s in students)
                {
                    writer.WriteLine(s.ToString());
                }
            }
            Console.WriteLine($"Ümumi {students.Count} tələbə fayla yazıldı.");
        }

        public List<Student> ReadStudentsFromFile()
        {
            List<Student> students = new List<Student>();

            if (!File.Exists(TextFilePath))
            {
                Console.WriteLine("Fayl tapılmadı!");
                return students;
            }

            using (StreamReader reader = new StreamReader(TextFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 5)
                    {
                        int id = int.Parse(parts[0]);
                        string name = parts[1];
                        string surname = parts[2];
                        int age = int.Parse(parts[3]);
                        double grade = double.Parse(parts[4]);
                        students.Add(new Student(id, name, surname, age, grade));
                    }
                }
            }
            Console.WriteLine($"Fayldan {students.Count} telebe oxundu.");
            return students;
        }
        public void SerializeToJson(List<Student> students)
        {
            string json = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(JsonFilePath, json);
            Console.WriteLine($"Telebeler JSON formatında yadda saxlanıldı: {JsonFilePath}");
        }

        public List<Student> DeserializeFromJson()
        {
            List<Student> students = new List<Student>();

            if (!File.Exists(JsonFilePath))
            {
                Console.WriteLine("JSON faylı tapılmadı!");
                return students;
            }

            string json = File.ReadAllText(JsonFilePath);
            students = JsonSerializer.Deserialize<List<Student>>(json);
            Console.WriteLine($"JSON-dan {students.Count} telebe yüklendi.");
            return students;
        }
    }
}
