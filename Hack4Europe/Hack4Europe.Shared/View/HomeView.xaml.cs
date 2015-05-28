using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Controls;

namespace Hack4Europe.View
{
    public sealed partial class HomeView : Page
    {
        public HomeView()
        {
            InitializeComponent();
#if WINDOWS_PHONE_APP
            StatusBar.GetForCurrentView().HideAsync();
#endif

        }
    }
}
