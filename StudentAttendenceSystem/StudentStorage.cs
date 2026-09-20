using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace StudentAttendanceSystem
{
    public static class StudentStorage
    {
        private static readonly string FilePath =
            Path.Combine(
                System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.MyDocuments),
                "StudentAttendanceSystem",
                "students.json");

        public static void Save(List<Student> students)
        {
            string folder = Path.GetDirectoryName(FilePath)!;
            Directory.CreateDirectory(folder);

            string json = JsonSerializer.Serialize(students);
            File.WriteAllText(FilePath, json);
        }

        public static List<Student> Load()
        {
            if (!File.Exists(FilePath))
            {
                return new List<Student>();
            }

            string json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<Student>>(json)
                   ?? new List<Student>();
        }
    }
}