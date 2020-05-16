using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using todolist.Dal;
using todolist.Models;

namespace todolist.Controllers
{
    public class HomeController : Controller
    {
        private ITodoRepository _repository;
        public HomeController(ITodoRepository repository)
        {
           _repository = repository;
        }
        public IActionResult Index()
        {
           // var abc = _repository.GetAll();
            return View();
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
