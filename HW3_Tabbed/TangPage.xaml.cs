using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HW3_Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TangPage : ContentPage
    {
        public TangPage()
        {
            InitializeComponent();
        }

        // when user clicks button - show current local time at Lake Tanganyika
        private void TangTimeButton_Clicked(object sender, EventArgs e)
        {
            // use a timer to dynamically update the local time on the Text label
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                // get Lake Tanganyika's tz database id and then convert time
                TimeZoneInfo estZone = TimeZoneInfo.FindSystemTimeZoneById("Africa/Lubumbashi");
                DateTime estTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, estZone);
                Device.BeginInvokeOnMainThread(() =>
                TangTime.Text = estTime.ToString("HH:mm:ss")
                );

                return true;
            });
        }
    }
}