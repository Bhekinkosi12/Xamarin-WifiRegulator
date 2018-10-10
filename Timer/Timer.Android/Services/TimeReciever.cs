using Android.Net.Wifi;
using Android.App;
using Android.Content;
using Android.Widget;


namespace Alarm_Manager
{
    [BroadcastReceiver]
    public class MyReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
                         
                var wm = Application.Context.GetSystemService(Android.Content.Context.WifiService) as WifiManager;
         

            if ( wm != null )
                {
                    wm.SetWifiEnabled(false);

                    Toast.MakeText(Application.Context, "Wifi Disabled " , ToastLength.Short).Show();
                }

           
        }
    }
}

   