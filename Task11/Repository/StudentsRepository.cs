using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task11.Models;

namespace Task11.Repository
{
    public class StudentsRepository : IStudentsRepository
    { 
        public static List<Student> Students = new List<Student>()
        {
            new Student 
            {
                ID = 1,
                URLToPhoto = "https://www.shareicon.net/data/512x512/2016/07/03/790265_people_512x512.png",
                FirstName = "Sample",
                LastName = "Student",
                BirthDate = DateTime.Now.AddYears(-22),
                Studies = "Managment"
            },

            new Student
            {
                ID = 2,
                URLToPhoto = "https://www.shareicon.net/data/512x512/2016/07/03/790265_people_512x512.png",
                FirstName = "Jan",
                LastName = "Kowalski",
                BirthDate = DateTime.Now.AddYears(-21),
                Studies = "Computer Sience"
            },

            new Student
            {
                ID = 3,
                URLToPhoto = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRIXIrqiW3R5OstWAjkuFvNwvjYHRaTmwEQWg&usqp=CAU",
                FirstName = "Piotr",
                LastName = "Jakowski",
                BirthDate = DateTime.Now.AddYears(-23),
                Studies = "Digital Systems"
            },
            
            new Student
            {
                ID = 4,
                URLToPhoto = "https://cdn1.iconfinder.com/data/icons/user-pictures/100/female1-512.png",
                FirstName = "Lolla",
                LastName = "Shmidt",
                BirthDate = DateTime.Now.AddYears(-24),
                Studies = "Computer Sience"
            },

            new Student
            {
                ID = 5,
                URLToPhoto = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRIXIrqiW3R5OstWAjkuFvNwvjYHRaTmwEQWg&usqp=CAU",
                FirstName = "Adam",
                LastName = "Niejeski",
                BirthDate = DateTime.Now.AddYears(-34),
                Studies = "Digital Systems"
            },

            new Student
            {
                ID = 6,
                URLToPhoto = "https://cdn1.iconfinder.com/data/icons/user-pictures/100/female1-512.png",
                FirstName = "Karolina",
                LastName = "Olewska",
                BirthDate = DateTime.Now.AddYears(-22),
                Studies = "Computer Sience"
            }
        };

        public void DeleteStudent(int ID)
        {
            var student = FindStudent(ID);

            if (student != null)
                Students.Remove(student);
        }

        public Student FindStudent(int ID) => Students.Find(student => student.ID == ID);

    }
}
