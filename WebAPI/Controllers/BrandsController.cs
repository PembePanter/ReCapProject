using Business.Abstract;
using Core.Entities;
using Core.Services;
using Entities;
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
    public class BrandsController : ControllerRepositoryBase<Brand, IBrandService>
    {
        public BrandsController(IBrandService service) : base(service)
        {
        }
    }
}
