using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using RecipesBook.Database.Entities;
using RecipesBook.Database.Repository;
using RecipesBook.Models.Commands;
using RecipesBook.Models.Database.Entities;
using RecipesBook.Models.Database.Repository;
using RecipesBook.Models.Extensions;
using RecipesBook.ViewModels.Models;

namespace RecipesBook.Models.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private AutoMapperBase autoMapper;
        private RecipeRepository recipeRepos;
        private CategoryRepository categoryRepos;
        #region Data
        public ObservableCollection<RecipeViewModel> Recipes { get; set; }
        public ObservableCollection<CategoryViewModel> Categories { get; set; }


        private RecipeViewModel selectedRecipe;
        public RecipeViewModel SelectedRecipe
        {
            get => selectedRecipe;
            set
            {
                selectedRecipe = value;
                if(value != null) EditRecipe = value.Clone() as RecipeViewModel;
                OnPropertyChanged(nameof(SelectedRecipe));
            }
        }

        private RecipeViewModel newRecipe;
        public RecipeViewModel NewRecipe
        {
            get => newRecipe;
            set
            {
                newRecipe = value;
                OnPropertyChanged(nameof(NewRecipe));
            }
        }

        private RecipeViewModel editRecipe;
        public RecipeViewModel EditRecipe
        {
            get => editRecipe;
            set
            {
                editRecipe = value;
                OnPropertyChanged(nameof(EditRecipe));
            }
        }

        #endregion

        #region Commands
        private ActionCommand removeCommand;
        public ActionCommand RemoveCommand
        {
            get => removeCommand ?? (removeCommand = new ActionCommand(obj =>
            {
                RecipeViewModel recipe = obj as RecipeViewModel;
                var idx = Recipes.IndexOf(recipe);
                Recipes.Remove(recipe);

                if (Recipes.Count > 0 && idx != -1)
                {
                    if (idx == Recipes.Count - 1)
                    {
                        SelectedRecipe = Recipes.Last();
                    }

                    else if (idx == 0)
                    {
                        SelectedRecipe = Recipes.First();
                    }
                    else
                    {
                        SelectedRecipe = Recipes[idx - 1];
                    }
                }
            }));
        }

        private ActionCommand addCommand;
        public ActionCommand AddCommand
        {
            get => addCommand ?? (addCommand = new ActionCommand(obj =>
            {
                RecipeViewModel recipe = (obj as RecipeViewModel).Clone() as RecipeViewModel;
                recipe.Id = Recipes.Count > 0 ? Recipes.Max(a => a.Id) + 1 : 1;
                Recipes.Add(recipe);
                SelectedRecipe = recipe;
            }));
        }

        private ActionCommand editCommand;
        public ActionCommand EditCommand
        {
            get => editCommand ?? (editCommand = new ActionCommand(obj =>
            {
                RecipeViewModel recipe = obj as RecipeViewModel;
                RecipeViewModel srchRecipe = Recipes.First(a => a.Id == recipe.Id);
                srchRecipe.Copy(recipe);

                Recipe dbRecipe = autoMapper.Mapper.Map<Recipe>(recipe);
                recipeRepos.Save(dbRecipe);
            }));
        }
        #endregion

        public MainWindowViewModel()
        {
            newRecipe = new RecipeViewModel();
            autoMapper = AutoMapperBase.Instance;
            recipeRepos = new RecipeRepository();
            categoryRepos = new CategoryRepository();

            LoadDataFromDatabase();
        }

        private void LoadDataFromDatabase()
        {
            var dbRecipes = recipeRepos.GetAll().ToList();
            Recipes = autoMapper.Mapper.Map<ObservableCollection<RecipeViewModel>>(dbRecipes);

            var dbCategories = categoryRepos.GetAll().ToList();
            Categories = autoMapper.Mapper.Map<ObservableCollection<CategoryViewModel>>(dbCategories);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
