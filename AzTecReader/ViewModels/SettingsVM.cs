using AzTecReader.Common;
using AzTecReader.Properties;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzTecReader.ViewModels
{
    public class SettingsVM:BaseVM
    {
        public SettingsVM()
        {
            IntitializeProperties();
            IntitializeCommands();
        }

        private string _apiUrl;
        public string ApiUrl
        {
            get { return _apiUrl; }
            set
            {
                _apiUrl = value;
                OnPropertyChanged(nameof(ApiUrl));
            }
        }
        public RelayCommand SaveCommand { get; private set; }

        private void IntitializeCommands()
        {
            SaveCommand = new RelayCommand(OnSaveCommandExecute);

        }

        private void OnSaveCommandExecute()
        {
            Settings.Default.Url = ApiUrl;
            Settings.Default.Save();
            Manager.ShowMainWindow();
        }

        private void IntitializeProperties()
        {
            ApiUrl = Settings.Default.Url;
        }

    }
}
