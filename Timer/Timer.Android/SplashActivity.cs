using Android.App;
using Android.OS;

namespace Timer.Droid
{
    [Activity(Theme ="@style/Theme.Splash",
        MainLauncher =true,
        NoHistory =true,
        Icon = "@drawable/wifi12")]
    
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));

            // Create your application here
        }
    }
}