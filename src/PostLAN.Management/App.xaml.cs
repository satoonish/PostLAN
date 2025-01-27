using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PostLAN.Management.Views.Windows;
using System.Configuration;
using System.Data;
using System.IO;
using System.Windows;

namespace PostLAN.Management
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }
    }

}
