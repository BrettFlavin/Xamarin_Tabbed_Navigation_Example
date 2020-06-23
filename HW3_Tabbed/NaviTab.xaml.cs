using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HW3_Tabbed
{
    [DesignTimeVisible(false)]
    public partial class NaviTab : TabbedPage
    {
        public NaviTab()
        {
            InitializeComponent();

            // disables side-swiping between tabbed pages
            // must enable so the horizontal scrollviews of pictures scroll properly 
            Xamarin.Forms.PlatformConfiguration.AndroidSpecific.TabbedPage.SetIsSwipePagingEnabled(this, false);
        }
       
    }
}
