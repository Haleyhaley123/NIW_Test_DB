using Dapper;
using Domain;
using Domain.DBContext;
using Domain.DBDapper;
using Microsoft.EntityFrameworkCore;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    //public class SubjectRepository : ISubjectRepository
    //{
    //    private readonly DataBaseContext _dataBaseContext;
    //    public SubjectRepository(DataBaseContext dataBaseContext)
    //    {
    //        _dataBaseContext = dataBaseContext;
    //    }
    //    public async Task<List<Subject>> GetSubject()
    //    {
    //        return await _dataBaseContext.Subjects.ToListAsync();
    //    }
    //    public async Task<Subject> GetSubjectbyId(int subjectId)
    //    {
    //        return await _dataBaseContext.Subjects.Where(x => x.SubjectId == subjectId).FirstOrDefaultAsync();
    //    }

    //    public bool EditSubject(Subject editSubjectId)
    //    {
    //        var paramT = new DynamicParameters();
    //        paramT.Add("@SubjectId", editSubjectId.SubjectId, System.Data.DbType.String);
    //        paramT.Add("@Name", editSubjectId.Name, System.Data.DbType.String);

    //        string sqlEdit = "sp_SubjectInsert";
    //        int Result = -100;
    //        try
    //        {
    //            var sReader = DapperManagerSQL.Instance.Conn.ExecuteReader(sqlEdit, paramT, commandType: CommandType.StoredProcedure);
    //            while (sReader.Read())
    //            {
    //                // chỉ trường được duy nhất SQL trả về Result = 1
    //                Result = sReader["ResultSql"] == null ? 0 : int.Parse(sReader["ResultSql"].ToString());

    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            return false;
    //        }
    //        return Result > 0;


    //    }
    //    public async Task<bool> InsertSubject(Subject insertsubject)
    //    {

    //        var listSubject = await _dataBaseContext.Scores.ToListAsync();
    //        if (listSubject != null && listSubject.Count > 0)
    //        {
    //            if (listSubject.Any(e => e.ScoreId == insertsubject.SubjectId))
    //            {
    //                return false;
    //            }

    //        }
    //        Subject subject = new Subject()
    //        {
    //            SubjectId = insertsubject.SubjectId,
    //            Name = insertsubject.Name

    //        };
    //        try
    //        {
    //            _dataBaseContext.Subjects.Add(subject);
    //            await _dataBaseContext.SaveChangesAsync();

    //            return true;
    //        }
    //        catch
    //        {
    //            return false;
    //        }

    //    }

    //    public async Task<bool> DeleteSubject(int deletesubject)
    //    {
    //        try
    //        {
    //            var DbListdate = await _dataBaseContext.Subjects.FindAsync(deletesubject);

    //            if (DbListdate == null)
    //            {
    //                return false;
    //            }

    //            _dataBaseContext.Subjects.Remove(DbListdate);
    //            await _dataBaseContext.SaveChangesAsync();

    //            return true;
    //        }
    //        catch (Exception ex)
    //        {
    //            return false;
    //        }
    //    }
    //}
}

