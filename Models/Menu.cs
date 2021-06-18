using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_WebAPI.Models
{
    public class Menu
    {
        [Key]//primary key
        public int id { get; set; }
        public string Dish_Name { get; set; }//name of dish
        public string Dietary_Restrictions { get; set; }//name  of dietary restrictions
        public int Rating { get; set; }//dish rating
        public int Price { get; set; }// dish price
        
    }
}
