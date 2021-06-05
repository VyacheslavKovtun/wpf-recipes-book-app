using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using RecipesBook.Database.Entities;
using RecipesBook.Models.Database.Entities;

namespace RecipesBook.ViewModels.Models
{
    public class RecipeViewModel : INotifyPropertyChanged, ICloneable
    {
        public int Id { get; set; }
        private string imagePath = string.Empty;
        private string name = string.Empty;
        private string ingredients = string.Empty;
        private string cookingInstruction = string.Empty;
        public string CategoryId { get; set; }
        public Category Category { get; set; }

        public string ImagePath
        {
            get => imagePath;
            set
            {
                if (!value.Equals(imagePath))
                {
                    imagePath = value;
                    OnPropertyChanged(nameof(ImagePath));
                }
            }
        }
        public string Name
        {
            get => name;
            set
            {
                if (!value.Equals(name))
                {
                    name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
        public string Ingredients
        {
            get => ingredients;
            set
            {
                if (!value.Equals(ingredients))
                {
                    ingredients = value;
                    OnPropertyChanged(nameof(Ingredients));
                }
            }
        }
        public string CookingInstruction
        {
            get => cookingInstruction;
            set
            {
                if (!value.Equals(cookingInstruction))
                {
                    cookingInstruction = value;
                    OnPropertyChanged(nameof(CookingInstruction));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public object Clone()
        {
            return new RecipeViewModel
            {
                Id = this.Id,
                ImagePath = this.ImagePath,
                Name = this.Name,
                Ingredients = this.Ingredients,
                CookingInstruction = this.CookingInstruction,
                CategoryId = this.CategoryId,
                Category = this.Category
            };
        }

        public void Copy(RecipeViewModel recipe)
        {
            Id = recipe.Id;
            ImagePath = recipe.ImagePath;
            Name = recipe.Name;
            Ingredients = recipe.Ingredients;
            CookingInstruction = recipe.CookingInstruction;
            CategoryId = recipe.CategoryId;
            Category = recipe.Category;
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
