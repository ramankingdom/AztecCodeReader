using AzTecReader.Dialogs;
using AzTecReader.ViewModels;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AzTecReader
{
   public class WindowsManager
    {
        private Lazy<MainWindow> _mainWindowLazy;
        private Lazy<LoginWindow> _loginWindowLazy;
        private Lazy<ConfigurationsWindow> _settingsWindow;

        public LoginWindow GetLoginWindow()
        {

            if (_loginWindowLazy == null)
            {
                _loginWindowLazy = new Lazy<LoginWindow>(LazyThreadSafetyMode.PublicationOnly);
            }
            _loginWindowLazy.Value.DataContext = SimpleIoc.Default.GetInstance<LoginVM>();
            return _loginWindowLazy.Value;
        }
        public ConfigurationsWindow GetSettingsWindow()
        {

            if (_settingsWindow == null)
            {
                _settingsWindow = new Lazy<ConfigurationsWindow>(LazyThreadSafetyMode.PublicationOnly);
            }
            return _settingsWindow.Value;
        }

        public void  ShowMainWindow()
        {
            if (_mainWindowLazy == null)
            {
                _mainWindowLazy = new Lazy<MainWindow>(LazyThreadSafetyMode.PublicationOnly);
            }
            _mainWindowLazy.Value.DataContext = SimpleIoc.Default.GetInstance<MainWindowVM>();
            App.Current.MainWindow = _mainWindowLazy.Value;
            _loginWindowLazy.Value?.Close();
            if (_settingsWindow != null) { _settingsWindow.Value?.Hide(); }
            App.Current.MainWindow.Show();
       }
        public void ShowConfigurationWindows()
        {
            if(_settingsWindow ==null)
            {
                _settingsWindow = new Lazy<ConfigurationsWindow>(LazyThreadSafetyMode.PublicationOnly);
            }
            _settingsWindow.Value.DataContext = SimpleIoc.Default.GetInstance<SettingsVM>();
            _settingsWindow.Value.ShowDialog();
        }

        public void CloseLoginWindow()
        {
            _loginWindowLazy.Value.Close();
        }
        public void CloseMainWindow()
        {
            _mainWindowLazy.Value.Close();
        }
    }
}
