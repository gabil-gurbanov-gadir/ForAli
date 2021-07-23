using Microsoft.AspNetCore.Mvc;
using Pizza.DAL;
using Pizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _contex;

        public HomeController(AppDbContext contex)
        {
            _contex = contex;
        }
        public IActionResult Index()
        {
            List<MenuItem> menuItems = _contex.MenuItems.ToList();
            return View(menuItems);
        }
    }
}
