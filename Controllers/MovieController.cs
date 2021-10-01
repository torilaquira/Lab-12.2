using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab12_2.Models;


namespace Lab12_2.Controllers
{
    [Route("api/movie")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        [HttpGet("readall")]
        public List<movie> readall()
        {
            return DAL.ReadAllMovies();
        }

        [HttpGet("readone")]
        public movie readonemovie(string id)
        {
            movie result = DAL.ReadOneMovie(id);
            return result;
        }

        [HttpDelete("delete")]
        public bool deletemovie(string id)
        {
            return DAL.DeleteMovie(id);
        }

        [HttpPost("add")]
        public movie addEmployee(movie emp)
        {
            return DAL.AddMovie(emp);
        }

        [HttpPut("update")]
        public movie updateEmployee(movie emp)
        {
            return DAL.Updatemovie(emp);
        }


    }
}
