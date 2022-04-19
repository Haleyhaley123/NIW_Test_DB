using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface ISubjectRepository
    {
        Task<List<Subject>> GetSubject();
        Task<Subject> GetSubjectbyID(int subjectId);
        bool EditSubject(Subject editSubjectId);
        Task<bool> InsertSubject(Subject insertsubject);
        Task<bool> DeleteSubject(int deletesubject);
    }
}
