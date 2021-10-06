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
    public class ColorsController : EntityController<IColorService,Color>
    {
        IColorService _colorService;

        public ColorsController(IColorService colorService):base(colorService)
        {
            _colorService = colorService;
        }

        [HttpPost("getcolorbyid")]
        public IActionResult GetColorById(int id)
        {
            var result = _colorService.GetColorById(id);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }
    }
}
