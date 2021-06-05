using RecipesBook.Models.Database.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RecipesBook.ViewModels.Models
{
    public class CategoryViewModel : INotifyPropertyChanged, ICloneable
    {
        public int Id { get; set; }
        private string name = string.Empty;
        public ICollection<Recipe> Recipes { get; set; }

        public string Name
        {
            get => name;
            set
            {
                if(!value.Equals(name))
                {
                    name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public object Clone()
        {
            return new CategoryViewModel
            {
                Id = this.Id,
                Name = this.Name,
                Recipes = this.Recipes
            };
        }

        public void Copy(CategoryViewModel category)
        {
            Id = category.Id;
            Name = category.Name;
            Recipes = category.Recipes;
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
