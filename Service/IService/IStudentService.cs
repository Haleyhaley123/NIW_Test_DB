using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface IStudentService
    {
        Task<List<Student>> GetStudent();
        Task<Student> GetStudentByID(int studentId);
        Task<bool> EditStudent(Student studentId);
        Task<bool> InsertStudent(Student insertstudent);
        Task<bool> DeleteStudent(int idStudent);
    }    
}
