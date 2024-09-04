using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Threading;

using KB.OpticalReader.SyncfusionApp.Contracts.Services;
using KB.OpticalReader.SyncfusionApp.Contracts.Views;
using KB.OpticalReader.SyncfusionApp.Models;
using KB.OpticalReader.SyncfusionApp.Services;
using KB.OpticalReader.SyncfusionApp.Views;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace KB.OpticalReader.SyncfusionApp
{
    internal static class Program
    {
        public static IHost _host;

        public static T GetService<T>()
            where T : class
            => _host.Services.GetService(typeof(T)) as T;


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            OnStartup();
            Application.Run();
            _host.Dispose();
            _host = null;
        }

        private static async void OnStartup()
        {
            var appLocation = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            // For more information about .NET generic host see  https://docs.microsoft.com/aspnet/core/fundamentals/host/generic-host?view=aspnetcore-3.0
            _host = Host.CreateDefaultBuilder()
                    .ConfigureAppConfiguration(c =>
                    {
                        c.SetBasePath(appLocation);
                    })
                    .ConfigureServices(ConfigureServices)
                    .Build();

            await _host.RunAsync();
            
        }

        private static void ConfigureServices(HostBuilderContext context, IServiceCollection services)
        {
            // TODO WTS: Register your services, viewmodels and pages here

            // App Host
            services.AddHostedService<ApplicationHostService>();

            // Core Services

            // Services
            services.AddSingleton<IPageService, PageService>();
            services.AddSingleton<INavigationService, NavigationService>();

            // Views
            services.AddTransient<IShellWindow, ShellWindow>();

            services.AddTransient<MainPage>();

            services.AddTransient<ChartsPage>();

            services.AddTransient<DataGridPage>();

            services.AddTransient<SpreadsheetPage>();

            // Configuration
            services.Configure<AppConfig>(context.Configuration.GetSection(nameof(AppConfig)));
        }
        
    }
}
