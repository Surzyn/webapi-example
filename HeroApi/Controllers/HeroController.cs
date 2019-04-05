using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccess;

namespace HeroApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHeros()
        {
            var heroService = new HeroRepository();
            var heroes = heroService.GetAllHeroes();
            if(heroes.Count == 0)
            {
                return NotFound();
            }
            return Ok(heroes);
        }
    }
}