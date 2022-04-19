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
        Task<Subject> GetSubjectById(Int64 subjectId);
        Task<bool> EditSubject(Subject subjectId);
        Task<bool> InsertSubject(Subject insertsubject);
        Task<bool> DeleteSubject(Int64 subjectId);
    }
}
