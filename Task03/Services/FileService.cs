using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Task03.Models;

namespace Task03.Services
{
    public class FileService : IDatabaseService
    {
        public static HashSet<Student> students = new HashSet<Student>(new StudentComparator());

        public void OverwriteFile()
        {
            using var streamWriter = new StreamWriter(Program.file);
            foreach (var student in students)
                streamWriter.WriteLine(student);
        }

        public Student GetStudentByID(int ID)
        { 
            foreach (var student in students)
                if (student.ID.Equals(ID))
                    return student;
            throw new StudentNotFoundException($"There is no such student s{ID}!");
        }

        public void AddStudent(Student student)
        {
            if (!students.Contains(student))
                students.Add(student);
            else throw new StudentAlreadyFoundException($"Student is already in a dataset!");

            OverwriteFile();
        }

        public void RemoveStudentByID(int ID)
        {
            Student wantedStudent = null;
            foreach (var student in students)
                if (student.ID.Equals(ID))
                {
                    wantedStudent = student;
                    students.Remove(wantedStudent);
                }

            if (wantedStudent == null)
                throw new StudentNotFoundException($"There is no such student s{ID}!");

            OverwriteFile();
        }

        public void ChangeSomeDataByID(int ID, Student student)
        {
            Student modifyingStudent = GetStudentByID(ID);

            if (!modifyingStudent.ID.Equals(student.ID))
                throw new NotModyfingPropertyException($"You can not modify your ID!");

            modifyingStudent.Name = student.Name;
            modifyingStudent.Surname = student.Surname;
            modifyingStudent.Birthdate = student.Birthdate;
            modifyingStudent.Study = student.Study;
            modifyingStudent.Mode = student.Mode;
            modifyingStudent.Email = student.Email;
            modifyingStudent.FatherName = student.FatherName;
            modifyingStudent.MotherName = student.MotherName;

            OverwriteFile();
        }
    }
}