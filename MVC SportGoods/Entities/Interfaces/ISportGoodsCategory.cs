using MVC_SportGoods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SportGoods.Entities.Interfaces
{
    public interface ISportGoodsCategory
    {
        IEnumerable<SportViewCategory> AllSportViewCategories { get; }
    }
}
