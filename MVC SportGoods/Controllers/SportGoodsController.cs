using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_SportGoods.Entities;
using MVC_SportGoods.Entities.Interfaces;
using MVC_SportGoods.Models;

namespace MVC_SportGoods.Controllers
{
    public class SportGoodsController : Controller
    {
        private readonly DBContent _context;
        private readonly IAllSportGoods _postRepository;

        public SportGoodsController(DBContent context, IAllSportGoods postRepository)
        {
            _context = context;
            _postRepository = postRepository;
        }


        [Route("Blog/Post/{id}")]
        public IActionResult SportGood(int id)
        {         
            var post = _postRepository.GetPostById(id);
            return View(post);
        }

        public IActionResult SportsViewModel()
        {
            var posts = _postRepository.GetAllPosts().ToList(); 
            return View(posts);
        }

        [HttpPost]
        public ViewResult Edit()
        {
            return View();
        }
    }
}