using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_SportGoods.Entities;
using MVC_SportGoods.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MVC_SportGoods
{
    public class DBContent : IdentityDbContext<AppUser>
    {
        public DBContent(DbContextOptions<DBContent> options) : base(options)
        {

        }
        public DBContent()
        {

        }
        public DbSet<SportsViewModel> SportGoods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}