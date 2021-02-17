using Business.Abstract;
using Entities;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerRepositoryBase<Car, ICarService>
    {

        ICarService _carservice;
        public CarsController(ICarService service) : base(service)
        {
            _carservice = service;
        }
        [HttpGet("getcarsbybrandid")]

        public IActionResult GetCarsByBrandId(int brandId)
        {
            var result = _carservice.GetCarsByBrandId(brandId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcarsbycolorid")]

        public IActionResult GetCarsByColorId(int colorId)
        {
            var result = _carservice.GetCarsByColorId(colorId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcardetails")]
        public IActionResult GetCarDetails()
        {
            var result = _carservice.GetCarDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
