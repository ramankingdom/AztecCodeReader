using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ZXing;
using System.Windows.Media;
using AzTecReader.Common;
using System.Windows;
using System.Runtime.InteropServices;
using System.Windows.Media.Imaging;
using System.IO;
using AzTecReader.Properties;
using AzTecReader.WebApiClient;

namespace AzTecReader.ViewModels
{
    public class MainWindowVM : BaseVM
    {
        public MainWindowVM()
        {
            InitializeEvents();
            InitializeFields();
            InitializeCommands();

        }


        #region Properties and Fields
        private BarcodeReader barcodeReader = new BarcodeReader();

        private string _scannedCode;
        public string ScannedCode
        {
            get { return _scannedCode; }
            set
            {
                _scannedCode = value;
                OnPropertyChanged(nameof(ScannedCode));
                SendCommand.RaiseCanExecuteChanged();
            }

        }
        private string _request;
        public string Request
        {
            get { return _request; }
            set
            {
                _request = value;
                OnPropertyChanged(nameof(Request));
            }
        }

        private string _response;
        public string Response
        {
            get { return _response; }
            set
            {
                _response = value;
                OnPropertyChanged(nameof(Response));
            }
        }
        public string UserId
        {
            get { return _userId; }
        }

        private bool _isCamStarted;
        public bool IsCamStarted
        {
            get { return _isCamStarted; }
            set
            {
                _isCamStarted = value;
                RefreshCamCommands();
            }
        }

        private void RefreshCamCommands()
        {
            ScanCommand.RaiseCanExecuteChanged();
            StartCommand.RaiseCanExecuteChanged();
            StopCommand.RaiseCanExecuteChanged();
            RefreshCommand.RaiseCanExecuteChanged();
        }

        #endregion

        public RelayCommand<ICamMethods> ScanCommand { get; private set; }
        public RelayCommand<ICamMethods> StartCommand { get; private set; }
        public RelayCommand<ICamMethods> StopCommand { get; private set; }
        public RelayCommand SendCommand { get; private set; }
        public RelayCommand<ICamMethods> RefreshCommand { get; private set; }
        public RelayCommand SettingsCommand { get; private set; }

        #region Methods
        private void InitializeFields()
        {
            _scannedCode = string.Empty;
            Request = Settings.Default.Url;
        }
        public void InitializeEvents()
        {
            Properties.Settings.Default.PropertyChanged -= Default_PropertyChanged;
            Properties.Settings.Default.PropertyChanged += Default_PropertyChanged;
        }
        private void Default_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals(nameof(Settings.Default.Url)))
            {
                Request = Settings.Default.Url;
            }
        }


        private void InitializeCommands()
        {
            ScanCommand = new RelayCommand<ICamMethods>(OnScanCommandExecute, CanExecuteScanCommand);
            StartCommand = new RelayCommand<ICamMethods>(OnStartCommandExecute, CanExecuteStartCommand);
            StopCommand = new RelayCommand<ICamMethods>(OnStopCommandExecute, CanExecuteStopCommand);
            SendCommand = new RelayCommand(OnSendCommandExecute, CanEexecuteSendCommand);
            RefreshCommand = new RelayCommand<ICamMethods>(OnRefreshCommandExecute);
            SettingsCommand = new RelayCommand(OnSettingsCommandExecute);
        }

        private void OnSettingsCommandExecute()
        {
            Manager.ShowConfigurationWindows();
        }

        private void OnRefreshCommandExecute(ICamMethods camMethods)
        {
            OnStopCommandExecute(camMethods);
            OnStartCommandExecute(camMethods);
        }

        private void OnStartCommandExecute(ICamMethods camMethods)
        {
            try
            {
                camMethods.Start();
                IsCamStarted = true;
            }
            catch (Exception ex)
            {
                IsCamStarted = false;
            }
        }

        private async void OnSendCommandExecute()
        {
            Response = await Proxy.SendScannedCode(Request);
        }

        private void OnStopCommandExecute(ICamMethods camMethods)
        {
            try
            {
                camMethods.Stop();
                IsCamStarted = false;
            }
            catch (Exception)
            {


            }
        }

        private void OnScanCommandExecute(ICamMethods camMethods)
        {
            try
            {
                ScannedCode = string.Empty;
                using (Bitmap bitmap = camMethods.GetBitmap())
                {
                    ScannedCode = barcodeReader.Decode(bitmap).Text;
                    UpdateRequest();
                }
            }
            catch (Exception ex)
            {
                ScannedCode = AppConstants.ERROR;
            }

        }
        private void UpdateRequest()
        {
            Request = Settings.Default.Url.Replace(AppConstants.USER, _userId);
            Request = Request.Replace(AppConstants.SCANNED_CODE_AZ, ScannedCode);
        }
        public bool CanExecuteScanCommand(ICamMethods camMethods)
        {
            return IsCamStarted;
        }
        public bool CanExecuteStartCommand(ICamMethods camMethods)
        {
            return !IsCamStarted;
        }
        public bool CanExecuteStopCommand(ICamMethods camMethods)
        {
            return IsCamStarted;
        }
        public bool CanEexecuteSendCommand()
        {
            return !(string.IsNullOrEmpty(ScannedCode) && ScannedCode.Equals(AppConstants.ERROR));
        }
        #endregion
    }
}
