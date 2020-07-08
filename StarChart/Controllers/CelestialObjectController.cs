using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarChart.Data;

namespace StarChart.Controllers
{
    [Route("")]
    [ApiController]
    public class CelestialObjectController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CelestialObjectController (ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
        [HttpGet("{name}")]
        public IActionResult GetByName(string Name)
        {
            try
            {
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }
    }
}
