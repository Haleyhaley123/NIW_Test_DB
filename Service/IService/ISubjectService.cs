using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface ISubjectService
    {
        Task<List<Subject>> GetSubject();
        Task<Subject> GetSubjectByID(int subjectId);
        Task<bool> EditScore(Subject subjectId);
        Task<bool> InsertScore(Subject insertsubject);
        Task<bool> DeleteScore(int subjectId);
    }
}
