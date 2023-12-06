using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using PizzaTuto.DbContext;
using PizzaTuto.Data;

namespace PizzaTuto.Controllers
{
    [Route("pizzaspecials")]
    public class SpecialsController : Controller
    {
        private readonly ILogger<SpecialsController> _logger;
         private readonly AppDbContext _db;

        public SpecialsController(AppDbContext dbContext ,ILogger<SpecialsController> logger)
        {
            _logger = logger;
            _db = dbContext;
        }

            [HttpGet]
    public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials()
    {
        return (await _db.PizzaSpecials.ToListAsync()).OrderByDescending(s => s.Price).ToList();
    }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}