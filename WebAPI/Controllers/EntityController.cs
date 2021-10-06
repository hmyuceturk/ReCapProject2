using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class EntityController<TService,TEntity> : Controller
        where TService:IEntityService<TEntity>
    {
        TService _service;

        public EntityController(TService carService)
        {
            _service = carService;
        }

        [HttpPost("add")]
        public IActionResult Add(TEntity entity)
        {
            var result = _service.Add(entity);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(TEntity entity)
        {
            var result = _service.Delete(entity);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpPost("get")]
        public IActionResult Get(int id)
        {
            var result = _service.Get(id);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _service.GetAll();
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(TEntity entity)
        {
            var result = _service.Update(entity);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }
    }
}
