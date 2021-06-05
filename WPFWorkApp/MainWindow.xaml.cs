using ControlzEx.Theming;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RecipesBook.Models.Application.Windows;
using RecipesBook.Models.Database.Base;
using RecipesBook.Models.Database.Context;
using RecipesBook.Models.Database.Entities;
using RecipesBook.Models.Database.Repository;
using RecipesBook.Models.ViewModels;
using RecipesBook.ViewModels.Models;
using RecipesBook.Models;

namespace RecipesBook
{
    public partial class MainWindow : MetroWindow
    {
        MainWindowViewModel viewModel = new MainWindowViewModel();
        public MainWindow()
        {
            InitializeComponent();
            ThemeManager.Current.ChangeTheme(this, "Light.Blue");
            DataContext = viewModel;
        }

        private void LBRecipes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(LBRecipes.SelectedIndex != -1)
            {
                RecipeViewModel recipe = LBRecipes.SelectedItem as RecipeViewModel;
                EditInfo editInfo = new EditInfo(recipe, this);

                editInfo.ShowDialog();

                LBRecipes.ItemsSource = viewModel.Recipes;
            }

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            EditInfo editInfo = new EditInfo(this);

            editInfo.ShowDialog();

            LBRecipes.ItemsSource = viewModel.Recipes;
        }

        private void TBtnDarkTheme_Toggled(object sender, RoutedEventArgs e)
        {
            Brush lightBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0078D7"));
            Brush darkBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0078A0"));

            if (TBtnDarkTheme.IsOn)
            {
                ThemeManager.Current.ChangeTheme(this, "Dark.Blue");
                BtnAdd.Background = darkBrush;
                BtnDelete.Background = darkBrush;
                
            }
            else
            {
                ThemeManager.Current.ChangeTheme(this, "Light.Blue");
                BtnAdd.Background = lightBrush;
                BtnDelete.Background = lightBrush;
                
            }
        }

        private void LBMenuCategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var id = (LBMenuCategories.SelectedItem as CategoryViewModel).Id.ToString();

            LBRecipes.ItemsSource = viewModel.Recipes.Where(r => r.CategoryId == id).ToList();
        }
    }
}
