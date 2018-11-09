using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzTecReader.Common
{
    public class BaseVM : INotifyPropertyChanged
    {
        public WindowsManager Manager
        {
            get
            {
                return SimpleIoc.Default.GetInstance<WindowsManager>();
            }
        }
        protected static string _userId;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
