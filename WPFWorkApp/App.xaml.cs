using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using RecipesBook.Models.Database.Base;

namespace RecipesBook
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            System.Data.Entity.Database.SetInitializer(new DatabaseInitializer()); ;
        }
    }
}
