using ControlzEx.Theming;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using RecipesBook.Models.Database.Entities;
using RecipesBook.Models.Database.Repository;
using RecipesBook.Models.ViewModels;
using RecipesBook.ViewModels.Models;

namespace RecipesBook.Models.Application.Windows
{
    public partial class EditInfo : MetroWindow
    {
        public RecipeViewModel Recipe { get; set; }
        MainWindow parent;
        MainWindowViewModel viewModel = new MainWindowViewModel();

        public EditInfo(MainWindow parent) 
        {
            InitializeComponent();
            DataContext = viewModel;
            this.parent = parent;
            CheckState();
            CheckTheme();
        }

        private void CheckTheme()
        {
            Brush lightBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0078D7"));
            Brush darkBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0078A0"));

            if (parent.TBtnDarkTheme.IsOn)
            {
                ThemeManager.Current.ChangeTheme(this, "Dark.Blue");
                BtnAdd.Background = darkBrush;
                BtnSave.Background = darkBrush;
                BtnCancel.Background = darkBrush;
                TBtnDarkTheme.IsOn = true;
            }
            else 
            {
                ThemeManager.Current.ChangeTheme(this, "Light.Blue");
                BtnAdd.Background = lightBrush;
                BtnSave.Background = lightBrush;
                BtnCancel.Background = lightBrush;
                TBtnDarkTheme.IsOn = false;
            }
        }

        private void CheckState()
        {
            if(Recipe == null)
            {
                BtnAdd.Visibility = Visibility.Visible;
                BtnSave.Visibility = Visibility.Hidden;
            }
            else
            {
                BtnAdd.Visibility = Visibility.Hidden;
                BtnSave.Visibility = Visibility.Visible;
            }
        }

        public EditInfo(RecipeViewModel recipe, MainWindow parent)
        {
            InitializeComponent();
            DataContext = viewModel;
            Recipe = recipe;
            viewModel.EditRecipe = Recipe;
            viewModel.NewRecipe = Recipe;

            this.parent = parent;
            CheckState();
            CheckTheme();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            parent.Hide();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            parent.Show();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void TBtnDarkTheme_Toggled(object sender, RoutedEventArgs e)
        {
            Brush lightBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0078D7"));
            Brush darkBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0078A0"));

            if (TBtnDarkTheme.IsOn)
            {
                ThemeManager.Current.ChangeTheme(this, "Dark.Blue");
                BtnAdd.Background = darkBrush;
                BtnSave.Background = darkBrush;
                BtnCancel.Background = darkBrush;
            }
            else
            {
                ThemeManager.Current.ChangeTheme(this, "Light.Blue");
                BtnAdd.Background = lightBrush;
                BtnSave.Background = lightBrush;
                BtnCancel.Background = lightBrush;
            }
        }
    }
}
