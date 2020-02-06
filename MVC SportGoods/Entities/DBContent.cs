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
        public DBContent(DbContextOptions<DBContent> options) : base(options)
        {

        }
        public DbSet<SportsViewModel> SportGoods { get; set; }
        public DbSet<SportViewCategory> SportViewCategory { get; set; }
    }
}