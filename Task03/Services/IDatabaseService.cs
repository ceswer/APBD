using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task03.Models;

namespace Task03.Services
{
    public interface IDatabaseService
    {
        public Student GetStudentByID(int ID);
        public void ChangeSomeDataByID(int ID, Student student);
        public void AddStudent(Student student);
        public void RemoveStudentByID(int ID);
    }
}
