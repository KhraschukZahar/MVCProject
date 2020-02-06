using MVC_SportGoods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SportGoods.Entities.Interfaces
{
    public interface IAllSportGoods
    {
        IEnumerable<SportsViewModel> SportGoods { get; }
    }
}
