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
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository _iSubjectRepository;
        public SubjectService(ISubjectRepository iSubjectRepository)
        {
            _iSubjectRepository = iSubjectRepository;
        }
        public async Task<List<Subject>> GetSubject()
        {
            return await _iSubjectRepository.GetSubject();
        }
        public async Task<Subject> GetSubjectById(Int64 subjectId)
        {
            return await _iSubjectRepository.GetSubjectbyId(subjectId);
        }
        public async Task<bool> EditSubject(Subject editSubjectId)
        {
            return _iSubjectRepository.EditSubject(editSubjectId);
        }
        public async Task<bool> InsertSubject(Subject insertsubject)
        {
            return await _iSubjectRepository.InsertSubject(insertsubject);
        }
        public async Task<bool> DeleteSubject(Int64 deletesubject)
        {
            return await _iSubjectRepository.DeleteSubject(deletesubject);

        }
    }
}

