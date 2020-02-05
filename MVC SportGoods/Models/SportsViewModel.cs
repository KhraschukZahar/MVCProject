using MVC_SportGoods.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SportGoods.Models
{
    public class SportsViewModel
    {
        public IEnumerable<SportGoods> allSportGoods { get; set; }

    }
}   

