using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesBook.Models.Database.Entities;

namespace RecipesBook.Database.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public ICollection<Recipe> Recipes { get; set; }
    }
}
