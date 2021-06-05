using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesBook.Models.Database.Base;
using RecipesBook.Models.Database.Context;
using RecipesBook.Models.Database.Entities;

namespace RecipesBook.Models.Database.Repository
{
    public class RecipeRepository : IRepository<Recipe>
    {
        public ICollection<Recipe> GetAll()
        {
            using (DatabaseContext ctx = new DatabaseContext())
            {
                return ctx.Recipes.ToList();
            }
        }

        public void Save(Recipe item)
        {
            using (DatabaseContext ctx = new DatabaseContext())
            {
                Recipe recipe = ctx.Recipes.FirstOrDefault(r => r.Id == item.Id);
                recipe.ImagePath = item.ImagePath;
                recipe.Name = item.Name;
                recipe.Ingredients = item.Ingredients;
                recipe.CookingInstruction = item.CookingInstruction;

                ctx.SaveChanges();
            }
        }

        public void Add(Recipe item)
        {
            using (DatabaseContext ctx = new DatabaseContext())
            {
                ctx.Recipes.Add(item);
                ctx.Categories.Attach(item.Category);

                ctx.SaveChanges();
            }
        }
    }
}
