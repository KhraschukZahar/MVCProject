using Microsoft.EntityFrameworkCore;
using MVC_SportGoods.Entities.Interfaces;
using MVC_SportGoods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SportGoods.Entities.Repositories
{
    public class SportGoodsRepository : IAllSportGoods
    {
        private readonly DBContent dbContent;
        public SportGoodsRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }

        public SportsViewModel CreatePost(SportsViewModel post)
        {
            dbContent.SportGoods.Add(post);
            dbContent.SaveChanges();
            return post;
        }

        public SportsViewModel DeletePost(int Id)
        {
            SportsViewModel post = dbContent.SportGoods.Find(Id);
            if (post != null)
            {
                dbContent.SportGoods.Remove(post);
                dbContent.SaveChanges();
            }
            return post;
        }

        public IEnumerable<SportsViewModel> GetAllPosts()
        {
            return dbContent.SportGoods;
        }

        public SportsViewModel GetPostById(int Id)
        {
            return dbContent.SportGoods.Find(Id);
        }

        public SportsViewModel UpdatePost(SportsViewModel newPost)
        {
            var post = dbContent.SportGoods.Attach(newPost);
            post.State = EntityState.Modified;
            dbContent.SaveChanges();
            return newPost;
        }
    }
}
