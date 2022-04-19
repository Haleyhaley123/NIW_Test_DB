using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface IScoreService
    {
        Task<List<Score>> GetScore();
        Task<Score> GetScoreByID(Int64 scoreId);
        Task<bool> EditScore(Score scoreId);
        Task<bool> InsertScore(Score insertscore);
        Task<bool> DeleteScore(Int64 scoreId);
    }
}
