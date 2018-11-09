using AzTecReader.Dialogs;
using AzTecReader.ViewModels;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace AzTecReader
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        [STAThread()]
        static void Main()
        {
            InitializeSimpleIoc();
            App app = new App();
            app.InitializeComponent();
            var windowManager = SimpleIoc.Default.GetInstance<WindowsManager>();
            app.MainWindow = windowManager.GetLoginWindow();
            app.MainWindow.ShowDialog();
            app.Run();
        }

        private static void InitializeSimpleIoc()
        {
            SimpleIoc.Default.Register<WindowsManager>();
            SimpleIoc.Default.Register<SettingsVM>();
            SimpleIoc.Default.Register<LoginVM>();
            SimpleIoc.Default.Register<MainWindowVM>();
        }
    }

}
