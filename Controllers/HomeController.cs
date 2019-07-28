using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PieShop.Models;
using PieShop.Repositories;
using PieShop.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            this.pieRepository = pieRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            IEnumerable<Pie> pies = this.pieRepository.GetAll().OrderBy(p => p.Name);

            HomeViewModel homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to Bethanny's Pie Shop",
                Pies = pies.ToList()
            };

            return View(homeViewModel);
        }
    }
}
