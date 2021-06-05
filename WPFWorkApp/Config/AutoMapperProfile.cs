using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipesBook.Models.Database.Entities;
using RecipesBook.ViewModels.Models;
using RecipesBook.Database.Entities;

namespace RecipesBook.Config
{
    class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Recipe, RecipeViewModel>();
            CreateMap<RecipeViewModel, Recipe>();
            CreateMap<Category, CategoryViewModel>();
            CreateMap<CategoryViewModel, Category>();
        }
    }
}
