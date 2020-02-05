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
                   new SportGoods
                   {
                       name = "Samsung S10",
                       description = "Best phone by Samsung",
                       img = "/img/samsung_galaxy_s10_6_128_gb_white.jpg",
                       price = 23000,
                        //= SportViewCategories["Flagman"]
                   },
                    new SportGoods
                    {
                        name = "Samsung S10",
                        description = "Best phone by Samsung",
                        img = "/img/samsung_galaxy_s10_6_128_gb_white.jpg",
                        price = 23000,
                        //= SportViewCategories["Flagman"]
                    },
                     new SportGoods
                     {
                         name = "Samsung S10",
                         description = "Best phone by Samsung",
                         img = "/img/samsung_galaxy_s10_6_128_gb_white.jpg",
                         price = 23000,
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