using System;
using Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface  IStudentRepository
    {
        Task<List<Student>> GetStudent();
        Task<Student> GetStudentByID(Int64 studentId);
        bool EditStudent(Student studentId);
        Task<bool> InsertStudent(Student insertstudent);
        Task<bool> DeleteStudent(Int64 idStudent);
    }
}
