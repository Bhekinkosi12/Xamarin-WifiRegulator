using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Wifi.Interfaces;

namespace Timer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Set_Time : ContentPage
    {
        public Set_Time()
        {
            InitializeComponent();
            TimePicked.SelectedIndex = 0;
            
                  }
        public void Button_Click()
        {
           string Time_Chosen = TimePicked.SelectedItem.ToString();
            Time_Chosen = Time_Chosen.Substring(0, Time_Chosen.LastIndexOf(' '));
            int number = Int32.Parse(Time_Chosen);
            DependencyService.Get<IWIFI_INT>().Switchwifi(number);

        }

        private void Button_Released(object sender, EventArgs e)
        {
           SetButton.Image = "redbutton.png";

        }

        private void SetButton_Pressed(object sender, EventArgs e)
        {
            SetButton.Image = "redbuttonpressed.png";
            
        }
    }
}
