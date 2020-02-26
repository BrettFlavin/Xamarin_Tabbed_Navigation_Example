using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HW3_Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AfricaPage : ContentPage
    {
        public AfricaPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        // command to open browser with link
        // must mark Device.OpenUri as obsolete here
        [Obsolete]
        public ICommand LinkClicked => new Command<string>((url) =>
        {
            Device.OpenUri(new Uri(url));
        });
    }
}