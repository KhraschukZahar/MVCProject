using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SportGoods.ViewModel
{
    public class PostCreateViewModel
    {
        public int id { get; set; }
        [Required]
        [MaxLength(40, ErrorMessage = "Name can`t be longer that 40 symbols")]
        public string name { get; set; }
        [Required]
        [MaxLength(60, ErrorMessage = "Description  can`t be longer that 60 symbols")]
        public string description { get; set; }
        public IFormFile img { get; set; }
        [Required]
        public uint price { get; set; }
    }
}
