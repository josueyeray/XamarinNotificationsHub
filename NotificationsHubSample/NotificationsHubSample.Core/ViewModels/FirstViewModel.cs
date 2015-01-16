using Cirrious.MvvmCross.ViewModels;
using System.Windows.Input;

namespace NotificationsHubSample.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private MvxCommand registerNotificationChannelCommand;

        public FirstViewModel()
        {
            this.registerNotificationChannelCommand = new MvxCommand(GetNotificationChannelExecute);
        }

        public ICommand RegisterNotificationCHannelCommand
        {
            get { return this.registerNotificationChannelCommand; }
        }

        private void GetNotificationChannelExecute()
        {

        }
    }
}
