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
    public class ScoreRepository: IScoreRepository
    {
        private readonly DataBaseContext _dataBaseContext;
        public ScoreRepository(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }
        public async Task<List<Score>> GetScore()
        {
            return await _dataBaseContext.Scores.ToListAsync();
        }
        public async Task<Score> GetScorebyId(Int64 ScoreId)
        {
            return await _dataBaseContext.Scores.Where(x => x.ScoreId == ScoreId).FirstOrDefaultAsync();
        }

        public bool EditScore(Score EditScoreId)
        {
            var paramT = new DynamicParameters();
            paramT.Add("@ScoreId", EditScoreId.sCore, System.Data.DbType.Int64);
            paramT.Add("@StudentId", EditScoreId.sCore, System.Data.DbType.Int64);
            paramT.Add("@SubjectId", EditScoreId.sCore, System.Data.DbType.Int64);
            paramT.Add("@Score", EditScoreId.sCore, System.Data.DbType.Int32);

            string sqlEdit = "EditScore";
            int Result = -100;
            try
            {
                var sReader = DapperManagerSQL.Instance.Conn.ExecuteReader(sqlEdit, paramT, commandType: CommandType.StoredProcedure);
                while (sReader.Read())
                {
                   
                    Result = sReader["ResultSql"] == null ? 0 : int.Parse(sReader["ResultSql"].ToString());

                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return Result > 0;


        }
        public async Task<bool> InsertScore(Score insertscore)
        {

            var listScore = await _dataBaseContext.Scores.ToListAsync();
            if (listScore != null && listScore.Count > 0)
            {
                if (listScore.Any(e => e.ScoreId == insertscore.ScoreId))
                {
                    return false;
                }

            }
            Score score = new Score()
            {
                ScoreId = insertscore.ScoreId,
                StudentId = insertscore.StudentId,
                SubjectId = insertscore.SubjectId,
                sCore = insertscore.sCore

            };
            try
            {
                _dataBaseContext.Scores.Add(score);
                await _dataBaseContext.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }

        }

        public async Task<bool> DeleteScore(Int64 deleteScoreId)
        {
            try
            {
                var DbListdate = await _dataBaseContext.Scores.FindAsync(deleteScoreId);

                if (DbListdate == null)
                {
                    return false;
                }

                _dataBaseContext.Scores.Remove(DbListdate);
                await _dataBaseContext.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
