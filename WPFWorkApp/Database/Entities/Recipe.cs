using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using RecipesBook.Database.Entities;
using RecipesBook.Models.Database.Base;

namespace RecipesBook.Models.Database.Entities
{
    public class Recipe
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string CookingInstruction { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
