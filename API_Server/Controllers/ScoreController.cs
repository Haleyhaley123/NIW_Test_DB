using Domain;
using Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.IService;
using System.Diagnostics;
using System.Net;

namespace API_Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreController : APIController
    {
        private readonly IScoreService _iScoreService;
        public ScoreController(IScoreService iScoreService)
        {
            _iScoreService = iScoreService;
        }
        [HttpGet]
        [Route("GetAllCore")]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [Consumes("application/json")]
        public async Task<ActionResult<RequestBase<List<Score>>>> GetAllStudent()
        {
            var requestBase = new RequestBase<List<Score>>();
            try
            {
                var result = await _iScoreService.GetScore();
                if (result != null)
                {
                    requestBase = RequestOK<List<Score>>(result);
                }
                else
                {
                    requestBase = NotFound<List<Score>>();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ServerError:{ex.Message}");
                requestBase = ServerError<List<Score>>();
            }
            return requestBase;
        }
        [HttpGet]
        [Route("GetScore")]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [Consumes("application/json")]
        public async Task<ActionResult<RequestBase<Score>>> GetStudent(int scoreId)
        {
            var requestBase = new RequestBase<Score>();
            try
            {
                var result = await _iScoreService.GetScoreByID(scoreId);
                if (result != null)
                {
                    requestBase = RequestOK<Score>(result);
                }
                else
                {
                    requestBase = NotFound<Score>();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ServerError:{ex.Message}");
                requestBase = ServerError<Score>();
            }
            return requestBase;
        }
        [HttpPut]
        [Route("EditScore")]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [Consumes("application/json")]
        public async Task<ActionResult<RequestBase<bool>>> EditScore(Score scoreId)
        {
            var requestBase = new RequestBase<bool>();
            try
            {
                var result = await _iScoreService.EditScore(scoreId);
                if (result)
                {
                    requestBase = RequestOK<bool>(result);
                }
                else
                {
                    requestBase = NotFound<bool>();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ServerError:{ex.Message}");
                requestBase = ServerError<bool>();
            }
            return requestBase;
        }
        [HttpPost]
        [Route("InsertScore")]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [Consumes("application/json")]
        public async Task<ActionResult<RequestBase<bool>>> InsertScore(Score insertscore)
        {
            if (insertscore == null || insertscore.StudentId < 0)
            {
                return BadRequest<bool>();
            }
            var requestBase = new RequestBase<bool>();
            try
            {
                var result = await _iScoreService.InsertScore(insertscore);
                if (result)
                {
                    requestBase = RequestOK<bool>(result);
                }
                else
                {
                    requestBase = NotFound<bool>();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ServerError:{ex.Message}");
                requestBase = ServerError<bool>();
            }
            return requestBase;
        }
        [HttpDelete]
        [Route("DeleteScore")]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [Consumes("application/json")]
        public async Task<ActionResult<RequestBase<bool>>> DeleteScore(int scoreId)
        {
            var requestBase = new RequestBase<bool>();
            try
            {
                var result = await _iScoreService.DeleteScore(scoreId);
                if (result)
                {
                    requestBase = RequestOK<bool>(result);
                }
                else
                {
                    requestBase = NotFound<bool>();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ServerError:{ex.Message}");
                requestBase = ServerError<bool>();
            }
            return requestBase;
        }
    }
}
