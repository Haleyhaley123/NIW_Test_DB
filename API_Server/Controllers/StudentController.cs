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
    public class StudentController : APIController
    {
        private readonly IStudentService _iStudentService;
        public StudentController(IStudentService iStudentService)
        {
            _iStudentService = iStudentService;
        }
        [HttpGet]
        [Route("GetAllStudent")]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [Consumes("application/json")]
        public async Task<ActionResult<RequestBase<List<Student>>>> GetAllStudent()
        {
            var requestBase = new RequestBase<List<Student>>();
            try
            {
                var result = await _iStudentService.GetStudent();
                if (result != null)
                {
                    requestBase = RequestOK<List<Student>>(result);
                }
                else
                {
                    requestBase = NotFound<List<Student>>();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ServerError:{ex.Message}");
                requestBase = ServerError<List<Student>>();
            }
            return requestBase;
        }
        [HttpGet]
        [Route("GetPeople")]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [Consumes("application/json")]
        public async Task<ActionResult<RequestBase<Student>>> GetStudent(int studentId)
        {
            var requestBase = new RequestBase<Student>();
            try
            {
                var result = await _iStudentService.GetStudentByID(studentId);
                if (result != null)
                {
                    requestBase = RequestOK<Student>(result);
                }
                else
                {
                    requestBase = NotFound<Student>();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"ServerError:{ex.Message}");
                requestBase = ServerError<Student>();
            }
            return requestBase;
        }
        [HttpPut]
        [Route("EditStudent")]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [Consumes("application/json")]
        public async Task<ActionResult<RequestBase<bool>>> EditStudent(Student studentId)
        {
            var requestBase = new RequestBase<bool>();
            try
            {
                var result = await _iStudentService.EditStudent(studentId);
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
        [Route("InsertStudent")]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [Consumes("application/json")]
        public async Task<ActionResult<RequestBase<bool>>> InsertData(Student insertstudent)
        {
            if (insertstudent == null || insertstudent.StudentId < 0)
            {
                return BadRequest<bool>();
            }
            var requestBase = new RequestBase<bool>();
            try
            {
                var result = await _iStudentService.InsertStudent(insertstudent);
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
        [Route("DeleteData")]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [Consumes("application/json")]
        public async Task<ActionResult<RequestBase<bool>>> DeleteData(int idStudent)
        {
            var requestBase = new RequestBase<bool>();
            try
            {
                var result = await _iStudentService.DeleteStudent(idStudent);
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

