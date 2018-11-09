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

namespace AzTecReader.Dialogs
{
    /// <summary>
    /// Interaction logic for ConfigurationsWindow.xaml
    /// </summary>
    public partial class ConfigurationsWindow : Window
    {
        public ConfigurationsWindow()
        {
            InitializeComponent();
        }

        private void Click_Close(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
