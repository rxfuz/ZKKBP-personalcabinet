using Foundation;
using UIKit;
using Microsoft.Maui;

namespace PersonalCabinet
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            if (UIDevice.CurrentDevice.CheckSystemVersion(13, 0))
            {
                var statusBar = new UIView(UIApplication.SharedApplication.StatusBarFrame);
                statusBar.BackgroundColor = UIColor.FromRGB(0x1e, 0x3a, 0x5f);
                UIApplication.SharedApplication.KeyWindow?.AddSubview(statusBar);
            }

            return base.FinishedLaunching(application, launchOptions);
        }
    }
}