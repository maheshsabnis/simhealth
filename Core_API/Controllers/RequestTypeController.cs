using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Core_API.Models;
using Core_API.Services;
using Core_API.CustomFilters;

namespace Core_API.Controllers
{
    [Route("api/[controller]/[action]")]
    // [ApiController]
   // [LogFilter] // applied on Controller hence it is available for all action Methods 
    public class RequestTypeController : ControllerBase
    {
        private readonly IDbService<Department, int> serv;

        public RequestTypeController(IDbService<Department, int> serv)
        {
            this.serv = serv;
        }

        [HttpPost]
        [ActionName("PostFromBody")]
        public IActionResult PostFromBody([FromBody]Department department)
        {
            return Ok();
        }

        /// <summary>
        /// https://localhost:5001/api/RequestType/PostFromRoute?DeptNo=33&DeptName=rrr&Location=rr&Capaity=333
        /// </summary>
        /// <param name="DeptNo"></param>
        /// <param name="DeptName"></param>
        /// <param name="Location"></param>
        /// <param name="Capaity"></param>
        /// <returns></returns>
        [HttpPost]
        [ActionName("PostSeperateParameters")]
        public IActionResult PostSeperateParameters(int DeptNo, string DeptName, string Location, int Capaity)
        {
            // Explicitly Map with CLR Object
            var dept = new Department()
            { 
              DeptNo = DeptNo,
              DeptName = DeptName,
              Location = Location,
              Capacity = Capaity
            };
            return Ok();
        }
        [HttpPost]
        [ActionName("PostFromQuery")]
        public IActionResult PostFromQuery([FromQuery] Department department)
        {
            return Ok();
        }

        /// <summary>
        /// Route Expression
        /// https://localhost:5001/api/RequestType/PostFromRoute/{deptno}/{deptname}/{location}/{capacity}
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        /// Route Template
        [HttpPost("{deptno}/{deptname}/{location}/{capacity}")]
        [ActionName("PostFromRoute")]
        public IActionResult PostFromRoute([FromRoute] Department department)
        {
            return Ok();
        }
    }
}
