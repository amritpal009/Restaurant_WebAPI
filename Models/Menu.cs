using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_WebAPI.Models
{
    public class Menu
    {
        [Key]
        public int id { get; set; }
        public string Dish_Name { get; set; }
        public string Dietary_Restrictions { get; set; }
        public int Rating { get; set; }
        public int Price { get; set; }
        
    }
}
