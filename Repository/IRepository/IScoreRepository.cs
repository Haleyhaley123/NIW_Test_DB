using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface IScoreRepository
    {
        Task<List<Score>> GetScore();
        Task<Score> GetScorebyId(Int64 ScoreId);
        bool EditScore(Score EditScoreId);
        Task<bool> InsertScore(Score insertscore);
        Task<bool> DeleteScore(Int64 deleteScoreId);
    }
}
