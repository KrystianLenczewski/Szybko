using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using beka.Models;
using beka.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using beka.GenericRepositories;

namespace beka.Controllers
{
    public class HomeController : Controller
    {

        private readonly IRepository<Departament> _genericRepositoryDepartament;
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context, IRepository<Departament> genericRepositoryDepartament)
        {
            _context = context;
            _genericRepositoryDepartament = genericRepositoryDepartament;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string GetAllDepartament()
        {
            var departament = _genericRepositoryDepartament.GetAll();

            String jsonResult = JsonConvert.SerializeObject(departament);
            return jsonResult;
        }
        public ActionResult GetDepartamentPartial(int? id)
        {
            var departament = _context.Departaments.Find(id) ?? new Departament();
            return PartialView("_CreateOrUpdatePartialView", departament);
        }

        [HttpPost]
        public ActionResult CreateOrUpdateDepartament(Departament departament)
        {
           if(departament.Id>0)
            {
                _context.Update(departament);
               
            }
           else
            {
                _context.Departaments.Add(departament);
              
            }
            _context.SaveChanges();
            return Json(true);
            
          
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Delete(int id)
        {
            try
            {
                var departament = _context.Departaments.Find(id);
                _context.Departaments.Remove(departament);
                _context.SaveChanges();
                return Json(true);
            }
            catch (Exception)
            {

                return Json(false);
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
