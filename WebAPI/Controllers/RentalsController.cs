using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        private IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _rentalService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getrentalbyid")]
        public IActionResult GetRentalById(int id)
        {
            var result = _rentalService.GetRentalById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet("getalldetails")]
        public IActionResult GetAllDetails()
        {
            var result = _rentalService.GetRentalDetails();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Rental rental)
        {
            var result = _rentalService.Add(rental);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Update(Rental rental)
        {
            var result = _rentalService.Add(rental);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpDelete("update")]
        public IActionResult Delete(Rental rental)
        {
            var result = _rentalService.Delete(rental);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

    }
}
