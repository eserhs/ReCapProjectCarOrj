using Business.Abstract;
using Entities.Corcretes;
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
    public class ImageCarController : ControllerBase
    {
        IImageService _ımageService;

        public ImageCarController(IImageService ımageService)
        {
            _ımageService = ımageService;
        }

        [HttpGet("getimagebycarid")]
        public IActionResult  getbyId(int ımageId)
        {
            var result = _ımageService.GetByCarId(ımageId);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);

        }
        [HttpGet("getallimages")]
        public IActionResult getall()
        {
            var result = _ımageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult add([FromForm(Name = "Image")] IFormFile file, [FromForm] ImageCar ımageCar)
        {
            var result = _ımageService.Add(file, ımageCar);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        


    }
}
