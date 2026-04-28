using Android.App;
using Android.Content.PM;
using Android.OS;

namespace PersonalCabinet
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Зміна кольору рядка стану (фіолетова лінія зверху)
            if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop && Window != null)
            {
                Window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#1e3a5f"));
            }
        }
    }
}