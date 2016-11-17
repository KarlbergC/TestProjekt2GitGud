using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnimalFarm.Models.ViewModels;
using AnimalFarm.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AnimalFarm.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var viewModel = DataManager.GetHomeIndexVM();
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(HomeCreateVM viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            DataManager.CreateAnimal(viewModel);
            return RedirectToAction(nameof(HomeController.Index));
        }
    }
}
