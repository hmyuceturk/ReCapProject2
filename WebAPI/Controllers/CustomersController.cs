using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpPost("add")]
        public IActionResult Add(Customer entity)
        {
            var result = _customerService.Add(entity);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Customer entity)
        {
            var result = _customerService.Delete(entity);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }
        
        [HttpPost("update")]
        public IActionResult Update(Customer entity)
        {
            var result = _customerService.Update(entity);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpPost("get")]
        public IActionResult Get(int id)
        {
            var result = _customerService.Get(id);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }        
    }
}
