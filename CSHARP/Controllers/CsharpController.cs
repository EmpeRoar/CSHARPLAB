using CSHARP.DB;
using CSHARP.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSHARP.Controllers
{
    /// <summary>
    /// This is a Csharp Controller
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class CsharpController : ControllerBase
    {
        AppDbContext _ctx;
        public CsharpController(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        /// <summary>
        ///  Get Dogs
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("dogs")]
        public async Task<IActionResult> GetDogs()
        {
            return Ok(await GetAnimals(_ctx.Dog).ToListAsync());
        }

        /// <summary>
        /// Get Cats
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("cats")]
        public async Task<IActionResult> GetCats()
        {
            return Ok(await GetAnimals(_ctx.Cat).ToListAsync());
        }

        /// <summary>
        /// Get Animals to save your precious time...
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="q"></param>
        /// <returns></returns>
        public IQueryable<T> GetAnimals<T>(IQueryable<T> q) where T : class
        {
            q = q.Wherex();
            return q;
        }

    }
}
