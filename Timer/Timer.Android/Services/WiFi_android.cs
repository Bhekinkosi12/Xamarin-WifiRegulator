using Wifi.Interfaces;
using Wifi.Droid.Renderers;
using Android.Widget;
using Java.Lang;
using Android.Content;
using Android.App;
using Alarm_Manager;

[assembly: Xamarin.Forms.Dependency (typeof (WIFI_Android))]
namespace Wifi.Droid.Renderers 
{
    public class WIFI_Android : IWIFI_INT
    {
       

        public void Switchwifi(int number)
        {
          
            Intent i = new Intent(Application.Context, typeof(MyReceiver));
           
            PendingIntent pi = PendingIntent.GetBroadcast(Application.Context, 0, i, 0);
                        try
            {
                AlarmManager alarmManager = (AlarmManager)Application.Context.GetSystemService(Activity.AlarmService);
                alarmManager.Set(AlarmType.RtcWakeup, JavaSystem.CurrentTimeMillis() + (number * 60000), pi);
            }
            catch (System.Exception ex)
            {
                Toast.MakeText(Application.Context, "error: " + ex + " ", ToastLength.Short).Show();

            }
                 Toast.MakeText(Application.Context, "Wifi Disabled In: " + number + " minutes", ToastLength.Short).Show();
        }

    }
}