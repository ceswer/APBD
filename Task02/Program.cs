using Main.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Main
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logList = new List<Object>();

            var data = args[0];
            var output = args[1];
            var extension = args[2];

            if (String.IsNullOrEmpty(data) && String.IsNullOrEmpty(output) && String.IsNullOrEmpty(extension))
            {
                throw new ArgumentException("Please enter the arguments!");
            }

            var fileInfo = new FileInfo(data);

            var dataList = new List<string>();

            using (var streamReader = new StreamReader(fileInfo.OpenRead()))
            {
                string line = null;
                while ((line = streamReader.ReadLine()) != null)
                {
                    dataList.Add(line);
                }
            }

            var studentHashSet = new HashSet<Student>(new StudentComparator());
            
            foreach (var line in dataList)
            {
                string[] props = line.Split(",");
                bool isNotWhite = true;
                foreach (var p in props)
                {
                    if (string.IsNullOrEmpty(p))
                    {
                        isNotWhite = false;
                    }
                }
                var student = new Student()
                {
                    Name = props[0],
                    Surname = props[1],
                    Department = props[2],
                    Mode = props[3],
                    Number = int.Parse(props[4]),
                    DateOfBirth = DateTime.Parse(props[5]),
                    Email = props[6],
                    Alina = props[7],
                    Adam = props[8]
                };
                if (isNotWhite && !studentHashSet.Contains(student))
                {
                    studentHashSet.Add(student);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(student);
                } else
                {
                    logList.Add(student);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(student);
                    // throw new DublicatedStudentException($"Student is already added! {student}");
                }
            }

            Console.ForegroundColor = ConsoleColor.White;

            University university = new University("PJWSTK", studentHashSet);

            switch (extension) 
            {
                case "xml":
                    using (var writer = new StreamWriter(output))
                    {
                        var xmlSerializer = new XmlSerializer(university.GetType());
                        xmlSerializer.Serialize(writer, university);
                    }
                    break;

                case "json":
                    using(var writer = new StreamWriter(output))
                    {
                        // https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-how-to?pivots=dotnet-5-0
                        // var jsonSerializer = JsonSerializer.Serialize(university);
                        var json = JsonConvert.SerializeObject(university, Formatting.Indented);
                        writer.Write(json);
                    }
                    break;
            }

            // all errors are written to log.txt

            using(var writer = new StreamWriter("Sources\\log.txt"))
            {
                foreach (var log in logList)
                {
                    writer.WriteLine(log);
                }
            }
        }
    }
}
