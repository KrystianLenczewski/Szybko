using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using beka.Data;
using beka.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

namespace beka.Controllers
{
    public class QuestionController : Controller
    {
        private readonly ApplicationDbContext _context;

        public QuestionController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string Create(int id,Question question)
        {
            var test = _context.Tests.Find(id);
            var model = new Question
            {
                Name = question.Name,
                Test = test

            };
            _context.Add(model);
            _context.SaveChanges();
            var newModal = new Question
            {
                Id = model.Id,
                Name = model.Name

            };

            String jsonResult = JsonConvert.SerializeObject(newModal);
            return jsonResult;
        }
    }
}
