using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_SportGoods.Entities
{
    [Table("tblSportGoods")]
    public class SportGoods
    {
        public int id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public string img { get; set; }
        public uint price { get; set; }


    }
}
