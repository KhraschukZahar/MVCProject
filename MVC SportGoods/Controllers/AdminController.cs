using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MVC_SportGoods.Entities.Interfaces;
using MVC_SportGoods.Models;
using MVC_SportGoods.ViewModel;

namespace MVC_SportGoods.Controllers
{
    public class AdminController : Controller
    {
        private IAllSportGoods _postRep;
        private IHostingEnvironment hostingEnvironment;

        public AdminController(IAllSportGoods postRep, IHostingEnvironment hostingEnvironment)
        {
            _postRep = postRep;
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Admin()
        {
            return View();
        }
        public IActionResult PostEditor(int postID)
        {
            return View();
        }

        [HttpGet]
        public ViewResult CreatePost()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost(PostCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqFileName = null;
                if (model.img != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "img");
                    uniqFileName = Guid.NewGuid().ToString() + "_" + model.img.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        model.img.CopyTo(fileStream);
                    }
                }
                SportsViewModel newPost = new SportsViewModel
                {
                    name = model.name,
                    description = model.description,               
                    price = model.price,
                    img = uniqFileName
                };
                _postRep.CreatePost(newPost);
                return RedirectToRoute(new { controller = "SportGoods", action = "SportGood", id = newPost.id });
            }
            return View();
        }
    }
}