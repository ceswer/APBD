using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using Task03.Models;
using Task03.Services;

namespace Task03
{
    public class Program
    {
        public static string file = "Data/Students.csv";
        
        public static void Main(string[] args)
        {
            var fileInfo = new FileInfo(file);
            using (var streamReader = new StreamReader(fileInfo.OpenRead()))
            {
                string line = null;
                while (null != (line = streamReader.ReadLine()))
                {
                    string[] properties = line.Split(",");
                    var student = new Student()
                    {
                        Name = properties[0],
                        Surname = properties[1],
                        ID = int.Parse(properties[2]),
                        Birthdate = DateTime.Parse(properties[3]),
                        Study = properties[4],
                        Mode = properties[5],
                        Email = properties[6],
                        FatherName = properties[7],
                        MotherName = properties[8]
                    };
                    FileService.students.Add(student);
                }
            }

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
