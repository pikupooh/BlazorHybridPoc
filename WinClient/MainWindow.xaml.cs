using System.Windows;
using BlazorClient.Data;
using Microsoft.Extensions.DependencyInjection;

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
            Resources.Add("services", serviceCollection.BuildServiceProvider());

        }

    }

}
