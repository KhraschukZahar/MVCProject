using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_SportGoods.Entities;
using MVC_SportGoods.Models;

namespace MVC_SportGoods.Controllers
{
    public class SportGoodsController : Controller
    {
        private readonly DBContent _context;
        public SportGoodsController(DBContent context)
        {
            _context = context;
        }
        public IActionResult SportsViewModel()
        {
            List<SportsViewModel> posts = _context.SportGoods.ToList();
            return View(posts);
        }
    }
}