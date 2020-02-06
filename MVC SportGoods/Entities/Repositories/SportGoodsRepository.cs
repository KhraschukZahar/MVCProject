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

        public IEnumerable<SportsViewModel> SportGoods => dbContent.SportGoods;
    }
}
