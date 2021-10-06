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
    public class RentalsController : EntityController<IRentalService, Rental>
    {
        public RentalsController(IRentalService rentalService) : base(rentalService)
        {
        }


    }
}
