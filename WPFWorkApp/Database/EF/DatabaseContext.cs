using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesBook.Database.Entities;
using RecipesBook.Models.Database.Entities;

namespace RecipesBook.Models.Database.Context
{
    public class DatabaseContext: DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DatabaseContext() : base("defaultConnection") { }
    }
}
