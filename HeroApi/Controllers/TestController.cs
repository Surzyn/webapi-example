using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        //[HttpGet]
        //public IActionResult GetTest()
        //{
        //    return Ok("Udało sie");
        //}

        [HttpGet("{id}")]
        public IActionResult GetTest(int id)
        {
            if(id == 21)
            {
                return Created("https://localhost:44324/api/21", 21);
            }

            return Ok("Id requestu: " + id);
        }

        //[HttpGet("{id}")]
        //public string GetByName(int id,string name, string foo)
        //{
        //    return "name param " + name + foo;
        //}

        [HttpPost]
        public int PostTest([FromBody] Hero hero)
        {
            //zapisywanie zasobu w bazie

            return 5;
        }

        [HttpPut("{id}")]
        public int PutTest(int id, [FromBody] Hero hero)
        {
            return 2;
        }

        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return true;
        }

    }
}
