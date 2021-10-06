﻿using Business.Abstract;
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
    public class RentalsController : Controller
    {
        IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpPost("add")]
        public IActionResult Add(Rental entity)
        {
            var result = _rentalService.Add(entity);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Rental entity)
        {
            var result = _rentalService.Delete(entity);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpPost("get")]
        public IActionResult Get(int id)
        {
            var result = _rentalService.Get(id);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _rentalService.GetAll();
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Rental entity)
        {
            var result = _rentalService.Update(entity);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result);
        }
    }
}
