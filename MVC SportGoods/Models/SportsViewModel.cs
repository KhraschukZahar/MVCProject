﻿using Microsoft.AspNetCore.Http;
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
        [MaxLength(50,ErrorMessage ="Name can`t be longer that 50 symbols")]
        public string name { get; set; }
        [Required]
        [MaxLength(60, ErrorMessage = "Description  can`t be longer that 60 symbols")]
        public string description { get; set; }
        public string img { get; set; }
        [Required]
        public uint price { get; set; }

    }
}   

