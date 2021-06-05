using RecipesBook.Database.Entities;
using RecipesBook.Models.Database.Base;
using RecipesBook.Models.Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesBook.Database.Repository
{
    public class CategoryRepository : IRepository<Category>
    {
        public ICollection<Category> GetAll()
        {
            using (DatabaseContext ctx = new DatabaseContext())
            {
                return ctx.Categories.ToList();
            }
        }

        public void Save(Category item)
        {
            using (DatabaseContext ctx = new DatabaseContext())
            {
                Category category = ctx.Categories.FirstOrDefault(c => c.Id == item.Id);
                category.Name = item.Name;
                category.Recipes = item.Recipes;

                ctx.SaveChanges();
            }
        }

        public void Add(Category item)
        {
            using(DatabaseContext ctx = new DatabaseContext())
            {
                ctx.Categories.Add(item);

                ctx.SaveChanges();
            }
        }
    }
}
