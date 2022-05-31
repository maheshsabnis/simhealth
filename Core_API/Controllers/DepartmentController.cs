using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Core_API.Models;
using Core_API.Services;
using System;

namespace Core_API.Controllers
{
    /// <summary>
    /// Attributes: 
    /// 1.Route: This will be used to register the Controller with its action method in RouteTable
    /// e.g. api/Department, The request HttpGet will map with Get() method, HttpPost wil map with Post() method, HttpPut will map with Put() and HttpDelete will ap with Delete() method
    /// Note: DEfault is always HttpGet 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDbService<Department, int> deptServ;

        /// <summary>
        /// Inject the IDbService in the COnstructor, this will extract an instance
        /// of the class which implements IDbService<Department,int>
        /// </summary>
        public DepartmentController(IDbService<Department, int> serv)
        {
            deptServ = serv;
        }
        /// <summary>
        /// IActionResult: Interface provided in ASP.NET Core MVC and API
        /// for sending response for HTTP REquest
        /// </summary>
        /// <returns></returns>
        /// 
        [HttpGet]
        public IActionResult Get()
        {
            var response = deptServ.Get();
            return Ok(response);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        { 
            var response = deptServ.Get(id);
            return Ok(response);
        }
        [HttpPost]
        public IActionResult Post(Department data)
        {
            //try
            //{
                // Check for the Model Validations
                // if yes accept
                if (ModelState.IsValid)
                {
                    // throw exception based on condition
                    if (data.Capacity < 0) throw new Exception("Capacity Cannot be -ve");
                    var response = deptServ.Create(data);
                    return Ok(response);
                }
                else
                {
                    // else generate validation error response
                    return BadRequest(ModelState);
                }
            //}
            //catch (Exception ex)
            //{
            //    // Catch the exception  and return BAdRequest response
            //    return BadRequest(ex.Message);
            //}
            
        }
        [HttpPut]
        public IActionResult Put(int id, Department data)
        {
            if (ModelState.IsValid)
            {
                var response = deptServ.Update(id, data);
                return Ok(response);
            }
            else
            {
                // else generate validation error response
                return BadRequest(ModelState);
            }
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var response = deptServ.Delete(id);
            return Ok(response);
        }
    }
}
