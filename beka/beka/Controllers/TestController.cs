using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using beka.Data;
using beka.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace beka.Controllers
{
    public class TestController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TestController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            

            return View();
        }

        [HttpPost]
        public string Create(Test test)
        {
           
            _context.Add(test);
            _context.SaveChanges();

            String jsonResult = JsonConvert.SerializeObject(test);
            return jsonResult;
        }

        public string GetTestById(int id)
        {
            var model = _context.Tests.Find(id);
            String jsonResult = JsonConvert.SerializeObject(model);
            return jsonResult;
            
        }
    }
}
