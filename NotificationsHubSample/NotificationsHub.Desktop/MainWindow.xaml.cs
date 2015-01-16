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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.ServiceBus.Notifications;

namespace NotificationsHub.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Send_Windows(object sender, RoutedEventArgs e)
        {
            NotificationHubClient hub = NotificationHubClient.CreateClientFromConnectionString("<FULL ENDPOINT>", "nhsampledemo");
            var toast = @"<toast><visual><binding template=""ToastText01""><text id=""1"">Hello from a .NET App!</text></binding></visual></toast>";
            await hub.SendWindowsNativeNotificationAsync(toast);
        }

        private async void Send_Android(object sender, RoutedEventArgs e)
        {
            NotificationHubClient hub = NotificationHubClient.CreateClientFromConnectionString("<FULL ENDPOINT>", "nhsampledemo");
            var message = "{ \"data\" : {\"msg\":\"Hello from Azure!\"}}";
            var result = await hub.SendGcmNativeNotificationAsync(message);
        }

        private async void Send_iOS(object sender, RoutedEventArgs e)
        {
            NotificationHubClient hub = NotificationHubClient.CreateClientFromConnectionString("<FULL ENDPOINT>", "nhsampledemo");
            var alert = "{\"aps\":{\"alert\":\"Hello from .NET!\"}}";
            await hub.SendAppleNativeNotificationAsync(alert);
        }
    }
}
