using Task11.Models;

namespace Task11.Repository
{
    public interface IStudentsRepository
    {
        Student FindStudent(int ID);
        void DeleteStudent(int ID);
    }
}
