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
        Task<Score> GetScoreByID(int scoreId);
        Task<bool> EditScore(Score scoreId);
        Task<bool> InsertScore(Score insertscore);
        Task<bool> DeleteScore(int scoreId);
    }
}
