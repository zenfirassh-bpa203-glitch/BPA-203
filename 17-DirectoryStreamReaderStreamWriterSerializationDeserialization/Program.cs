using _17_DirectoryStreamReaderStreamWriterSerializationDeserialization.Models;

namespace _17_DirectoryStreamReaderStreamWriterSerializationDeserialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
        {
            new Student(1, "Ali", "Memmedov", 20, 85.5),
            new Student(2, "Leyla", "Hesenova", 19, 92.0),
            new Student(3, "Vüqar", "Eliyev", 21, 78.5),
            new Student(4, "Nigar", "Ehmedova", 20, 88.0),
            new Student(5, "Resad", "Quliyev", 22, 95.5)
        };

             Console.WriteLine("=== Telebe Siyahısı ===");
             foreach (var s in students)
             s.DisplayInfo();

               Console.WriteLine("=======================");

            FileManager fm = new FileManager();

            if (fm.CheckFolderExists())
                fm.DeleteFolder();

            fm.CreateFolder();

            Console.WriteLine("\nBir-bir yazma:");
            foreach (var s in students)
                fm.WriteStudentToFile(s);

            Console.WriteLine("\nToplu yazma:");
            fm.WriteAllStudentsToFile(students);


            var readStudents = fm.ReadStudentsFromFile();
            Console.WriteLine("\nOxunan telebeler:");
            foreach (var s in readStudents)
                s.DisplayInfo();

            
            fm.SerializeToJson(students);

            
            var jsonStudents = fm.DeserializeFromJson();
            Console.WriteLine("\nJSON-dan oxunan telebeler:");
            foreach (var s in jsonStudents)
                s.DisplayInfo();


            Console.WriteLine("\n=== students.txt mezmunu ===");
            Console.WriteLine(File.ReadAllText(fm.TextFilePath));

            Console.WriteLine("\n=== students.json mezmunu ===");
            Console.WriteLine(File.ReadAllText(fm.JsonFilePath));

            
            Console.WriteLine("\n=== Statistika ===");
            int total = jsonStudents.Count;
            double avg = 0, max = double.MinValue, min = double.MaxValue;
            int highAchievers = 0;

            foreach (var s in jsonStudents)
            {
                avg += s.Grade;
                if (s.Grade > max) max = s.Grade;
                if (s.Grade < min) min = s.Grade;
                if (s.Grade >= 90) highAchievers++;
            }
            avg /= total;

            FileInfo txtInfo = new FileInfo(fm.TextFilePath);
            FileInfo jsonInfo = new FileInfo(fm.JsonFilePath);

            Console.WriteLine($"Umumi telebe sayı: {total}");
            Console.WriteLine($"Orta qiymet: {avg:F2}");
            Console.WriteLine($"En yüksek qiymet: {max}");
            Console.WriteLine($"En asagı qiymet: {min}");
            Console.WriteLine($"90+ qiymet alan telebe sayı: {highAchievers}");
            Console.WriteLine($"students.txt ölcüsü: {txtInfo.Length} bayt");
            Console.WriteLine($"students.json ölcüsü: {jsonInfo.Length} bayt");
        }
    }
}
