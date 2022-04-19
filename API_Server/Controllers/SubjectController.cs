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
    public class SubjectController : APIController
    {
        private readonly ISubjectService _iSubjectService;
        public SubjectController(ISubjectService iSubjectService)
        {
            _iSubjectService = iSubjectService;
        }
        [HttpGet]
        [Route("GetAllSubject")]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [Consumes("application/json")]
        public async Task<ActionResult<RequestBase<List<Subject>>>> GetSubject()
        {
            var requestBase = new RequestBase<List<Subject>>();
            try
            {
                var result = await _iSubjectService.GetSubject();
                if (result != null)
                {
                    requestBase = RequestOK<List<Subject>>(result);
                }
                else
                {
                    requestBase = NotFound<List<Subject>>();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ServerError:{ex.Message}");
                requestBase = ServerError<List<Subject>>();
            }
            return requestBase;
        }
        [HttpGet]
        [Route("GetSubject")]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [Consumes("application/json")]
        public async Task<ActionResult<RequestBase<Subject>>> GetSubjectById(Int64 subjectId)
        {
            var requestBase = new RequestBase<Subject>();
            try
            {
                var result = await _iSubjectService.GetSubjectById(subjectId);
                if (result != null)
                {
                    requestBase = RequestOK<Subject>(result);
                }
                else
                {
                    requestBase = NotFound<Subject>();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ServerError:{ex.Message}");
                requestBase = ServerError<Subject>();
            }
            return requestBase;
        }
        [HttpPut]
        [Route("EditSubject")]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [Consumes("application/json")]
        public async Task<ActionResult<RequestBase<bool>>> EditSubject(Subject subjectId)
        {
            var requestBase = new RequestBase<bool>();
            try
            {
                var result = await _iSubjectService.EditSubject(subjectId);
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
        [Route("InsertSubject")]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [Consumes("application/json")]
        public async Task<ActionResult<RequestBase<bool>>> InsertSubject(Subject insertsubject)
        {
            if (insertsubject == null || insertsubject.SubjectId < 0)
            {
                return BadRequest<bool>();
            }
            var requestBase = new RequestBase<bool>();
            try
            {
                var result = await _iSubjectService.InsertSubject(insertsubject);
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
        [Route("DeleteSubject")]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [Consumes("application/json")]
        public async Task<ActionResult<RequestBase<bool>>> DeleteSubject(Int64 subjectId)
        {
            var requestBase = new RequestBase<bool>();
            try
            {
                var result = await _iSubjectService.DeleteSubject(subjectId);
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
