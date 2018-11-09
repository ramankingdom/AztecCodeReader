using AzTecReader.Common;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AzTecReader.ViewModels
{
    public class LoginVM : BaseVM
    {
        public LoginVM()
        {
            IntitializeCommands();
        }
        #region Properties and Fields
        public string UserId
        {
            get { return _userId; }
            set
            {
                _userId = value;
                OnPropertyChanged(nameof(UserId));
                LoginCommand.RaiseCanExecuteChanged();
            }
        }

        public RelayCommand LoginCommand { get; private set; }
        #endregion

        private void IntitializeCommands()
        {
            LoginCommand = new RelayCommand(OnLoginExecute, CanExecuteLogin);
        }

        private void OnLoginExecute()
        {
            Manager.ShowMainWindow();
        }
        public bool CanExecuteLogin()
        {
            return !string.IsNullOrEmpty(_userId);
        }
    }
}
