using MVC_SportGoods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SportGoods.Entities
{
    public class DBObjects
    {
        public static void DBObjectsData(DBContent content)
        {
            if (!content.SportGoods.Any())
            {
                content.SportGoods.AddRange(
                   new SportsViewModel
                   {
                       name = "М'яч для американського футболу",
                       description = "Select American Football Pro №5 Brown (5703543078905)",
                       img = "/img/М'яч для американського футболу.jpg",
                       price = 812,
                        
                   },
                    new SportsViewModel
                    {
                        name = "Ракетка настільного тенісу",
                        description = "Atemi 2000 (87274175417)",
                        img = "/img/Ракетка настільного тенісу.jpg",
                        price = 1000,
                        
                    },
                     new SportsViewModel
                     {
                         name = "Баскетбольное Кольцо",
                         description = "Корзина TARMAK (100 x 48 x 2,3 см) Черное",
                         img = "/img/Баскетбольное Кольцо.jpg",
                         price = 3700,
                         
                     }
                );
            }
            content.SaveChanges();
        }
    }
}