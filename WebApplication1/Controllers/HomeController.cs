using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Db_context;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            coreContext DB = new coreContext();
            var data = DB.EmpDtls.ToList();
            DB.SaveChanges();
            return View(data);

          
        }

        public ActionResult Delete(int id)
        {
            coreContext DB = new coreContext();
            var dateledata = DB.EmpDtls.Where(m => m.EmpId == id).First();
            DB.EmpDtls.Remove(dateledata);
            DB.SaveChanges();




            return RedirectToAction("Index");
        }





        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
