using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_SportGoods.Entities;
using MVC_SportGoods.Entities.Interfaces;
using MVC_SportGoods.Models;
using MVC_SportGoods.ViewModel;

namespace MVC_SportGoods.Controllers
{
    public class SportGoodsController : Controller
    {
        private readonly DBContent _context;
        private readonly IAllSportGoods _postRepository;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly ILogger logger;

        public SportGoodsController(DBContent context, IAllSportGoods postRepository, IHostingEnvironment hostingEnvironment, ILogger<SportGoodsController> logger)
        {
            _context = context;
            _postRepository = postRepository;
            this.hostingEnvironment = hostingEnvironment;
            this.logger = logger;
        }


        [Route("Blog/Post/{id}")]
        public IActionResult SportGood(int id)
        {
            logger.LogTrace("Trace Log");
            logger.LogDebug("Debug Log");
            logger.LogInformation("Information Log");
            logger.LogWarning("Warning Log");
            logger.LogError("Error Log");
            logger.LogCritical("Critical Log");
            var post = _postRepository.GetPostById(id);
            
            if (post == null)
            {
                Response.StatusCode = 404;
                return View("PostNotFound", id);
            }

            return View(post);
        }

        public IActionResult SportsViewModel()
        {
            var posts = _postRepository.GetAllPosts().ToList();
            return View(posts);
        }

        public IActionResult Delete(int id)
        {
            var post = _postRepository.GetPostById(id);
            if (post.img != null)
            {

                string filePath = Path.Combine(hostingEnvironment.WebRootPath, "img", post.img);
                System.IO.File.Delete(filePath);
            }
            _postRepository.DeletePost(id);
            return RedirectToAction("SportsViewModel");

        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            SportsViewModel post = _postRepository.GetPostById(id);
            PostEditViewModel postEditViewModel = new PostEditViewModel
            {
                Id = post.id,
                name = post.name,
                description = post.description,
                price = post.price,
                ExistImgPath = post.img
            };
            return View(postEditViewModel);
        }

        [HttpPost]
        public IActionResult Edit(PostEditViewModel model)
        {

            if (ModelState.IsValid)
            {
                SportsViewModel post = _postRepository.GetPostById(model.Id);
                post.name = model.name;
                post.description = model.description;
                post.price = model.price;             

                if (model.img != null)
                {
                    if (model.ExistImgPath != null)
                    {
                        string filePath = Path.Combine(hostingEnvironment.WebRootPath, "img", model.ExistImgPath);
                        System.IO.File.Delete(filePath);
                    }
                    post.img = UploadedFile(model);
                }

                _postRepository.UpdatePost(post);
                return RedirectToAction("SportsViewModel");
            }
            return View();
        }

        private string UploadedFile(PostEditViewModel model)
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
            return uniqFileName;
        }
    }
}