using SportGoods.Main.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_SportGoods.Entities;
using MVC_SportGoods.Models;

namespace MVC_SportGoods
{
    public class DBContent : DbContext
    {
        public DbSet<SportGoods> SportGoods { get; set; }
        public DbSet<SportViewCategory> SportViewCategory { get; set; }
    }
}