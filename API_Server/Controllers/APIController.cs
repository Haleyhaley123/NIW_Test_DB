using Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace API_Server.Controllers
{
    public class APIController : ControllerBase
    {
        public APIController()
        {
        }
        protected RequestBase<TRequest> RequestOK<TRequest>(TRequest data)
        {
            return new RequestBase<TRequest>()
            {
                Data = data,
                Success = true,
                StatusCode = (int)HttpStatusCode.OK,
                Message = "Success"
            };
        }
        protected RequestBase<TRequest> BadRequest<TRequest>()
        {
            return new RequestBase<TRequest>()
            {
                Success = false,
                StatusCode = (int)HttpStatusCode.BadRequest,
                Message = "Data is incorrect"
            };
        }
        protected RequestBase<TRequest> NotFound<TRequest>()
        {
            return new RequestBase<TRequest>()
            {
                Success = true,
                StatusCode = (int)HttpStatusCode.NotFound,
                Message = "Data not found"
            };
        }
        protected RequestBase<TRequest> ServerError<TRequest>()
        {
            return new RequestBase<TRequest>()
            {
                Success = false,
                StatusCode = (int)HttpStatusCode.InternalServerError,
                Message = "server error"
            };
        }
    }
}

