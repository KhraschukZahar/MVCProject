using MVC_SportGoods.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SportGoods.Models
{
    public class SportsViewModel
    {
        public int id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public string img { get; set; }
        public uint price { get; set; }

    }
}   

