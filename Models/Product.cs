﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWEB.Models
{
    public class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        
        public int Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public ICollection<Category>? Categories { get; set; } = default!;
    }
}
