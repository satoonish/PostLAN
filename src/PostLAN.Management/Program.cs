using Kamishibai;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PostLAN.Management.ViewModels.Pages;
using PostLAN.Management.ViewModels.Pages.Address;
using PostLAN.Management.ViewModels.Pages.Settings;
using PostLAN.Management.ViewModels.Windows;
using PostLAN.Management.Views.Pages;
using PostLAN.Management.Views.Pages.Address;
using PostLAN.Management.Views.Pages.Settings;
using PostLAN.Management.Views.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostLAN.Management
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create a builder by specifying the application and main window.
            var builder = KamishibaiApplication<App, MainWindow>.CreateBuilder();

            builder.Services.AddPresentation<MainWindow, MainWindowViewModel>();
            builder.Services.AddPresentation<DashboardPage, DashboardViewModel>();
            builder.Services.AddPresentation<AddressPage, AddressPageViewModel>();
            builder.Services.AddPresentation<SettingsPage, SettingsPageViewModel>();

            // Build and run the application.
            var app = builder.Build();
            app.RunAsync();
        }
    }
}
