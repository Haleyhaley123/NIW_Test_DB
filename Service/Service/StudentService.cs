using Domain;
using Repository.IRepository;
using Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class StudentService: IStudentService
    {
        private readonly IStudentRepository _iStudentRepository;
        public StudentService(IStudentRepository iStudentRepository)
        {
            _iStudentRepository = iStudentRepository;
        }
        public async Task<List<Student>> GetStudent()
        {
            return await _iStudentRepository.GetStudent();
        }
        public async Task<Student> GetStudentByID(int studentId)
        {
            return await _iStudentRepository.GetStudentByID(studentId);
        }
        public async Task<bool> EditStudent(Student studentId)
        {
            return _iStudentRepository.EditStudent(studentId);
        }
        public async Task<bool> InsertStudent(Student insertstudent)
        {
            return await _iStudentRepository.InsertStudent(insertstudent);
        }
        public async Task<bool> DeleteStudent(int idStudent)
        {
            return await _iStudentRepository.DeleteStudent(idStudent);
           
        }
    }
}

