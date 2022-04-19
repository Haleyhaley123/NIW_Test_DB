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
    public class ScoreService : IScoreService
    {
        private readonly IScoreRepository _iScoreRepository;
        public ScoreService(IScoreRepository iScoreRepository)
        {
            _iScoreRepository = iScoreRepository;
        }
        public async Task<List<Score>> GetScore()
        {
            return await _iScoreRepository.GetScore();
        }
        public async Task<Score> GetScoreByID(Int64 scoreId)
        {
            return await _iScoreRepository.GetScorebyId(scoreId);
        }
        public async Task<bool> EditScore(Score scoreId)
        {
            return _iScoreRepository.EditScore(scoreId);
        }
        public async Task<bool> InsertScore(Score insertscore)
        {
            return await _iScoreRepository.InsertScore(insertscore);
        }
        public async Task<bool> DeleteScore(Int64 scoreId)
        {
            return await _iScoreRepository.DeleteScore(scoreId);
        }
    }
}
