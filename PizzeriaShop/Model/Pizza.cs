﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
namespace Model
{
    public class Pizza 
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<Comment> Comments { get; set; }

        public Pizza()
        {
            Id = Guid.NewGuid();
        }

        [NotMapped]
        public Decimal Price
        {
            get
            {
                return Ingredients.Sum(i => i.Price) + 5;
            }
            set
            {
                Price = value;

            }
        }
    }
}
