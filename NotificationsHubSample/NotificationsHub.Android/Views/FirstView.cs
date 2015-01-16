using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;
using Gcm.Client;

namespace NotificationsHub.Android.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
            RegisterWithGCM();
        }

        private void RegisterWithGCM()
        {
            GcmClient.CheckDevice(this);
            GcmClient.CheckManifest(this);
            GcmClient.Register(this, "<PROJECT ID>");
        }
    }
}