using MVC_SportGoods.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SportGoods.Models
{
    public class SportViewCategory
    {
        public int id { get; set; }
        public string categoryName { get; set; }

        public string categoryDescription { get; set; }

        public List<SportGoods> SportGoods { get; set; }
    }
}
