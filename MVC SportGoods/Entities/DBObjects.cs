using MVC_SportGoods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SportGoods.Entities
{
    public class DBObjects
    {
        public static void Initial(DBContent content)
        {

            if (!content.SportViewCategory.Any())
            {
                content.SportViewCategory.AddRange(SportViewCategories.Select(c => c.Value));
            }
            if (!content.SportGoods.Any())
            {
                content.AddRange(
                   new SportsViewModel
                   {
                       name = "М'яч для американського футболу",
                       description = "Select American Football Pro №5 Brown (5703543078905)",
                       img = "/img/М'яч для американського футболу.jpg",
                       price = 812,
                        //= SportViewCategories["Flagman"]
                   },
                    new SportsViewModel
                    {
                        name = "Ракетка настільного тенісу",
                        description = "Atemi 2000 (87274175417)",
                        img = "/img/Ракетка настільного тенісу.jpg",
                        price = 1000,
                        //= SportViewCategories["Flagman"]
                    },
                     new SportsViewModel
                     {
                         name = "Баскетбольное Кольцо",
                         description = "Корзина TARMAK (100 x 48 x 2,3 см) Черное",
                         img = "/img/Баскетбольное Кольцо.jpg",
                         price = 3700,
                         //= SportViewCategories["Flagman"]
                     }
                );
            }
            content.SaveChanges();
        }
        private static Dictionary<string, SportViewCategory> category;
        public static Dictionary<string, SportViewCategory> SportViewCategories
        {
            get
            {
                if (category == null)
                {
                    var list = new SportViewCategory[]
                    {
                        new SportViewCategory { categoryName = "High quality", categoryDescription = "Sport good with hight quality and price" },
                        new SportViewCategory { categoryName = "Low-midl quality", categoryDescription = "Sport good with low or midl quality and midl price" }
                    };
                    category = new Dictionary<string, SportViewCategory>();
                    foreach (SportViewCategory item in list)
                    {
                        category.Add(item.categoryName, item);
                    }
                }
                return category;
            }

        }
    }
}