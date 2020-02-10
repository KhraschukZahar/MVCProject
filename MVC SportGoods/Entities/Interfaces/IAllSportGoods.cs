using MVC_SportGoods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SportGoods.Entities.Interfaces
{
    public interface IAllSportGoods
    {
        SportsViewModel GetPostById(int id);
        IEnumerable<SportsViewModel> GetAllPosts();
        SportsViewModel CreatePost(SportsViewModel post);
        SportsViewModel UpdatePost(SportsViewModel newPost);
        SportsViewModel DeletePost(int Id);
    }
}
