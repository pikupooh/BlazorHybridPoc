using System.Windows;
using BlazorClient.Data;
using Microsoft.Extensions.DependencyInjection;
using RazorSharedLibrary.NativeClientInterfaces;
using WinClient.NativeSupport;

namespace WinClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfBlazorWebView();
            serviceCollection.AddSingleton<WeatherForecastService>();
            serviceCollection.AddSingleton<IShowDialogBox, ShowDialogBox>();
            Resources.Add("services", serviceCollection.BuildServiceProvider());

        }

    }

}
