using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Date_MVVM.Model;
using Date_MVVM.ViewModel;

namespace Date_MVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            MainWindow app = new MainWindow();
            PersonViewModel context = new PersonViewModel();
            app.DataContext = context;
            app.Show();
        }
    }
}
