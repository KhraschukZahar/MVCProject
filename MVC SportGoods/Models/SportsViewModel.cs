using MVC_SportGoods.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SportGoods.Models
{
    public class SportsViewModel
    {
        public int id { get; set; }
        [Required]
        [MaxLength(20,ErrorMessage ="Name cant be longer that 20 symbols")]
        public string name { get; set; }
        [Required]
        public string description { get; set; }

        public string img { get; set; }
        public uint price { get; set; }

    }
}   

